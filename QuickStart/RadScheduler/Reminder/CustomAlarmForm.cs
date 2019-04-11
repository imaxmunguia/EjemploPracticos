using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.RadScheduler.Reminder
{
    public partial class CustomAlarmForm : Telerik.WinControls.UI.RadForm, IAlarmForm
    {
        private BindingList<RadReminderBindableObject> reminderBindableObjects;
        private TimeSpan startNotification = new TimeSpan(0, 15, 0);

        public CustomAlarmForm()
        {
            InitializeComponent();
            this.reminderBindableObjects = new BindingList<RadReminderBindableObject>();

            this.radListBox1.DisplayMember = "Subject";
            this.radListBox1.ValueMember = "Subject";
            this.radListBox1.DataSource = this.reminderBindableObjects;
        }

        private void CustomAlarmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner = null;
            if (e.CloseReason != CloseReason.ApplicationExitCall &&
                e.CloseReason != CloseReason.FormOwnerClosing &&
                e.CloseReason != CloseReason.WindowsShutDown)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        #region IAlarmForm Members
        public event EventHandler<RadOpenItemArgs> ItemOpened;

        /// <summary>
        /// Gets the remind objects count.
        /// </summary>
        /// <value>The reminder bindable objects count.</value>
        public virtual int RemindObjectsCount
        {
            get
            {
                return this.reminderBindableObjects.Count;
            }
        }

        /// <summary>
        /// Determines whether [contains reminder bindable object] [the specified reminder bindable object].
        /// </summary>
        /// <param name="reminderBindableObject">The remind bindable object.</param>
        /// <returns>
        /// 	<c>true</c> if [contains reminder bindable object] [the specified reminder bindable object]; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool ContainsRemindObject(RadReminderBindableObject reminderBindableObject)
        {
            return this.reminderBindableObjects.Contains(reminderBindableObject);
        }

        /// <summary>
        /// Adds the reminder bindable object.
        /// </summary>
        /// <param name="reminderBindableObject">The reminder bindable object.</param>
        public virtual void AddRemindObject(RadReminderBindableObject reminderBindableObject)
        {
            this.reminderBindableObjects.Insert(0, reminderBindableObject);
        }

        /// <summary>
        /// Removes the reminder bindable object.
        /// </summary>
        /// <param name="reminderBindableObject">The reminder bindable object.</param>
        /// <returns></returns>
        public virtual bool RemoveRemindObject(RadReminderBindableObject reminderBindableObject)
        {
            bool res = this.reminderBindableObjects.Remove(reminderBindableObject);

            if (this.reminderBindableObjects.Count < 1)
            {
                this.Hide();
            }

            return res;
        }

        /// <summary>
        /// Shows the form.
        /// </summary>
        public virtual void ShowForm()
        {
            if (!this.Visible)
            {
                this.Show();
            }
        }

        /// <summary>
        /// Shows the form.
        /// </summary>
        /// <param name="owner">The owner.</param>
        public virtual void ShowForm(IWin32Window owner)
        {
            if (!this.Visible)
            {
                this.Show(owner);
            }
        }

        /// <summary>
        /// In this override we reset the RootElement's BackColor property
        /// since the DocumentDesigner class sets the BackColor of the
        /// Form to Control when initializing and thus overrides the theme.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.UpdateDialogLocalization();
        }

        /// <summary>
        /// Updates the dialog localization.
        /// </summary>
        public void UpdateDialogLocalization()
        {
            //Apply the current localization provider.
        }

        /// <summary>
        /// Gets or sets the start notification.
        /// </summary>
        /// <value>The start notification.</value>
        public TimeSpan StartNotification
        {
            get
            {
                return this.startNotification;
            }
            set
            {
                this.startNotification = value;
            }
        }

        /// <summary>
        /// Clears the remind objects.
        /// </summary>
        public void ClearRemindObjects()
        {
            this.reminderBindableObjects.Clear();
        }

        /// <summary>
        /// Hides the form.
        /// </summary>
        public void HideForm()
        {
            this.Hide();
        }
        #endregion

        private void radButton1_Click(object sender, EventArgs e)
        {
            foreach (RadListDataItem item in this.radListBox1.SelectedItems)
            {
                RadReminderBindableObject reminderBindableObject = item.DataBoundItem as RadReminderBindableObject;
                this.OnItemOpened(reminderBindableObject.RemindObject);
            }
        }

        private void OnItemOpened(IRemindObject remidableObject)
        {
            if (this.ItemOpened != null)
            {
                this.ItemOpened(this, new RadOpenItemArgs(remidableObject));
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            List<int> selectedIndexes = this.GetSelectedIndexes();
            for (int i = selectedIndexes.Count - 1; i >= 0; i--)
            {
                int selectedIndex = selectedIndexes[i];
                RadListDataItem item = this.radListBox1.Items[selectedIndex];
                RadReminderBindableObject reminderBindableObject = item.DataBoundItem as RadReminderBindableObject;
                TimeSpan snooze = DateTime.Now.Subtract(reminderBindableObject.StartDateTime);
                reminderBindableObject.Snoozed = this.startNotification + snooze + (new TimeSpan(0, 1, 0));
                this.RemoveRemindObject(reminderBindableObject);
            }

            EnableButtons();
        }

        private List<int> GetSelectedIndexes()
        {
            List<int> resList = new List<int>();
            foreach (RadListDataItem item in this.radListBox1.SelectedItems)
            {
                resList.Add(this.radListBox1.Items.IndexOf( item ));
            }
            resList.Sort();
            return resList;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            List<int> selectedIndexes = this.GetSelectedIndexes();
            for (int i = selectedIndexes.Count - 1; i >= 0; i--)
            {
                int selectedIndex = selectedIndexes[i];
                RadListDataItem item = this.radListBox1.Items[selectedIndex];
                DismissItem(item);
            }

            EnableButtons();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            for (int i = this.radListBox1.Items.Count - 1; i >= 0; i--)
            {
                RadListDataItem item = this.radListBox1.Items[i];
                DismissItem(item);
            }

            EnableButtons();
        }

        private void DismissItem(RadListDataItem item)
        {
            RadReminderBindableObject reminderBindableObject = item.DataBoundItem as RadReminderBindableObject;
            reminderBindableObject.Dismissed = true;
            this.RemoveRemindObject(reminderBindableObject);
        }

        private void EnableButtons()
        {
            bool enableButtons = (this.radListBox1.SelectedItems.Count > 0);
            this.radButton3.Enabled = enableButtons;
            this.radButton2.Enabled = enableButtons;
            this.radButton1.Enabled = enableButtons;

            this.radButton4.Enabled = (this.radListBox1.Items.Count > 0);
        }

        private void radListBox1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            EnableButtons();
        }

        protected override void OnThemeChanged()
        {
            base.OnThemeChanged();

            ThemeResolutionService.ApplyThemeToControlTree(this, this.ThemeName);
        }
    }
}
