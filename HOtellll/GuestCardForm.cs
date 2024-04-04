using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HOtellll
{
    public partial class GuestCardForm : Form
    {
        private string placeholderText = "ФИО";
        private string placeholderText2 = "Дата рождения";
        public GuestCardForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void salaryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            salaryComboBox.Text ="Оплата";
        }

        private void fioTextbox_MouseEnter(object sender, EventArgs e)
        {
            if (fioTextbox.Text == placeholderText)
            {
                fioTextbox.Text = "";
                fioTextbox.ForeColor = Color.Black;
            }
        }

        private void fioTextbox_MouseLeave(object sender, EventArgs e)
        {
            if (fioTextbox.Text == "")
            {
                fioTextbox.Text = placeholderText;
                fioTextbox.ForeColor = Color.SteelBlue;
            }
        }      
        private void dataTextBox_MouseEnter(object sender, EventArgs e)
        {
            if(dataTextBox.Text == placeholderText)
            {
                dataTextBox.Text = placeholderText2;
                dataTextBox.ForeColor = Color.Black;
            }
        }

        private void dataTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (dataTextBox.Text == "")
            {
                dataTextBox.Text = placeholderText2;
                dataTextBox.ForeColor = Color.SteelBlue;
            }
        }
    }
}
