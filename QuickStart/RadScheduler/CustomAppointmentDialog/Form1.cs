using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.RadScheduler.CustomAppointmentDialog
{
    public partial class Form1 : ExamplesForm
    {
        CustomEditAppointmentDialog appointmentDialog = null;

        public Form1()
        {
            InitializeComponent();

            this.radSchedulerDemo.AppointmentFactory = new CustomAppointmentFactory();
        }

        protected override string GetExampleDefaultTheme()
        {
            return "ControlDefault";
        }

        private void radSchedulerDemo_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
        {
            if (this.appointmentDialog == null)
            {
                this.appointmentDialog = new CustomEditAppointmentDialog();
            }
            this.appointmentDialog.ThemeName = this.radSchedulerDemo.ThemeName;
            e.AppointmentEditDialog = this.appointmentDialog;
        }
    }
}
