using System;
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

            comboBox1.Items.Add(Category_note.All);
            comboBox1.Items.Add(Category_note.Work);
            comboBox1.Items.Add(Category_note.House);
            comboBox1.Items.Add(Category_note.Heath_and_sport);
            comboBox1.Items.Add(Category_note.People);
            comboBox1.Items.Add(Category_note.Documents);
            comboBox1.Items.Add(Category_note.Finance);
            comboBox1.Items.Add(Category_note.Another);
        
      
        }



        void download()
        {
            Note = ProjectManager.Download();
        }


       
        AboutMe dlg = new AboutMe();
        Form3 dlg2 = new Form3();
        Form3 dlg3 = new Form3();
        Form3 dlg4 = new Form3();
        Form3 dlg5 = new Form3();

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
            if (!dlg3.Visible)
                dlg3.Show(this);
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

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!dlg2.Visible)
                dlg2.Show(this);
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!dlg3.Visible)
                dlg3.Show(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!dlg4.Visible)
                dlg4.Show(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           

        }
    }
}
