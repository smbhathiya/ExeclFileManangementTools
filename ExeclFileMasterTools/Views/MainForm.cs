﻿using FileMasterTools.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMasterTools.Views
{
    public partial class MainForm : Form
    {
        private OrganizeFilesUserControl organizeFilesUserControl;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadFileHandlerUserControl();
        }

        private void LoadFileHandlerUserControl()
        {
            pnlContent.Controls.Clear(); 
            FileHandlerUserControl fileHandlerControl = new FileHandlerUserControl();
            fileHandlerControl.Dock = DockStyle.Fill; 
            pnlContent.Controls.Add(fileHandlerControl); 
        }
        private void LoadOrganizeFilesUserControl()
        {
            pnlContent.Controls.Clear();
            organizeFilesUserControl = new OrganizeFilesUserControl();
            organizeFilesUserControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(organizeFilesUserControl);
        }

        private void btnFileHandler_Click(object sender, EventArgs e)
        {
            LoadFileHandlerUserControl(); 
        }
        private void btnOrganizeFiles_Click(object sender, EventArgs e)
        {
            LoadOrganizeFilesUserControl(); 
        }
    }
}