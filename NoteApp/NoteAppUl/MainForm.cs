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
        // Создаем экземпяр класса Project.
        Project Project = new Project();
        Project ProjectCurrentNote = new Project();

        public MainForm()
        {
            InitializeComponent();
            // Кнопка для удаления заметки по нажатию клавиши Delete.
            NoteListBox.KeyDown += new KeyEventHandler(NoteListBox_Keys);
            // Создаем экземпяр класса ProjectManager.
            Project = ProjectManager.Load(Project,ProjectManager.FilePath);
            Project.NotesCollection = Project.SortedNotesCollection();
            ListViewNote = Project.NotesCollection;
            // Выгружаем все заметки из массива и добавляем в листбокс название.
            foreach (var note in ListViewNote)
            {               
                NoteListBox.Items.Add(note.Title);
            }
            // Добавляем в элемент управления ComboBox перечисление. Категория заметки - Все.
            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                CategoryComboBox.Items.Add(category);
            }
            ProjectCurrentNote = ProjectManager.Load(ProjectCurrentNote, ProjectManager.FilePath);
            NoteListBox.SelectedItem = ProjectCurrentNote.CurrentNote.Title;
            textBox1.Text = ProjectCurrentNote.CurrentNote.Title;
            CategoryTextBox.Text = ProjectCurrentNote.CurrentNote.CategoryNote.ToString();
            CreatedDateTimePicker.Value = ProjectCurrentNote.CurrentNote.CreationTime;
            ModifiedDateTimePicker.Value = ProjectCurrentNote.CurrentNote.LastChangeTime;
            RichTextBox.Text = ProjectCurrentNote.CurrentNote.TextNote;
        }

        /// <summary>
        /// Поле для хранения отсортированного списка по категориям, внутри программы.
        /// </summary>
        private List<Note> ListViewNote;
        
        // Кнопка элемента управления ListBox.
        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NoteListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                ProjectCurrentNote.CurrentNote.Title = Project.NotesCollection[NoteListBox.SelectedIndex].Title;
                ProjectCurrentNote.CurrentNote.CategoryNote = Project.NotesCollection[NoteListBox.SelectedIndex].CategoryNote;
                ProjectCurrentNote.CurrentNote.TextNote = Project.NotesCollection[NoteListBox.SelectedIndex].TextNote;
                ProjectCurrentNote.CurrentNote.CreationTime = Project.NotesCollection[NoteListBox.SelectedIndex].CreationTime;
                ProjectCurrentNote.CurrentNote.LastChangeTime = Project.NotesCollection[NoteListBox.SelectedIndex].LastChangeTime;
                ProjectManager.Save(ProjectCurrentNote, ProjectManager.FilePath);
                ProjectManager.Save(Project, ProjectManager.FilePath);
                // При выборе заметки из листбокса всем полям правой панели присваиваются значения выбранной заметки.
                textBox1.Text = ListViewNote[NoteListBox.SelectedIndex].Title;
                CategoryTextBox.Text = ListViewNote[NoteListBox.SelectedIndex].CategoryNote.ToString();
                CreatedDateTimePicker.Value = ListViewNote[NoteListBox.SelectedIndex].CreationTime;
                ModifiedDateTimePicker.Value = ListViewNote[NoteListBox.SelectedIndex].LastChangeTime;
                RichTextBox.Text = ListViewNote[NoteListBox.SelectedIndex].TextNote;
            }
        }

        /// <summary>
        /// Метод добавления новой заметки.
        /// </summary>
        private void AddNote() 
        {
            var sIndex = NoteListBox.SelectedIndex;
            var addater = new NoteForm();
            addater.Note = null;
            var result = addater.ShowDialog();
            if (result == DialogResult.OK)
            {
                var upNote = addater.Note;
                NoteListBox.Items.Clear();
                Project.NotesCollection.Add(upNote);
                ListViewNote = Project.SortedNotesCollection();
                Project.NotesCollection = Project.SortedNotesCollection();
                foreach (var note in Project.NotesCollection)
                {
                   NoteListBox.Items.Add(note.Title);
                }
                ProjectManager.Save(Project, ProjectManager.FilePath);
            }
        }

        /// <summary>
        /// Метод редактирования выбранной заметки.
        /// </summary>
        private void EditNote() 
        {
            if (NoteListBox.SelectedIndex != -1)
            {
                var sIndex = NoteListBox.SelectedIndex;
                var inner = new NoteForm();
                inner.Note = Project.NotesCollection[sIndex];
                var result = inner.ShowDialog(this);
                if (result == DialogResult.OK)
                {               
                    var upNote = inner.Note;
                    NoteListBox.Items.Clear();
                    Project.NotesCollection.RemoveAt(sIndex);
                    Project.NotesCollection.Add(upNote);
                    ListViewNote = Project.SortedNotesCollection();
                    Project.NotesCollection = Project.SortedNotesCollection();
                    foreach (var note in Project.NotesCollection)
                    {
                        NoteListBox.Items.Add(note.Title);
                    }
                    ProjectManager.Save(Project, ProjectManager.FilePath);
                    // Присваиваем в элементы управления правой части формы, значения редактированной заметки, для отображения.
                    textBox1.Text = upNote.Title;
                    CategoryTextBox.Text = upNote.CategoryNote.ToString();
                    CreatedDateTimePicker.Value = upNote.CreationTime;
                    ModifiedDateTimePicker.Value = upNote.LastChangeTime;
                    RichTextBox.Text = upNote.TextNote;
                }
            } 
        }

        /// <summary>
        /// Метода для удаления выбранной заметки.
        /// </summary>
        private void DeleteNote() 
        {
            if (NoteListBox.SelectedIndex != -1)
            {

                // Условие в котором выскакивает MessegeBox, целью подтверждения удаления заметки.
                if (MessageBox.Show("Do you really want to remove this note: " + Project.NotesCollection[NoteListBox.SelectedIndex].Title,
                  "DeleteNote", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    var selectedIndex = NoteListBox.SelectedIndex;
                    Project.NotesCollection.RemoveAt(selectedIndex);
                    // После удаления заметки, сразу производим сериализацию.
                    ProjectManager.Save(Project, ProjectManager.FilePath);
                    NoteListBox.Items.Clear();
                    foreach (var note in Project.NotesCollection)
                    {
                        NoteListBox.Items.Add(note.Title);
                    }
                    // После удаления заметки, все поля правой части формы устанавливаем в начальное состояние.
                    textBox1.Text = "";
                    CategoryTextBox.Text = "";
                    DateTime date1 = new DateTime(2018, 9, 1);
                    DateTime date2 = new DateTime(2018, 9, 1);
                    CreatedDateTimePicker.Value = date1;
                    ModifiedDateTimePicker.Value = date2;
                    RichTextBox.Text = "";
                }
            }         
        }

        /// <summary>
        /// Метод для сортировки заметок по категориям.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Category = CategoryComboBox.SelectedItem;
            ListViewNote = Project.SortedNotesCollection((NoteCategory)Category);
            NoteListBox.Items.Clear();
            foreach (var category in ListViewNote)
            {
                NoteListBox.Items.Add(category.Title);
            }
            if (CategoryComboBox.SelectedIndex == 0)
            {
                ListViewNote = Project.NotesCollection;
                NoteListBox.Items.Clear();
                foreach (var category in ListViewNote)
                {
                    NoteListBox.Items.Add(category.Title);
                }
            }
        }
            /// <summary>
            /// Метод удаления выбранной заметки, при нажатии клавиши Delete.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void NoteListBox_Keys(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    DeleteNote();
                    e.Handled = true;
                }
            }

            // Кнопка элемента управления Button в виде иконки добавления новой заметки.
            private void AddButton_Click(object sender, EventArgs e)
            {
                // При нажатии на кнопку запускается метод добавления заметки.
                AddNote();
            }

            // Кнопка элемента управления Button в виде иконки редактирования заметки.
            private void EditButton_Click(object sender, EventArgs e)
            {
                // При нажатии на кнопку запускается метод редактирования заметки.
                EditNote();
            }

            // Кнопка элемента управления Button в виде иконки удаления заметки.
            private void DeleteButton_Click(object sender, EventArgs e)
            {
                DeleteNote();
            }

            // Кнопка из элемента управления menuStrip1, File, Exit. 
            private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                // При нажатии кнопки приложение полностью завершает свою работу.
                Application.Exit();
            }

            // Кнопка из элемента управления menuStrip1, Edit, Add Note.
            private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
            {
                // При нажатии на кнопку запускается метод добавления заметки.
                AddNote();
            }

            // Кнопка из элемента управления menuStrip1, Edit, Edit Note.
            private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
            {
                // При нажатии на кнопку запускается метод редактирования заметки.
                EditNote();
            }

            // Кнопка из элемента управления menuStrip1, Edit, Remove Note.
            private void RemoveNoteToolStripMenuItem_Click(object sender, EventArgs e)
            {
                // При нажатии на кнопку запускается метод удаления заметки.
                DeleteNote();
            }

            // Кнопка из элемента управления menuStrip1, Help, About.
            private void AboutToolStripMenuItem_Click_1(object sender, EventArgs e)
            {
                // Создаем экземпляр формы AboutForm.
                AboutForm Form = new AboutForm();
                // При нажатии на кнопку запускается форма AboutMe.
                Form.ShowDialog(this);
            }
        
    }
}
