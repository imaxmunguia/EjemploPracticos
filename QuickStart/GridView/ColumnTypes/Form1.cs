using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.IO;
using System.Diagnostics;
using Telerik.WinControls.Primitives;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;

namespace Telerik.Examples.WinControls.GridView.ColumnTypes
{
    public partial class Form1 : ExamplesForm
    {
        private Random rand = new Random();

        enum TitleOfCourtesy
        {
            Mr,
            Ms,
            Mrs,
            Dr
        }

        public Form1()
        {
            InitializeComponent();

            this.SelectedControl = this.radGridView1;

            this.radGridView1.CellFormatting += new CellFormattingEventHandler(radGridView1_CellFormatting);
            this.radGridView1.CellBeginEdit += new GridViewCellCancelEventHandler(radGridView1_CellBeginEdit);
        }

        private void BindGrid()
        {
            this.employeesTableAdapter.Fill(this.nwindDataSet.Employees);
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            radGridView1.DataSource = this.nwindDataSet.Employees;

            GridViewDecimalColumn decimalColumn = new GridViewDecimalColumn();
            decimalColumn.FieldName = "EmployeeID";
            decimalColumn.Name = "EmployeeID";
            decimalColumn.HeaderText = "Decimal";
            decimalColumn.DecimalPlaces = 0;
            decimalColumn.Width = 100;
            decimalColumn.IsVisible = false;
            this.radGridView1.Columns.Add(decimalColumn);

            GridViewTextBoxColumn textBoxColumn = new GridViewTextBoxColumn();
            textBoxColumn.FieldName = "LastName";
            textBoxColumn.Name = "LastName";
            textBoxColumn.HeaderText = "Text";
            textBoxColumn.Width = 100;
            textBoxColumn.IsVisible = false;
            this.radGridView1.Columns.Add(textBoxColumn);

            GridViewImageColumn imageColumn = new GridViewImageColumn();
            imageColumn.FieldName = "Photo";
            imageColumn.Name = "Photo";
            imageColumn.HeaderText = "Image";
            imageColumn.ImageLayout = ImageLayout.Zoom;
            imageColumn.Width = 54;
            this.radGridView1.Columns.Add(imageColumn);

            GridViewComboBoxColumn lookUpColumn = new GridViewComboBoxColumn();
            lookUpColumn.FieldName = "TitleOfCourtesy";
            lookUpColumn.Name = "LookUp";
            lookUpColumn.HeaderText = "LookUp";
            lookUpColumn.DataSource = new string[] { "Mr.", "Mrs.", "Dr.", "Ms." };
            lookUpColumn.Width = 100;
            lookUpColumn.IsVisible = false;
            this.radGridView1.Columns.Add(lookUpColumn);

            GridViewMaskBoxColumn maskBoxColumn = new GridViewMaskBoxColumn();
            maskBoxColumn.FieldName = "HomePhone";
            maskBoxColumn.Name = "MaskBox";
            maskBoxColumn.HeaderText = "MaskBox";
            maskBoxColumn.MaskType = MaskType.Standard;
            maskBoxColumn.Mask = "(###) ###-####";
            maskBoxColumn.Width = 200;
            maskBoxColumn.IsVisible = false;
            this.radGridView1.Columns.Add(maskBoxColumn);

            GridViewHyperlinkColumn hyperlinkColumn = new GridViewHyperlinkColumn("Hyperlink");
            hyperlinkColumn.ReadOnly = true;
            hyperlinkColumn.Width = 200;
            this.radGridView1.Columns.Add(hyperlinkColumn);

            GridViewColorColumn colorColumn = new GridViewColorColumn("Color");
            colorColumn.Width = 100;
            this.radGridView1.Columns.Add(colorColumn);

            GridViewCalculatorColumn calculatorColumn = new GridViewCalculatorColumn("Calculator");
            calculatorColumn.Width = 80;
            this.radGridView1.Columns.Add(calculatorColumn);

            GridViewBrowseColumn browseColumn = new GridViewBrowseColumn("Browse");
            browseColumn.Width = 180;
            this.radGridView1.Columns.Add(browseColumn);

            GridViewCheckBoxColumn checkBoxColumn = new GridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "CheckBox";
            checkBoxColumn.Name = "CheckBox";
            checkBoxColumn.Width = 100;
            checkBoxColumn.IsVisible = false;
            this.radGridView1.Columns.Add(checkBoxColumn);

            GridViewDataColumn commandColumn = new GridViewTextBoxColumn();
            commandColumn.HeaderText = "Custom";
            commandColumn.Name = "ProgressBar";
            commandColumn.DataType = typeof(int);
            commandColumn.ReadOnly = true;
            commandColumn.Width = 100;
            this.radGridView1.Columns.Add(commandColumn);

            this.PopulateUnboundColumns();
        }

