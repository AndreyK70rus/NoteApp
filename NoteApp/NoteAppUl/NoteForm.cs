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
        private Note Cont;    
        public Note Note
        {
            get  { return Cont; }
            set
            {
                Cont = value;
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
            dateTimePicker1.Enabled = false;
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
        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
   private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string Text = TitleTextBox.Text;
            if (Text.Length > 50 )
            {
                MessageBox.Show("Длина поля превышает 50 символов","Название заметки",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Cont = new Note();
            Cont.Title = TitleTextBox.Text;
            Cont.CreationTime = dateTimePicker1.Value;
            Cont.LastChangeTime = DateTime.Now;
            if (CategoryComboBox.SelectedItem != null)
            {
                Cont.CategoryNote = (CategoryNote)CategoryComboBox.SelectedItem;
            }
            else
            {
                if(MessageBox.Show("Выберите категорию заметки", "Ошибка", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    CategoryComboBox.BackColor = Color.Red;
                }   
            }           
            string Text = NoteTextBox.Text;
            if (Text.Length > 0)
            {
                Cont.TextNote = NoteTextBox.Text;
            }
            else
            {
                if(MessageBox.Show("Введите текст заметки", "Ошибка", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    NoteTextBox.BackColor = Color.Red;
                }
            }
            DialogResult = DialogResult.OK;
            Close();

        }
        private void Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }

}
