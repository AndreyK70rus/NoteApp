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
    public partial class Form3 : Form
    {

        Note creation = new Note(DateTime.Today); 
              
        public Form3()
        {
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(creation);
        }
    }

}
