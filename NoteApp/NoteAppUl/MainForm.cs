﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUl
{
    public partial class MainForm : Form
    { Project Note = new Project { };
        public MainForm()
        {
            download();
            InitializeComponent();
        }



        void download()
        {
            Note = ProjectManager.Download();
        }



        AboutMe dlg = new AboutMe();
      
        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!dlg.Visible)
                dlg.Show(this);
        }
    }
}
