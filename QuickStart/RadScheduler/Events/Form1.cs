using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.RadScheduler.Events
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override string GetExampleDefaultTheme()
        {
            return "ControlDefault";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            DateTime baseDate = DateTime.Today;
            DateTime[] start = new DateTime[] { baseDate.AddHours(14.0), baseDate.AddDays(1.0).AddHours(9.0), baseDate.AddDays(2.0).AddHours(13.0) };
            DateTime[] end = new DateTime[] { baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0) };
            string[] summaries = new string[] { "Mr. Brown", "Mr. White", "Mrs. Green" };
            string[] descriptions = new string[] { "", "", "" };
            string[] locations = new string[] { "City", "Out of town", "Service Center" };
            AppointmentBackground[] backgrounds = new AppointmentBackground[] { AppointmentBackground.Business, AppointmentBackground.MustAttend, AppointmentBackground.Personal };

            this.radSchedulerDemo.Appointments.BeginUpdate();
            Appointment appointment = null;
            for (int i = 0; i < summaries.Length; i++)
            {
                appointment = new Appointment(start[i], end[i], summaries[i],
                    descriptions[i], locations[i]);
                appointment.BackgroundId = (int)backgrounds[i];
                this.radSchedulerDemo.Appointments.Add(appointment);
            }

            appointment = new Appointment(baseDate.AddHours(11.0), baseDate.AddHours(12.0), "Wash the car", "", "Garage");
            appointment.RecurrenceRule = new DailyRecurrenceRule(baseDate.AddHours(11.0), 2);
            this.radSchedulerDemo.Appointments.Add(appointment);
            this.radSchedulerDemo.Appointments.EndUpdate();

            this.radSchedulerDemo.Resources.Add(new Resource(1, "Dell Laptop"));
            this.radSchedulerDemo.Resources.Add(new Resource(2, "Lenovo Laptop"));
            this.radSchedulerDemo.Resources.Add(new Resource(3, "Toshiba Laptop"));
            (this.radSchedulerDemo.ActiveView as SchedulerDayView).DayCount = 1;
            this.radTxtEventList.ReadOnly = true;
        }

        private void radScheduler1_AppointmentMouseDown(object sender, SchedulerAppointmentMouseEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentMouseDown\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radScheduler1_AppointmentMouseUp(object sender, SchedulerAppointmentMouseEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentMouseUp\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radScheduler1_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentEditDialogShowing\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radScheduler1_AppointmentSelected(object sender, SchedulerAppointmentEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentSelected\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radScheduler1_AppointmentSelecting(object sender, SchedulerAppointmentCancelEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentSelecting\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radScheduler1_CellClick(object sender, SchedulerCellEventArgs e)
        {
            this.radTxtEventList.Text += "CellClick\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radScheduler1_ActiveViewChanging(object sender, SchedulerViewChangingEventArgs e)
        {
            this.radTxtEventList.Text += "ActiveViewChanging\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radScheduler1_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            this.radTxtEventList.Text += "ActiveViewChanged\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radSchedulerDemo_RecurrenceEditDialogShowing(object sender, RecurrenceEditDialogShowingEventArgs e)
        {
            this.radTxtEventList.Text += "RecurrenceEditDialogShowing\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }
    }
}
