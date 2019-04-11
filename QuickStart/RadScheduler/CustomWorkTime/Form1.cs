using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.RadScheduler.CustomWorkTime
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.radScheduler1.ActiveView.StartDate = DateTime.Now.Date;

            SetDateTimePickersDefaultValues();

            this.radDateTimePicker1.DateTimePickerElement.ValueChanging += new ValueChangingEventHandler(DateTimePickerElement_ValueChanging1);
            this.radDateTimePicker2.DateTimePickerElement.ValueChanging += new ValueChangingEventHandler(DateTimePickerElement_ValueChanging2);

            FillAppointments();

            this.radSchedulerNavigator1.TimelineViewButtonVisible = false;
            this.radSchedulerNavigator1.MonthViewButtonVisible = false;

            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ScrollToWorkTime();
        }

        protected override string GetExampleDefaultTheme()
        {
            return "";
        }

        private void ScrollToWorkTime()
        {
            SchedulerDayViewElement dayViewElement = (this.radScheduler1.SchedulerElement.ViewElement as SchedulerDayViewElement);
            TimeSpan time = new TimeSpan(this.radDateTimePicker1.Value.Hour - 1, this.radDateTimePicker1.Value.Minute, 0);
            dayViewElement.DataAreaElement.Table.ScrollToTime(time);
        }

        private void FillAppointments()
        {
            this.radScheduler1.Appointments.BeginUpdate();

            DateTime dtStart = DateTime.Now.Date.AddDays(2).AddHours(10);
            DateTime dtEnd = DateTime.Now.Date.AddDays(2).AddHours(12);

            Appointment appointment = new Appointment(dtStart, dtEnd,
                "ASP.NET AJAX Or Silverlight Is The Future Of Web Development",
                "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build");
            appointment.BackgroundId = (int)AppointmentBackground.Anniversary;
            appointment.StatusId = (int)AppointmentStatus.Unavailable;
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(-1);
            dtEnd = dtEnd.AddDays(-1);

            appointment = new Appointment(dtStart.AddHours(2), dtEnd.AddHours(3),
                "Silverlight Made Easy",
                "This session will introduce people to Silverlight with coding in C# and VB.NET to build high quality, robust and elegant web sites.");
            appointment.BackgroundId = (int)AppointmentBackground.Business;
            appointment.StatusId = (int)AppointmentStatus.Free;
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(-1);
            dtEnd = dtEnd.AddDays(-1);

            appointment = new Appointment(dtStart.AddHours(4), dtEnd.AddHours(4),
                "SQL 2008",
                "SQL Server 2008 introduces support for Microsoft PowerShell. PowerShell is a powerful scripting shell that lets administrators and developers automate server administration and application deployment. It is more powerful than simple T-SQL and provides great features to SQL Server administrator. This session will cover the basics of the SQL Server providers in PowerShell.");
            appointment.BackgroundId = (int)AppointmentBackground.Important;
            appointment.StatusId = (int)AppointmentStatus.Tentative;
            this.radScheduler1.Appointments.Add(appointment);

            this.radScheduler1.Appointments.EndUpdate();
        } 

        void DateTimePickerElement_ValueChanging1(object sender, ValueChangingEventArgs e)
        {
            if ((DateTime)e.NewValue >= this.radDateTimePicker2.Value)
            {
                e.Cancel = true;
            }
        }

        void DateTimePickerElement_ValueChanging2(object sender, ValueChangingEventArgs e)
        {
            if ((DateTime)e.NewValue <= this.radDateTimePicker1.Value)
            {
                e.Cancel = true;
            }
        }

        private void SetDateTimePickersDefaultValues()
        {
            DateTime dtStart = new DateTime(
                DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                9, 0, 0);

            this.radDateTimePicker1.Value = dtStart;

            DateTime dtEnd = new DateTime(
                DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                14, 0, 0);

            this.radDateTimePicker2.Value = dtEnd;
        }

        private void radDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateWorkTime();
        }

        private void UpdateWorkTime()
        {
            TimeInterval timeInterval = new TimeInterval(this.radDateTimePicker1.Value.TimeOfDay, this.radDateTimePicker2.Value.TimeOfDay);
            ((SchedulerDayViewBase)this.radScheduler1.ActiveView).WorkTime = timeInterval;
        }

        private void radScheduler1_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            if (e.NewView.ViewType == e.OldView.ViewType)
            {
                return;
            }

            switch ( this.radScheduler1.ActiveViewType )
            {
                case SchedulerViewType.Day:
                    this.radScheduler1.GetDayView().DayCount = 3;
                    this.radGroupBox1.Enabled = true;
                    UpdateWorkTime();
                    ScrollToWorkTime();
                    break;
                case SchedulerViewType.Week:
                case SchedulerViewType.WorkWeek:
                    this.radGroupBox1.Enabled = true;
                    UpdateWorkTime();
                    ScrollToWorkTime();
                    break;
                default:
                    this.radGroupBox1.Enabled = false;
                    break;
            }
        }
    }
}
