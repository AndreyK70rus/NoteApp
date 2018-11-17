using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteAppUl;
using System.Diagnostics;

namespace NoteAppUl
{
    public partial class AboutMe : Form
    {
        public AboutMe()
        {
            InitializeComponent();
        }

        // Кнопка элемента управления LinkLabel1.
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // При нажатии на кнопку срабатывает ссылка на открытие репозитория расположенного на GitHub.
            Process.Start("https://github.com/AndreyK70rus/NoteApp");
        }
    }
}
