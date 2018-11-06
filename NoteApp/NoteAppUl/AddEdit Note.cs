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
    public partial class Add_Edit_Note : Form
    {
       
        Project _Save = new Project();
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
        public Add_Edit_Note()
        {

            
            

            InitializeComponent();
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
      

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Hide();          
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
           
          
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Form3BindingSource_CurrentChanged(object sender, EventArgs e)
        {

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
            ProjectManager.Save(_Save);
            DialogResult = DialogResult.OK;
            Close();
        }

       

        private void Add_EditTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = Add_EditTextBox.Text;           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
