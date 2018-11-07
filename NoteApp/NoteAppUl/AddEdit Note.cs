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
        public Note Cont;
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
                    Add_EditTextBox.Text = Cont.TextNote;
                }
                else
                {
                    TitleTextBox.Text = "";
                    CategoryComboBox.Text = "";
                    dateTimePicker1.Value = DateTime.Today;
                    dateTimePicker2.Value = DateTime.Today;
                    Add_EditTextBox.Text = "";
                }
            }
            }
        public NoteForm()
        {
            InitializeComponent();
            dateTimePicker1.Enabled = false;
            this.dateTimePicker2.Enabled = false;
            dateTimePicker1.Text = DateTime.Today.ToShortDateString();
            dateTimePicker2.Text = DateTime.Today.ToShortDateString();
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
                    MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.OK;
            Close();
        }

       

        private void Add_EditTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = Add_EditTextBox.Text;           
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
