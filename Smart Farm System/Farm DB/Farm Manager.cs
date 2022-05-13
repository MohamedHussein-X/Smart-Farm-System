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
    public partial class Farm_Manager : KryptonForm
    {
        Controller controllerObj;
        public Farm_Manager()
        {
            InitializeComponent();
        }

        private void Farm_Manager_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            DataTable dt = controllerObj.SelectAsId();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string text = dt.Rows[i]["Asset_ID"].ToString();
                this.ComboBox1.Items.Add(text);
                this.ComboBox2.Items.Add(text);

            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if ( AsID.Text == "" || AsP.Text == ""|| AsQa.Text==""||AsTy.Text=="")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {

                int r = controllerObj.InsertAssist(DateTimePicker1.Value.ToString(), Int32.Parse(AsID.Text.ToString()), AsTy.Text.ToString(),
                    Int32.Parse(AsQa.Text.ToString()), Int32.Parse(AsP.Text.ToString()));
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

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (Ptext.Text == "" || Qtext.Text == "" )
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int ID = Int32.Parse(ComboBox1.Text);
                int r = controllerObj.UpdateAssist(ID, Int32.Parse(Ptext.Text.ToString()), Int32.Parse(Qtext.Text.ToString()));
                if (r == 0)
                {
                    MessageBox.Show("The update failed");
                }
                else
                {
                    MessageBox.Show("The update done!");
                }
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            if (ComboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please, insert assist id");
            }
            else
            {
                int r = controllerObj.DeleteAssist(Int32.Parse(ComboBox2.Text));
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
            DataTable dt = controllerObj.SelectAllAssits();
            DataGridView1.DataSource = dt;
            DataGridView1.Refresh();
        }
    }
    }

