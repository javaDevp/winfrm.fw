using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFrm.Framework.Common;
using WinFrm.Framework.Service;

namespace WinFrm.Framework.UI
{
    public partial class LoginFrm : Form
    {
        private UserService service = new UserService();

        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                doLogin();
            }
            else
            {
                MessageBox.Show("账号密码不能为空");
            }
        }

        private bool ValidateControls()
        {
            return ValidateUtil.Validate(txtAccount) && ValidateUtil.Validate(txtPwd);
        }

        private void doLogin()
        {
            var user = service.GetAllUsers().Where(u => u.UserName == txtAccount.Text && u.Password == txtPwd.Text).FirstOrDefault();
            if (user != null)
            {

            } else
            {
                MessageBox.Show("账号或密码错误");
            }
        }
    }
}
