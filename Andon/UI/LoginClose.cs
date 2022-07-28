using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Andon.ControlApp;
namespace Andon.UI
{
    public partial class LoginClose : Form
    {
       
        public LoginClose()
        {
            InitializeComponent();
            TextboxPass.isPassword = true;
        }
        void Password()
        {
            string password = "444444";
            if (TextboxUser.Text.Length == 0 && TextboxPass.Text.Length == 0)
            {
                MessageBox.Show("Please enter your username and password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (TextboxUser.Text.Length == 0)
                {
                    MessageBox.Show("Please enter your username!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (TextboxPass.Text.Length == 0)
                    {
                        MessageBox.Show("Please enter your password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        if ((TextboxUser.Text == "Admin") && (TextboxPass.Text == password))
                        {

                            Control.plc.SetDevice("M5", 1);
                            Control.plc.SetDevice("M5", 0);
                            Application.Exit();
                          
                        }
                        else
                        {
                            if (TextboxUser.Text != "Admin")
                            {
                                MessageBox.Show("User entered is incorrect.Please again!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            }
                            if (TextboxPass.Text != password)
                            {
                                MessageBox.Show("Password entered is incorrect.Please again!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            }
                        }
                    }
                }
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Password();
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            TextboxPass.isPassword = true;
        }

        private void CheckBoxShowPass_OnChange(object sender, EventArgs e)
        {
            if (CheckBoxShowPass.Checked)
            {
                //IsCheck = true;
                TextboxPass.isPassword = false;
            }
            else
            {
                //IsCheck = false;
                TextboxPass.isPassword = true;
            }
        }
    }
}
