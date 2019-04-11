using Telerik.QuickStart.WinControls;
using System;
using Telerik.WinControls.UI;
using System.Drawing;

namespace Telerik.Examples.WinControls.PropertyGrid.Events
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            if (this.radPropertyGrid1 != null)
            {
                this.radPropertyGrid1.Location = new Point((this.ClientSize.Width - radPropertyGrid1.Size.Width) / 2, this.radPropertyGrid1.Location.Y);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radPropertyGrid1.SelectedObject = new PropertyGridElement();
        }

        private void ShowEventMessage(string eventName) 
        {
            this.radTextBoxEvents.Text += string.Format("{0} fired" + Environment.NewLine, eventName);
            this.radTextBoxEvents.SelectionStart = this.radTextBoxEvents.Text.Length;
            this.radTextBoxEvents.ScrollToCaret();
        }

        private void radPropertyGrid1_ContextMenuOpening(object sender, PropertyGridContextMenuOpeningEventArgs e)
        {
            this.ShowEventMessage("ContextMenuOpening");
        }

        private void radPropertyGrid1_Edited(object sender, PropertyGridItemEditedEventArgs e)
        {
            this.ShowEventMessage("Edited");
        }

        private void radPropertyGrid1_Editing(object sender, PropertyGridItemEditingEventArgs e)
        {
            this.ShowEventMessage("Editing");
        }

        private void radPropertyGrid1_EditorInitialized(object sender, PropertyGridItemEditorInitializedEventArgs e)
        {
            this.ShowEventMessage("EditorInitialized");
        }

        private void radPropertyGrid1_EditorRequired(object sender, PropertyGridEditorRequiredEventArgs e)
        {
            this.ShowEventMessage("EditorRequired");
        }

        private void radPropertyGrid1_ItemExpandedChanged(object sender, RadPropertyGridEventArgs e)
        {
            this.ShowEventMessage("ItemExpandedChanged");
        }

        private void radPropertyGrid1_ItemExpandedChanging(object sender, RadPropertyGridCancelEventArgs e)
        {
            this.ShowEventMessage("ItemExpandedChanging");
        }

        private void radPropertyGrid1_ItemMouseDoubleClick(object sender, RadPropertyGridEventArgs e)
        {
            this.ShowEventMessage("ItemMouseDoubleClick");
        }

        private void radPropertyGrid1_PropertyValidated(object sender, PropertyValidatedEventArgs e)
        {
            this.ShowEventMessage("PropertyValidated");
        }

        private void radPropertyGrid1_PropertyValidating(object sender, PropertyValidatingEventArgs e)
        {
            this.ShowEventMessage("PropertyValidating");
        }

        private void radPropertyGrid1_PropertyValueChanged(object sender, PropertyGridItemValueChangedEventArgs e)
        {
            this.ShowEventMessage("PropertyValueChanged");
        }

        private void radPropertyGrid1_PropertyValueChanging(object sender, PropertyGridItemValueChangingEventArgs e)
        {
            this.ShowEventMessage("PropertyValueChanging");
        }

        private void radPropertyGrid1_SelectedGridItemChanged(object sender, RadPropertyGridEventArgs e)
        {
            this.ShowEventMessage("SelectedGridItemChanged");
        }

        private void radPropertyGrid1_SelectedGridItemChanging(object sender, RadPropertyGridCancelEventArgs e)
        {
            this.ShowEventMessage("SelectedGridItemChanging");
        }
    }
}
