﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace Telerik.Examples.WinControls.Forms.MDI
{
    /// <summary>
    /// example form
    /// </summary>
    public partial class Form1 : Telerik.WinControls.UI.RadForm
    {
        private static Size ChildSize = new Size(580, 200);
        /// <summary>
        /// default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.Text = "RadForm MDI Parent with RadMenu";
            this.ThemeName = "Desert";
            this.radMenu1.ThemeName = "Desert";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Form child1 = new Form();
            child1.Size = ChildSize;
            child1.Text = "Standard Windows Form1 with no menu";
            child1.MdiParent = this;
            child1.Show();

            RadChildForm2 child4 = new RadChildForm2();
            child4.Size = ChildSize;
            child4.Text = "RadForm2 with no menu";
            child4.ThemeName = "Desert";
            child4.MdiParent = this;
            child4.Show();
                      
            RadChildForm child2 = new RadChildForm();
            child2.Size = ChildSize;
            child2.Text = "RadForm3 with RadMenu";
            child2.ThemeName = "Desert";
            child2.MdiParent = this;
            child2.Show();

        }

        private void radMenuItem7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            { 
                this.ActiveMdiChild.Close(); 
            }
        }

        private void radMenuItem8_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        int i = 4;

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            RadChildForm2 child = new RadChildForm2();
            child.Size = ChildSize;
            child.Text = "RadForm" + i.ToString();
            child.ThemeName = "Desert";
            child.MdiParent = this;
            child.Show();
            i++;
        }
    }
}