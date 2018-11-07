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
        NoteForm dlg2 = new NoteForm();
  

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
                dlg.ShowDialog(this);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }
        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Notes.NoteList[NoteListBox.SelectedIndex].Title;
            NoteListBox.SelectedItem = Notes.NoteList[NoteListBox.SelectedIndex].CategoryNote;
            CreatedDateTimePicker.Value = Notes.NoteList[NoteListBox.SelectedIndex].CreationTime;
            ModifiedDateTimePicker.Value = Notes.NoteList[NoteListBox.SelectedIndex].LastChangeTime;
            ReadOnlyListView.Text = Notes.NoteList[NoteListBox.SelectedIndex].TextNote;
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }
        private void AddNote() // Метод добавления заметки.
        {
            var sIndex = NoteListBox.SelectedIndex;
            var addater = new NoteForm();
            addater.Note = null;
            var result = addater.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var upCont = addater.Note;
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
            var inner = new NoteForm();
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

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            DeleteNote();
        }   
    }
}
