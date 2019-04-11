using System;
using System.ComponentModel;
using System.Drawing;
using Telerik.Examples.WinControls.Editors.ComboBox;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Editors.SpinEdit.FirstLook
{

    /// <summary>
    /// example forms
    /// </summary>
    public partial class Form1 : EditorExampleBaseForm
    {
        private const string THEME = "ControlDefault";

        public Form1()
        {
            InitializeComponent();              

            this.radSpinDemo.ValueChanging+=new Telerik.WinControls.UI.ValueChangingEventHandler(radSpinEdit1_ValueChanging);
            this.radSpinDemo.ValueChanged += new EventHandler(radSpinEditor1_ValueChanged);
            this.radSpinDemo.RightToLeftChanged += new EventHandler(radSpinEditor1_RightToLeftChanged);
            this.radSpinDemo.PropertyChanged += new PropertyChangedEventHandler(radSpinEditor1_PropertyChanged);

            this.SetTheme();
        }

        void radSpinEditor1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            RadListDataItem item = new RadListDataItem();
            item.Text = "PropertyChanged\n";
            item.Font = new Font("Lucida Sans Unicode", 7.2f);
            this.radListBox1.Items.Add(item);
        }

        void radSpinEditor1_RightToLeftChanged(object sender, EventArgs e)
        {
            RadListDataItem item = new RadListDataItem();
            item.Text = "RightToLeftChanged fired\n";
            item.Font = new Font("Lucida Sans Unicode", 7.2f);
            this.radListBox1.Items.Add(item);
        }

        void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            RadListDataItem item = new RadListDataItem();
            item.Font = new Font("Lucida Sans Unicode", 7.2f);
            item.Text = "ValueChanged fired\n";
            this.radListBox1.Items.Add(item);
        }

        private void SetTheme()
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, THEME);
        }
        
        private void radSpinEdit1_ValueChanging(object sender, Telerik.WinControls.UI.ValueChangingEventArgs e)
        {
            RadListDataItem item = new RadListDataItem();
            item.Text = "ValueChanging fired\n";
            item.Font = new Font("Lucida Sans Unicode", 7.2f);
            this.radListBox1.Items.Add(item);
        }

        private void OnCheckRightToLeft_StateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radSpinDemo.RightToLeft = this.radCheckBox1.Checked ? System.Windows.Forms.RightToLeft.Yes : System.Windows.Forms.RightToLeft.No;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radListBox1.Items.Clear();
        }
    }
}