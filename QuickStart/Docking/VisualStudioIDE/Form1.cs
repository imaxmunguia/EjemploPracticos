using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI.Docking;
using System.IO;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Docking.VisualStudioIDE
{
    public partial class Form1 : Form
    {
        private static readonly string RtfFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Docking\VisualStudioIDE\Files");
        private static readonly string Form1RftFile = Path.Combine(RtfFolder, "Form1.rtf");
        private static readonly string Form1DesignerRftFile = Path.Combine(RtfFolder, "Form1.Designer.rtf");
        private static readonly string OutputFile = Path.Combine(RtfFolder, "Output.rtf");

        const int ErrorGridRow = 1;
        const int ErrorGridLine = 20;
        const int ErrorGridColumn = 33;
        const string ErrorGridFile = "Program.cs";
        const string ErrorGridProject = "ProjectTracker";
        const string ErrorGridDescription = @"The type or namespace name 'Form12' could not be found (are you missing a using directive or an assembly reference?)	C:\ProjectTracker\Program.cs";
        
        const string TaskGridDescription = @"TO DO: Refactor the whole data access layer to use Open Access";
        const string TaskGridFile = @"DBPool.cs";
        const int TaskGridLine = 501;


        public Form1()
        {
            InitializeComponent();

            this.radDock1.DockingGuidesTemplate = PredefinedDockingGuidesTemplate.VS2008;
            ThemeResolutionService.LoadPackageResource("Telerik.Examples.WinControls.Docking.VisualStudioIDE.VisualStudio2008.tssp");
            this.radDock1.ThemeName = "VisualStudio2008";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetupAllGrids();
            this.SetupToolWindowImages();
            
            this.richTextBoxForm.Rtf = this.ReadFile(Form1RftFile);
            this.richTextBoxDesigner.Rtf = this.ReadFile(Form1DesignerRftFile);
            this.richTextBoxOutput.Rtf = this.ReadFile(OutputFile);
        }

        private void SetupToolWindowImages()
        {
            toolWindow5.Image = ImageList.Images[1];
            toolWindow3.Image = ImageList.Images[5];
            toolWindow4.Image = ImageList.Images[14];
        }

        private void SetupAllGrids()
        {
            this.radGridViewErrors.Columns["columnImage"].HeaderText = String.Empty;
            this.radGridViewErrors.Columns["columnNumber"].HeaderText = String.Empty;

            this.radGridViewErrors.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            Image image = ImageList.Images[11];
            
            this.radGridViewErrors.Rows.Add(image, ErrorGridRow, ErrorGridDescription, ErrorGridFile, ErrorGridLine, ErrorGridColumn, ErrorGridProject);
            this.radGridViewErrors.MasterTemplate.ShowRowHeaderColumn = false;

            this.radGridViewTasks.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridViewTasks.Rows.Add(String.Empty, TaskGridDescription, TaskGridFile, TaskGridLine);
            this.radGridViewTasks.MasterTemplate.ShowRowHeaderColumn = false;
        }

        private string ReadFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException(filePath);

            return File.ReadAllText(filePath);
        }
       
    }
}
