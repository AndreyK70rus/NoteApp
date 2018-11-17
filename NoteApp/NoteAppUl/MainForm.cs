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
        public static Project Notes = new Project();

        public MainForm()
        {
            InitializeComponent();
            // Создаем экземпяр класса ProjectManager.
            Notes = ProjectManager.Download();
            // Выгружаем все заметки из массива и добавляем в листбокс название.
            foreach (var note in Notes.NoteList)
            {
                NoteListBox.Items.Add(note.Title);
            }
            // Добавляем в элемент управления ComboBox перечисление. Категория заметки - Все.
            CategoryComboBox.Items.Add(CategoryNote.All);
            // Категория заметки - Работа.
            CategoryComboBox.Items.Add(CategoryNote.Work);
            // Категория заметки - Дом.
            CategoryComboBox.Items.Add(CategoryNote.House);
            // Категория заметки - Здоровье и спорт.
            CategoryComboBox.Items.Add(CategoryNote.Heath_and_sport);
            // Категория заметки - Люди.
            CategoryComboBox.Items.Add(CategoryNote.People);
            // Категория заметки - Документы.
            CategoryComboBox.Items.Add(CategoryNote.Documents);
            // Категория заметки - Финансы.
            CategoryComboBox.Items.Add(CategoryNote.Finance);
            // Категория заметки - Другое.
            CategoryComboBox.Items.Add(CategoryNote.Another);             
        }

        // Создаем экземпляр формы AboutMe.
        AboutMe dlg = new AboutMe();

        // Кнопка элемента управления ListBox.
        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // В том случае, если пользователь случайно нажмет на свободное место в листбоксе,
            // а не на конкретную заметку, ничего не произойдет.
            if (NoteListBox.SelectedIndex != -1)
            {
                // При выборе заметки из листбокса всем полям правой панели присваиваются значения выбранной заметки.
                textBox1.Text = Notes.NoteList[NoteListBox.SelectedIndex].Title;
                CategoryTextBox.Text = Notes.NoteList[NoteListBox.SelectedIndex].CategoryNote.ToString();
                CreatedDateTimePicker.Value = Notes.NoteList[NoteListBox.SelectedIndex].CreationTime;
                ModifiedDateTimePicker.Value = Notes.NoteList[NoteListBox.SelectedIndex].LastChangeTime;
                RichTextBox.Text = Notes.NoteList[NoteListBox.SelectedIndex].TextNote;
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
            // При нажатии на кнопку запускается форма AboutMe.
            dlg.ShowDialog(this);
        }

        // Метод добавления заметки.
        private void AddNote() 
        {
            // Вытягиваем индекс из NotelistBox.
            var sIndex = NoteListBox.SelectedIndex;
            // Создаем экземпляр формы NoteForm.
            var addater = new NoteForm();
            // в свойство Note из формы NoteForm присваиваем значение null.
            addater.Note = null;
            // В переменную result добавляем действие для открытия формы NoteForm.
            var result = addater.ShowDialog();
            // Условие, если в форме NoteForm будет ножата кнопка OK.
            if (result == DialogResult.OK)
            {         
                // в переменную upCont поместятся значения полей формы NoteForm.
                var upCont = addater.Note;
                // Удаление предыдущих значений из NoteListBox.
                NoteListBox.Items.Clear();
                // Добавление значения полей в массив заметок.
                Notes.NoteList.Add(upCont);
                // Цикл который добавляет в массив заметок заметку.
                foreach (var note in Notes.NoteList)
                {
                    // Добавляем в NoteListBox название добавленной заметки.
                    NoteListBox.Items.Add(note.Title);
                }
                // Сериализация.
                ProjectManager.Save(Notes);
            }            
        }

        // Метод редактирования заметки.
        private void EditNote() 
        {
            // Условие для того, чтобы при нажатии на NoteListBox программа не завершалась аварийно.
            if (NoteListBox.SelectedIndex != -1)
            {
                var sIndex = NoteListBox.SelectedIndex;
                var inner = new NoteForm();
                // Вытягиваем индекс выбранной заметки из массива заметок.
                inner.Note = Notes.NoteList[sIndex];
                var result = inner.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    // В переменную upCont помещаем новые значения полей.
                    var upCont = inner.Note;
                    NoteListBox.Items.Clear();
                    // Удаляем выбранную заметку по индексу.
                    Notes.NoteList.RemoveAt(sIndex);
                    // Добавляем новую заметку с измененными данными.
                    Notes.NoteList.Add(upCont);
                    foreach (var note in Notes.NoteList)
                    {
                        NoteListBox.Items.Add(note.Title);
                    }
                    // Сериализация
                    ProjectManager.Save(MainForm.Notes);
                    // Присваиваем в элементы управления правой части формы, значения редактированной заметки, для отображения.
                    textBox1.Text = upCont.Title;
                    CategoryTextBox.Text = upCont.CategoryNote.ToString();
                    CreatedDateTimePicker.Value = upCont.CreationTime;
                    ModifiedDateTimePicker.Value = upCont.LastChangeTime;
                    RichTextBox.Text = upCont.TextNote;
                }
            }
        }

        //Метод удаления заметки.
        private void DeleteNote() 
        {
            if (NoteListBox.SelectedIndex != -1)
            {
                // Условие в котором выскакивает MessegeBox, целью подтверждения удаления заметки.
                if (MessageBox.Show("Do you really want to remove this note: " + Notes.NoteList[NoteListBox.SelectedIndex].Title,
                  "DeleteNote", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    var selectedIndex = NoteListBox.SelectedIndex;
                    Notes.NoteList.RemoveAt(selectedIndex);
                    // После удаления заметки, сразу производим сериализацию.
                    ProjectManager.Save(Notes);
                    NoteListBox.Items.Clear();
                    foreach (var note in Notes.NoteList)
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

    }
}
