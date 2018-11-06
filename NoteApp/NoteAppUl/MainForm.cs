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
using System.IO;

namespace NoteAppUl
{
    public partial class MainForm : Form
    {
        public static Project Notes = new Project ();
         

        public MainForm()
        {


            InitializeComponent();
            Notes = ProjectManager.Download();
            foreach (var note in Notes.NoteList)
            {
                NoteListBox.Items.Add(note.Title);
            }
           
           
            CategoryComboBox.Items.Add(CategoryNote.All);
            CategoryComboBox.Items.Add(CategoryNote.Work);
            CategoryComboBox.Items.Add(CategoryNote.House);
            CategoryComboBox.Items.Add(CategoryNote.Heath_and_sport);
            CategoryComboBox.Items.Add(CategoryNote.People);
            CategoryComboBox.Items.Add(CategoryNote.Documents);
            CategoryComboBox.Items.Add(CategoryNote.Finance);
            CategoryComboBox.Items.Add(CategoryNote.Another);             
        }
  
        AboutMe dlg = new AboutMe();
        Add_Edit_Note dlg2 = new Add_Edit_Note();
  

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
                dlg.Show(this);
        }



        private void AddButton_Click(object sender, EventArgs e)
        {

            AddNote();
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Notes.NoteList[NoteListBox.SelectedIndex].Title;
            CreatedDateTimePicker.Value = Notes.NoteList[NoteListBox.SelectedIndex].CreationTime;
            ModifiedDateTimePicker.Value = Notes.NoteList[NoteListBox.SelectedIndex].LastChangeTime;
            ReadOnlyListView.Text = Notes.NoteList[NoteListBox.SelectedIndex].TextNote;


        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }
        private void AddNote() // Метод добавления заметки.
        {
            var sIndex = NoteListBox.SelectedIndex;
            var addater = new Add_Edit_Note();
            addater.Note = null;
            var result = addater.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var upCont = addater.Note;
                NoteListBox.Items.Clear();
                Notes.NoteList.Add(upCont);
                foreach (var note in Notes.NoteList)
                {
                    NoteListBox.Items.Add(note.Title);
                }
                ProjectManager.Save(MainForm.Notes);
            }
              
        }
        private void EditNote() // Метод редактирования заметки.
        {
            var sIndex = NoteListBox.SelectedIndex;
            var inner = new Add_Edit_Note();
            inner.Note = Notes.NoteList[sIndex];
            var result = inner.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var upCont = inner.Note;
                NoteListBox.Items.Clear();
                Notes.NoteList.RemoveAt(sIndex);
                Notes.NoteList.Add(upCont);
                foreach (var note in Notes.NoteList)
                {
                    NoteListBox.Items.Add(note.Title);
                }
                ProjectManager.Save(MainForm.Notes);
            }
            
        }
        private void DeleteNote() //Метод удаления заметки.
        {
            var selectedIndex = NoteListBox.SelectedIndex;
            Notes.NoteList.RemoveAt(selectedIndex);
            ProjectManager.Save(Notes);
            NoteListBox.Items.Clear();
            foreach (var note in Notes.NoteList)
            {
                NoteListBox.Items.Add(note.Title);
            }
        }

        private void CreatedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ReadOnlyListView_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
