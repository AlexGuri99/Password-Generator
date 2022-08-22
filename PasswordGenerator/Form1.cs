using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        string char1 = "0123456789abcdefghijklmnopqrstuvwxyz";
        string char2 = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string char3 = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ~`!@#$%^&*()_-+={[}]|\\:;'<,>.?/";
        string char4 = "0123456789abcdefghijklmnopqrstuvwxyz~`!@#$%^&*()_-+={[}]|\\:;'<,>.?/";

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string password = "";
            decimal length = UpDown.Value;
            int index;
            Random R = new Random();

            if (!checkBox_Capital.Checked && !checkBox_Symbols.Checked) //Char1 case
            {
                for (int i = 0; i < length; i++)
                {
                    index = R.Next(0, 35);
                    password += char1[index];
                }
            }
            else if (checkBox_Capital.Checked && !checkBox_Symbols.Checked) //Char2 case
            {
                for (int i = 0; i < length; i++)
                {
                    index = R.Next(0, 61);
                    password += char2[index];
                }
            }
            else if (checkBox_Capital.Checked && checkBox_Symbols.Checked) //Char3 case
            {
                for (int i = 0; i < length; i++)
                {
                    index = R.Next(0, 93);
                    password += char3[index];
                }
            }
            else if (!checkBox_Capital.Checked && checkBox_Symbols.Checked) //Char4 case
            {
                for (int i = 0; i < length; i++)
                {
                    index = R.Next(0, 67);
                    password += char4[index];
                }
            }
            password += '\0';
            txt_ResultPassword.Text = password;
            password = "";
        }

        private void txt_Length_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