        private void PopulateUnboundColumns()
        {
            this.radGridView1.TableElement.BeginUpdate();

            for (int i = 0; i < this.radGridView1.Rows.Count; i++)
            {
                int number = rand.Next(0, 100);
                this.radGridView1.Rows[i].Cells["CheckBox"].Value = i % 2 == 0;
                this.radGridView1.Rows[i].Cells["ProgressBar"].Value = number;
                this.radGridView1.Rows[i].Cells["Calculator"].Value = number;
            }

            this.radGridView1.Rows[0].Cells["Hyperlink"].Value = "http://www.telerik.com";
            this.radGridView1.Rows[1].Cells["Hyperlink"].Value = "http://www.microsoft.com";
            this.radGridView1.Rows[2].Cells["Hyperlink"].Value = "http://www.google.com";
            this.radGridView1.Rows[3].Cells["Hyperlink"].Value = "http://www.cnn.com";
            this.radGridView1.Rows[4].Cells["Hyperlink"].Value = "http://www.bbc.com";
            this.radGridView1.Rows[5].Cells["Hyperlink"].Value = "http://www.telerikwatch.com";
            this.radGridView1.Rows[6].Cells["Hyperlink"].Value = "http://www.wikipedia.com";
            this.radGridView1.Rows[7].Cells["Hyperlink"].Value = "http://blogs.telerik.com/blogs.aspx";
            this.radGridView1.Rows[8].Cells["Hyperlink"].Value = "http://www.telerik.com/community/forums.aspx";

            this.radGridView1.Rows[0].Cells["Color"].Value = "Red";
            this.radGridView1.Rows[1].Cells["Color"].Value = "Orange";
            this.radGridView1.Rows[2].Cells["Color"].Value = "Yellow";
            this.radGridView1.Rows[3].Cells["Color"].Value = "Green";
            this.radGridView1.Rows[4].Cells["Color"].Value = "Blue";
            this.radGridView1.Rows[5].Cells["Color"].Value = "Indigo";
            this.radGridView1.Rows[6].Cells["Color"].Value = "Violet";
            this.radGridView1.Rows[7].Cells["Color"].Value = "White";
            this.radGridView1.Rows[8].Cells["Color"].Value = "Black";

            this.radGridView1.Rows[0].Cells["Browse"].Value = @"C:\Music\Sting\If You Love Somebody Set Them Free.wav";
            this.radGridView1.Rows[1].Cells["Browse"].Value = @"C:\Music\Sting\Russians.wav";
            this.radGridView1.Rows[2].Cells["Browse"].Value = @"C:\Music\Sting\Fortress Around Your Heart.wav";
            this.radGridView1.Rows[3].Cells["Browse"].Value = @"C:\Music\Sting\Love Is the Seventh Wave.wav";
            this.radGridView1.Rows[4].Cells["Browse"].Value = @"C:\Music\Sheryl Crow\Run, Baby, Run.wav";
            this.radGridView1.Rows[5].Cells["Browse"].Value = @"C:\Music\Sheryl Crow\Leaving Las Vegas.wav";
            this.radGridView1.Rows[6].Cells["Browse"].Value = @"C:\Music\Sheryl Crow\Strong Enough.wav";
            this.radGridView1.Rows[7].Cells["Browse"].Value = @"C:\Music\Sheryl Crow\Maybe Angels.wav";
            this.radGridView1.Rows[8].Cells["Browse"].Value = @"C:\Music\Sheryl Crow\A Change Would Do You Good.wav";

            this.radGridView1.TableElement.EndUpdate();
        }

