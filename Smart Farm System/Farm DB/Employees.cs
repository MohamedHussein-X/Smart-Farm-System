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
    public partial class Employees : KryptonForm
    {
        Controller controllerObj;
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectEmp_Id();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string text = dt.Rows[i]["ID"].ToString();
                this.ComboBox1.Items.Add(text);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if ( NText.Text == "" || WText.Text == ""|| AdText.Text==""||IDText.Text==""||!(r1.Checked||r2.Checked))
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
                    MessageBox.Show("The insertion failed");
                }
                else
                {
                    MessageBox.Show("The insertion done!");
                }
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please, insert employee id");
            }
            else
            {
                int r = controllerObj.DeleteEmp(Int32.Parse(ComboBox1.Text));
                if (r == 0)
                {
                    MessageBox.Show("Removal failed");
                }
                else
                {
                    MessageBox.Show("Removed successfully!");
                }
            }
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllEmp();
            DataGridView1.DataSource = dt;
            DataGridView1.Refresh();
        }
    }
}
