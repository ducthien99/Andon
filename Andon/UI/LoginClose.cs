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
        private const string USENAME = "Admin";
        private const string PASSWORD = "444444";
        public bool _LoginSuccess = false;
        private bool _CallFromThisForm;
        public LoginClose(bool thisForm = true)
        {
            InitializeComponent();
            TextboxPass.isPassword = true;
            _CallFromThisForm = thisForm;
        }
        private void Login()
        {
            if (TextboxUser.Text.Length == 0 && TextboxPass.Text.Length == 0)
            {
                ShowMessage("Please enter your username and password!");

            } else if(TextboxUser.Text.Length == 0)
            {
                ShowMessage("Please enter your username!");

            }else if(TextboxPass.Text.Length == 0)
            {
                ShowMessage("Please enter your password!");

            }else if((TextboxUser.Text == USENAME) && (TextboxPass.Text == PASSWORD))
            {
                if(_CallFromThisForm)
                    Application.Exit();
                else
                {
                    _LoginSuccess = true;
                    this.Close();
                }
            }
            else
            {
                ShowMessage("Incorrect usename or password.Please again!");
            }
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(
                    message,
                    "Login", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