        #region Event handling

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.EnableFiltering = false;
            this.radGridView1.MasterTemplate.EnableSorting = false;
            this.radGridView1.TableElement.EnableHotTracking = false;
            this.radGridView1.TableElement.TableHeaderHeight = 35;
            this.radGridView1.TableElement.RowHeight = 60;

            this.BindGrid();
        }

        private void radGridView1_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            RadDropDownListEditor comboBoxEditor = this.radGridView1.ActiveEditor as RadDropDownListEditor;
            if (comboBoxEditor != null)
            {
                comboBoxEditor.EditorElement.StretchVertically = false;
                comboBoxEditor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                comboBoxEditor.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
            }
        }

        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.RowInfo is GridViewFilteringRowInfo)
            {
                return;
            }

            if (e.CellElement.ColumnInfo.Name == "ProgressBar")
            {
                RadProgressBarElement progressBarElement;
                if (e.CellElement.Children.Count == 0)
                {
                    progressBarElement = new RadProgressBarElement();
                    e.CellElement.Children.Add(progressBarElement);
                    progressBarElement.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                }
                else
                {
                    progressBarElement = e.CellElement.Children[0] as RadProgressBarElement;
                }
                progressBarElement.Margin = new Padding(15);
                progressBarElement.StretchHorizontally = true;


                int value = 0;

                if (e.CellElement.Value != null)
                {
                    try
                    {
                        Int32.TryParse(((GridDataCellElement)e.CellElement).Value.ToString(), out value);
                    }
                    catch
                    {
                        value = 0;
                    }
                }

                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 100)
                {
                    value = 100;
                }

                progressBarElement.Value1 = value;
            }
            else
            {
                if (e.CellElement.ColumnInfo.Name != "CheckBox" && e.CellElement.ColumnInfo.Name != "Hyperlink" && e.CellElement.ColumnInfo.Name != "Color" &&
                    !(e.CellElement.IsCurrent && this.radGridView1.IsInEditMode))
                {
                    e.CellElement.Children.Clear();
                }

                if (e.CellElement.ColumnInfo.Name == "MaskBox")
                {
                    long result;
                    if (e.CellElement.Text.Contains("(") || !long.TryParse(e.CellElement.Text, out result))
                    {
                        return;
                    }
                    e.CellElement.Text = String.Format("{0:(000) 000-0000}", result);
                }

                if (e.CellElement.ColumnInfo.Name == "Color")
                {
                    GridColorCellElement cell = e.CellElement as GridColorCellElement;
                    cell.ColorBox.StretchVertically = false;
                    cell.ColorBox.Alignment = ContentAlignment.MiddleCenter;
                    cell.ColorBox.MinSize = new Size(20, 20);
                }
            }
        }

        private void radCheckBoxDecimal_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.Columns["EmployeeID"].IsVisible = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxText_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.Columns["LastName"].IsVisible = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxImage_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.Columns["Photo"].IsVisible = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxLookUp_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.Columns["LookUp"].IsVisible = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxMaskBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.Columns["MaskBox"].IsVisible = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxHyperlink_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.Columns["Hyperlink"].IsVisible = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxColor_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.Columns["Color"].IsVisible = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxCalculator_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.Columns["Calculator"].IsVisible = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxBrowse_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.Columns["Browse"].IsVisible = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.Columns["CheckBox"].IsVisible = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxCustom_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.Columns["ProgressBar"].IsVisible = args.ToggleState == ToggleState.On;
        }

        #endregion

        protected override string GetExampleDefaultTheme()
        {
            return "ControlDefault";
        }
    }
}
