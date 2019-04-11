using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Forms.FirstLook
{
    /// <summary>
    /// example form
    /// </summary>
    public partial class Form1 : Telerik.WinControls.UI.RadForm
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.radGridView1.TableElement.RowHeight = 60;
            this.radGridView1.TableElement.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.radProgressBarElement1.Value1 < this.radProgressBarElement1.Maximum)
            {
                this.radProgressBarElement1.Value1++;
            }
            else
            {
                this.radProgressBarElement1.Value1 = this.radProgressBarElement1.Minimum;
            }
        }

        private void OnRadMenuItemChangeTheme_Click(object sender, EventArgs e)
        {
            RadMenuItem menuItem = (RadMenuItem) sender;

            foreach (RadMenuItem sibling in menuItem.HierarchyParent.Items)
            {
                sibling.IsChecked = false;
            }

            menuItem.IsChecked = true;

            string themeName = (string)(menuItem).Tag;
            ChangeThemeName(this, themeName);
        }

        private void ChangeThemeName(Control control, string themeName)
        {
            IComponentTreeHandler radControl = control as IComponentTreeHandler;
            if (radControl != null)
            {
                radControl.ThemeName = themeName;
            }

            foreach(Control child in control.Controls)
            {
                ChangeThemeName(child, themeName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            ThemeResolutionService.ApplyThemeToControlTree(this, "Desert");
        }

        private void radMenuItem17_Click(object sender, EventArgs e)
        {
            RadAboutBox.RadAboutBox1 aboutBox = 
                new Telerik.Examples.WinControls.Forms.RadAboutBox.RadAboutBox1();


            aboutBox.ThemeName = this.ThemeName;
            aboutBox.ShowDialog(this);
        }
    }
}
