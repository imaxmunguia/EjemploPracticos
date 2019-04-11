using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI.Docking;

namespace Telerik.Examples.WinControls.Docking.DocumentManager
{
    public partial class Form1 : ExamplesForm
    {
        private int docCounter = 11;

        public Form1()
        {
            InitializeComponent();

            this.radDock1.ShowDocumentCloseButton = true;
            this.radDock1.DocumentManager.DocumentCloseActivation = DocumentCloseActivation.FirstInZOrder;
        }

        protected override void OnLoad(EventArgs e)
        {
            ThemeResolutionService.ApplyThemeToControlTree(this.settingsPanel, MainForm.DefaultTheme);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radDock1.DocumentManager.ActivateNextDocument();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.radDock1.DocumentManager.ActivatePreviousDocument();
        }

        private void sortNone_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radDock1.DocumentManager.ActiveDocumentMenuSortOrder = Telerik.WinControls.UI.Docking.ActiveDocumentListSortOrder.None;
        }

        private void sortByName_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radDock1.DocumentManager.ActiveDocumentMenuSortOrder = Telerik.WinControls.UI.Docking.ActiveDocumentListSortOrder.ByText;
        }

        private void sortByActivation_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radDock1.DocumentManager.ActiveDocumentMenuSortOrder = Telerik.WinControls.UI.Docking.ActiveDocumentListSortOrder.ZOrdered;
        }

        private void addDoc_Click(object sender, EventArgs e)
        {
            DocumentWindow docWindow = new DocumentWindow("documentWindow" + docCounter++);
            this.radDock1.AddDocument(docWindow);
        }
    }
}
