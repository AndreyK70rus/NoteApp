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
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Поле Cont с типом данных Note и модификатором доступа private.
        /// </summary>
        private Note Cont;  
        
        /// <summary>
        /// Свойство для поля Note, которое возвращает значение в поле Cont.
        /// </summary>
        public Note Note
        {
            get  { return Cont; }
            set
            {
                Cont = value;
                // Условие при которм если поля заполнены, то их значения присваиваются в поля формы NoteForm. 
                if (Cont != null)
                {
                    TitleTextBox.Text = Cont.Title;
                    CategoryComboBox.SelectedItem = Cont.CategoryNote;
                    dateTimePicker1.Value = Cont.CreationTime;
                    dateTimePicker2.Value = Cont.LastChangeTime;
                    NoteTextBox.Text = Cont.TextNote;
                }
                else
                {
                    TitleTextBox.Text = "Без названия";
                    CategoryComboBox.SelectedItem = "";
                    dateTimePicker1.Value = DateTime.Today;
                    dateTimePicker2.Value = DateTime.Today;
                    NoteTextBox.Text = "";
                }
            }
            }

        public NoteForm()
        {
            InitializeComponent();
            // Отключает возможность выбора даты, только просмотр.
            dateTimePicker1.Enabled = false;
            // Отключает возможность выбора даты, только просмотр.
            dateTimePicker2.Enabled = false;
            CategoryComboBox.Items.Add(CategoryNote.All);
            CategoryComboBox.Items.Add(CategoryNote.Work);
            CategoryComboBox.Items.Add(CategoryNote.House);
            CategoryComboBox.Items.Add(CategoryNote.Heath_and_sport);
            CategoryComboBox.Items.Add(CategoryNote.People);
            CategoryComboBox.Items.Add(CategoryNote.Documents);
            CategoryComboBox.Items.Add(CategoryNote.Finance);
            CategoryComboBox.Items.Add(CategoryNote.Another);
        }

        // Кнопка элемента управления Button.
        private void Button2_Click(object sender, EventArgs e)
        {
            // При нажатии на кнопку окно NoteForm закрывается.
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Кнопка элемента управления TextBox.
   private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string Text = TitleTextBox.Text;
            // Условие для проверки длины поля.
            if (Text.Length > 50)
            {
                // MessageBox указывающий на неккоректность ввода данных в TextBox.
                MessageBox.Show("Длина поля превышает 50 символов", "Название заметки",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        // Кнопка элемента управления Button.
        private void Button1_Click(object sender, EventArgs e)
        {
            Cont = new Note();
            Cont.Title = TitleTextBox.Text;
            Cont.CreationTime = dateTimePicker1.Value;
            Cont.LastChangeTime = DateTime.Now;
            string Text = NoteTextBox.Text;
            // Условие при котором если поля CategoryComboBox и NoteTextBox заполнены, то происходит сохранение полей и закрытие формы.
            if (CategoryComboBox.SelectedItem != null && Text.Length > 0)
            {
                Cont.CategoryNote = (CategoryNote)CategoryComboBox.SelectedItem;
                Cont.TextNote = NoteTextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            }

            // Условие при котором CategoryComboBox не заполнен.
            if (CategoryComboBox.SelectedItem == null)
            {
                // MessageBox указывает на некорректность ввода в CategoryComboBox.
                MessageBox.Show("Выберите категорию заметки", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                CategoryComboBox.BackColor = Color.LightSalmon;
            }

            // Условие при котором NoteTextBox не заполнен.
            if (Text.Length < 1)
            {
                // MessageBox указывает на некорректность ввода в NoteTextBox.
                MessageBox.Show("Введите текст заметки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NoteTextBox.BackColor = Color.LightSalmon;
            }

        }

        // Кнопка элемента управления Button.
        private void Button_Click(object sender, EventArgs e)
        {
            // При нажатии на кнопку окно формы NoteForm.
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }

}
