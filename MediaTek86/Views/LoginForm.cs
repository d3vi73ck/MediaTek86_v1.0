using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86.Controller;
namespace MediaTek86.Views
{
    public partial class LoginForm : Form
    {
        private readonly MainController mainController1;
        public LoginForm(MainController mainController)
        {
            this.mainController1 = mainController;
            InitializeComponent();
        }
        public string Login { get; set; }
        public string password { get; set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrEmpty(txtboxLogin.Text) && ! string.IsNullOrEmpty(txtboxPassword.Text))
            {
                this.Login = txtboxLogin.Text;
                this.password = txtboxPassword.Text;
                var res = this.mainController1.Connect(this.Login, this.password);
                if ( !res )
                {
                    MessageBox.Show("Login failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
