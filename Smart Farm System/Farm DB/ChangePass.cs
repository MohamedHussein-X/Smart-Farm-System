using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Farm_DB
{
    public partial class ChangePass : KryptonForm
    {
        Controller controllerObj;
        public ChangePass()
        {
            InitializeComponent();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (IDText.Text == "" || PText.Text == "" || NPText.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                DataTable dt = controllerObj.LogIn(Int32.Parse(IDText.Text.ToString()), Int32.Parse(PText.Text.ToString()));
                if (dt == null)
                    MessageBox.Show("Invalid input");
                else
                {
                    int r = controllerObj.UpdatePassWord(Int32.Parse(IDText.Text.ToString()), Int32.Parse(NPText.Text.ToString()));
                    if (r == 0)
                        MessageBox.Show("Password Update failed");
                    else
                        MessageBox.Show("Password Updated");
                }
            }
        }
    }
}
