using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Drawing;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.ItemScaling
{
    public class ComboBoxMouseOverBehavior : PropertyChangeBehavior
    {
        bool popupShown;
        ZoomPopup popup = null;
        RadListVisualItem item = null;

        public ComboBoxMouseOverBehavior()
        : base(RadItem.IsMouseOverProperty)
        {
        }

        DropDownPopupForm comboPopup = null;

        public override void OnPropertyChange(RadElement element, RadPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue == true)
            {
                this.item = element as RadListVisualItem;

                if (!this.popupShown)
                {
                    comboPopup = item.ElementTree.Control as DropDownPopupForm;
                    if (comboPopup == null)
                    {
                        return;
                    }
                    
                    comboPopup.PopupClosing += comboPopup_PopupClosing;                    
                    if (comboPopup.IsDisplayed)
                    {
                        this.popupShown = true;
                        this.popup = new ZoomPopup(element, new SizeF(1.1f, 1.1f));
                        this.popup.BeginInit();
                        this.WireEvents();
                        this.popup.EndInit();
                        this.popup.Show();
                    }
                }
            }
        }

        void comboPopup_PopupClosing(object sender, RadPopupClosingEventArgs args)
        {
            if (this.popupShown)// && args.CloseReason == RadPopupCloseReason.Keyboard)
            {
                this.popup.Hide();
                //selectedItem.OwnerElement.SelectedItem = selectedItem;
            }

            RadPopupControlBase comboPopup = sender as RadPopupControlBase;
            comboPopup.PopupClosing -= comboPopup_PopupClosing;
        }

        private void WireEvents()
        {
            this.popup.Closed += new EventHandler(ClosePopup);
            this.popup.Click += new EventHandler(popup_Click);
        }

        private void UnWireEvents()
        {
            this.popup.Closed -= new EventHandler(ClosePopup);
            this.popup.Click -= new EventHandler(popup_Click);
        }

        void popup_Click(object sender, EventArgs e)
        {
            if (this.comboPopup == null)
            {
                return;
            }
                       
            RadListDataItem dataItem = this.item.Data;
            this.popup.Hide();
            this.comboPopup.ClosePopup(RadPopupCloseReason.CloseCalled);
            this.comboPopup.OwnerDropDownListElement.SelectedItem = dataItem;
            
        }

        void ClosePopup(object sender, EventArgs ea)
        {
            this.popupShown = false; 
            this.UnWireEvents();
            this.item = null;
            this.popup = null;
        }
    }
}
