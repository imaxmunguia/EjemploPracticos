using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.RadScheduler.DragAndDrop
{
    public partial class Form1 : ExamplesForm
    {
        private enum AppointmentFields
        {
            Row,
            Summary,
            Location,
            Description,
            Start,
            End,
            Background,
            Status
        }

        #region private classes
        private class DragObject
        {
            private AppointmentFields status;
            private Dictionary<AppointmentFields, object> values = new Dictionary<AppointmentFields, object>();

            public AppointmentFields Status
            {
                get
                {
                    return this.status;
                }
                set
                {
                    this.status = value;
                }
            }

            public Dictionary<AppointmentFields, object> Values
            {
                get
                {
                    return this.values;
                }
            }
        }

        private class MyGridBehavior : BaseGridBehavior
        {
            private Point mouseDownPoint = Point.Empty;

            public override bool OnMouseDown(MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    mouseDownPoint = e.Location;
                }

                return base.OnMouseDown(e);
            }

            public override bool OnMouseMove(MouseEventArgs e)
            {
                if (e.Button != MouseButtons.Left)
                {
                    this.mouseDownPoint = Point.Empty;
                    return base.OnMouseMove(e);
                }

                if (!this.GridViewElement.IsInEditMode && this.ShouldBeginDrag(this.mouseDownPoint, e.Location))
                {
                    RadElement element = this.GridControl.ElementTree.GetElementAtPoint(e.Location);

                    GridCellElement cell = element as GridCellElement;

                    if (cell != null && cell == this.GridViewElement.CurrentCell)
                    {
                        DragObject dragObject = new DragObject();

                        dragObject.Values.Add(AppointmentFields.Summary, cell.RowInfo.Cells["Summary"].Value);
                        dragObject.Values.Add(AppointmentFields.Start, cell.RowInfo.Cells["Start"].Value);
                        dragObject.Values.Add(AppointmentFields.End, cell.RowInfo.Cells["End"].Value);
                        dragObject.Values.Add(AppointmentFields.Description, cell.RowInfo.Cells["Description"].Value);
                        dragObject.Values.Add(AppointmentFields.Background, cell.RowInfo.Cells["BackgroundID"].Value);
                        dragObject.Values.Add(AppointmentFields.Status, cell.RowInfo.Cells["StatusID"].Value);
                        dragObject.Values.Add(AppointmentFields.Location, cell.RowInfo.Cells["Location"].Value);

                        dragObject.Status = AppointmentFields.Row;

                        this.GridViewElement.ElementTree.Control.DoDragDrop(dragObject, DragDropEffects.Copy);
                        return true;
                    }
                }

                return base.OnMouseMove(e);
            }


            private bool ShouldBeginDrag(Point current, Point capture)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(capture.X - dragSize.Width / 2,
                                                   capture.Y - dragSize.Height / 2,
                                                   dragSize.Width, dragSize.Height);
                return !dragRect.Contains(current);
            }
        }
        #endregion

        #region Fields
        private Point mouseDownPosition;
        private bool isDragging;
        #endregion

        public Form1()
        {
            InitializeComponent();

            FillDataTableByEnum(this.schedulerDragAndDropDataDataSet.AppointmentStatuses, typeof(AppointmentStatus));

            FillDataTableByEnum(this.schedulerDragAndDropDataDataSet.AppointmentBackgrounds, typeof(AppointmentBackground));

            this.radGridView1.GridBehavior = new MyGridBehavior();
            this.radGridView1.CloseEditorWhenValidationFails = false;
            this.radGridView1.CellValidating += new CellValidatingEventHandler(radGridView1_CellValidating);
            this.radGridView1.CellBeginEdit += new GridViewCellCancelEventHandler(radGridView1_CellBeginEdit);

            this.radListBox1.MouseMove += new MouseEventHandler(radListBox1_MouseMove);
            this.radListBox1.MouseUp += new MouseEventHandler(radListBox1_MouseUp);

            this.radScheduler1.ActiveView.StartDate = new DateTime(2010, 1, 25);

            this.radSchedulerNavigator1.TimelineViewButtonVisible = false;
            this.radSchedulerNavigator1.MonthViewButtonVisible = false;

            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;
        }

        protected override string GetExampleDefaultTheme()
        {
            return "";
        }

        private void InitListBoxStyle()
        {
            this.radListBox1.Font = this.radGridView1.RootElement.FindDescendant<GridDataCellElement>().Font;

            this.radListBox1.RootElement.InvalidateMeasure();
            this.radListBox1.RootElement.UpdateLayout();
        }

        void radGridView1_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            RadDateTimeEditor radeditor = this.radGridView1.ActiveEditor as RadDateTimeEditor;
            if (radeditor != null)
            {
                radeditor.CustomFormat = "F";
            }
        }

        void radGridView1_CellValidating(object sender, CellValidatingEventArgs e)
        {
            GridViewDataColumn column = (GridViewDataColumn)e.Column;

            if (column != null && column.Name == "End")
            {
                DateTime date = (DateTime)e.Row.Cells["Start"].Value;
                DateTime newDate = (DateTime)e.Value;

                if (newDate < date)
                {
                    e.Cancel = true;
                }
            }
        }

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            this.appointmentsTableAdapter.Fill(this.schedulerDragAndDropDataDataSet.Appointments);
            this.radGridView1.MasterTemplate.BestFitColumns();

            InitListBoxStyle();
        }

        private void radScheduler1_DragDrop(object sender, DragEventArgs e)
        {
            Point point = this.radScheduler1.PointToClient(new Point(e.X, e.Y));

            DayViewAppointmentsTable table = (this.radScheduler1.SchedulerElement.ViewElement as SchedulerDayViewElement).DataAreaElement.Table;
            SchedulerCellElement schedulerCell = SchedulerUIHelper.GetCellAtPoint(point, table.Children);
            if (schedulerCell == null)
            {
                DayViewAllDayHeader allDay = (this.radScheduler1.SchedulerElement.ViewElement as SchedulerDayViewElement).AllDayHeaderElement;
                schedulerCell = SchedulerUIHelper.GetCellAtPoint(point, allDay.Children);
            }

            if (schedulerCell == null)
            {
                return;
            }

            DragObject dragObject = e.Data.GetData(typeof(DragObject)) as DragObject;
            if (dragObject != null)
            {
                this.radScheduler1.Appointments.BeginUpdate();
                Appointment appointment = CreateAppointment(schedulerCell.Date, dragObject);
                this.radScheduler1.Appointments.Add(appointment);
                this.radScheduler1.Appointments.EndUpdate();
            }
        }

        private void radScheduler1_DragEnter(object sender, DragEventArgs e)
        {
            DragObject dragObject = e.Data.GetData(typeof(DragObject)) as DragObject;

            e.Effect = dragObject == null ? DragDropEffects.None : DragDropEffects.Copy;
        }

        void radListBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDownPosition = Point.Empty;
            this.isDragging = false;
        }

        void radListBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            if (this.isDragging)
                return;

            Point currentPosition = e.Location;
            if ((Math.Abs(currentPosition.X - this.mouseDownPosition.X) >= SystemInformation.DragSize.Width) ||
                (Math.Abs(currentPosition.Y - this.mouseDownPosition.Y) >= SystemInformation.DragSize.Height))
            {
                this.isDragging = true;
                DragObject dragObject = new DragObject();
                RadListVisualItem item = this.radListBox1.ElementTree.GetElementAtPoint(e.Location) as RadListVisualItem;

                if (item != null)
                {
                    dragObject.Values.Add(AppointmentFields.Summary, item.Text);
                    dragObject.Status = AppointmentFields.Summary;

                    (sender as RadListControl).DoDragDrop(dragObject, DragDropEffects.Copy);
                }
            }
        }

        private void radListBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDownPosition = e.Location;
            base.OnMouseDown(e);
        }
        #endregion

        #region Methods
        private void FillDataTableByEnum(DataTable dt, Type enumType)
        {
            List<string> lstNames = new List<string>(Enum.GetNames(enumType));
            ArrayList arrlstValues = new ArrayList(Enum.GetValues(enumType));

            for (int i = 0; i < lstNames.Count; i++)
            {
                dt.Rows.Add(new object[] { arrlstValues[i], lstNames[i] });
            }
        }

        private Appointment CreateAppointment(DateTime currentDate, DragObject dragObject)
        {
            Appointment appointment = new Appointment();
            DateTime startDate = currentDate;
            DateTime endDate = currentDate.AddHours(1);
            switch (dragObject.Status)
            {
                case AppointmentFields.Summary:
                    appointment.Summary = dragObject.Values[dragObject.Status] as string;
                    break;
                case AppointmentFields.Row:
                    appointment.Summary = dragObject.Values[AppointmentFields.Summary] as string;
                    appointment.Description = dragObject.Values[AppointmentFields.Description] as string;
                    appointment.BackgroundId = (int)dragObject.Values[AppointmentFields.Background];
                    appointment.StatusId = (int)dragObject.Values[AppointmentFields.Status];
                    appointment.Location = dragObject.Values[AppointmentFields.Location] as string;

                    startDate = (DateTime)dragObject.Values[AppointmentFields.Start];
                    endDate = (DateTime)dragObject.Values[AppointmentFields.End];
                    if (this.radRadioButtonAnywhere.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                    {
                        TimeSpan range = endDate - startDate;
                        endDate = currentDate + range;
                        startDate = currentDate;
                    }
                    break;
            }
            appointment.Start = startDate;
            appointment.End = endDate;
            return appointment;
        }
        #endregion
    }
}
