using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors.ComboBox;
using System.IO;
using System.Reflection;

namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.ItemScaling
{
	public partial class Form1 : EditorExampleBaseForm
	{
        private const string THEME = "ControlDefault";
        private Timer showDropDownTimeout;
        private Assembly executingAssembly;
        private Font arialFont;
		public Form1()
		{
			InitializeComponent();
            this.radComboDemo.AutoSizeItems = true;
            this.radComboDemo.DefaultItemsCountInDropDown = 15;
            this.radComboDemo.DropDownAnimationEnabled = false;
            this.radComboDemo.VisualListItemFormatting += new Telerik.WinControls.UI.VisualListItemFormattingEventHandler(radComboDemo_VisualListItemFormatting);
			this.SelectedControl = this.radComboDemo;
            this.showDropDownTimeout = new Timer(this.components);
            this.showDropDownTimeout.Tick += new EventHandler(showDropDownTimeout_Tick);
            this.showDropDownTimeout.Interval = 1000;
            this.showDropDownTimeout.Start();
            arialFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
		}

        void radComboDemo_VisualListItemFormatting(object sender, Telerik.WinControls.UI.VisualItemFormattingEventArgs args)
        {           
            args.VisualItem.AddBehavior(new ComboBoxMouseOverBehavior());
            args.VisualItem.Font = arialFont;
        }

        private void SetTheme()
        {
            this.radComboDemo.ThemeName = THEME;
        }

        #region Event handling

        private Image GetImageFromResource(string imageFileName)
        {
            Image img;
            Stream imageStream;

            if (executingAssembly == null)
            {
                this.executingAssembly = Assembly.GetExecutingAssembly();
            }

            imageStream = this.executingAssembly.GetManifestResourceStream(
                String.Format("Telerik.Examples.WinControls.Resources.CarPictures.{0}", imageFileName));
            img = Bitmap.FromStream(imageStream);

            if (img == null)
            {
                imageStream = this.executingAssembly.GetManifestResourceStream(
                String.Format(imageFileName));
                img = Bitmap.FromStream(imageStream);
            }

            return img;
        }

        void showDropDownTimeout_Tick(object sender, EventArgs e)
        {
            this.radComboDemo.Focus();
            this.radComboDemo.ShowDropDown();
            this.showDropDownTimeout.Stop();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.SetTheme();

            base.OnLoad(e);
        }

        #endregion
    }
}
