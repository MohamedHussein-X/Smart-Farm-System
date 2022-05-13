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
    public partial class SignUp : KryptonForm
    {
        Controller controllerObj;
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (NText.Text == "" || WText.Text == "" || AdText.Text == "" || IDText.Text == "" || !(r1.Checked || r2.Checked))
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                string c = "M";
                if (r2.Checked)
                    c = "F";
                int r = controllerObj.InsertEmp(Int32.Parse(IDText.Text.ToString()), NText.Text.ToString(), AdText.Text.ToString()
                    , c, Date.Value.ToString(), WText.Text.ToString());
                if (r == 0)
                {

                    MessageBox.Show("Sign Up failed");
                }
                else
                {
                    int L = controllerObj.SignUp(Int32.Parse(IDText.Text.ToString()), Int32.Parse(PText.Text.ToString()), WText.Text.ToString());
                    if(L==0)
                        MessageBox.Show("The insertion failed");
                    else
                    MessageBox.Show("SignUp done!");
                }
            }
        }
    }
}
