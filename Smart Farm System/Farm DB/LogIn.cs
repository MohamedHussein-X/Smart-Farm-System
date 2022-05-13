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
    public partial class LogIn : KryptonForm
    {
        Controller controllerObj;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (IDText.Text == "" || PText.Text ==""||ComboBox1.SelectedIndex==-1 )
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                string sel = ComboBox1.Text;
                DataTable dt = controllerObj.LogIn(Int32.Parse(IDText.Text.ToString()), Int32.Parse(PText.Text.ToString()));
                string r;
                if (dt == null)
                    r = "";
                else
                 r = dt.Rows[0][0].ToString();
               // DataTable r = controllerObj.LogIn(Int32.Parse(IDText.Text.ToString()), Int32.Parse(PText.Text.ToString()));
                
                // string x = r.ToString();
                if (r == "")
                { 
                    MessageBox.Show("Invalid Login");
                }
                else if(r.ToString() == sel)
                {
                    MessageBox.Show(r);
                    MessageBox.Show("Log in succussfully!");
                    if (sel == "M.Engineer")
                    {
                        MainMEng F = new MainMEng(Int32.Parse(IDText.Text.ToString()));
                        F.Show();
                    }
                    else if(sel== "A.Engineer")
                    {
                        A_EngMain F = new A_EngMain(Int32.Parse(IDText.Text.ToString()));
                        F.Show();
                    }
                    else if (sel == "Vet")
                    {
                        Vet_Main F = new Vet_Main(Int32.Parse(IDText.Text.ToString()));
                        F.Show();

                    }
                    else if (sel == "M.Manager")
                    {
                        MainMMang F = new MainMMang(Int32.Parse(IDText.Text.ToString()));
                        F.Show();
                    }
                    else if (sel == "F.Manager")
                    {
                        F_ManMain F = new F_ManMain(Int32.Parse(IDText.Text.ToString()));
                        F.Show();
                    }

                }
            }
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SignUp F = new SignUp();
            F.Show();
        }

        private void PText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            ChangePass f = new ChangePass();
            f.Show();
        }
    }
 }

