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
    public partial class MiddleManager : KryptonForm
    {
        Controller controllerObj;
        public MiddleManager()
        {

            InitializeComponent();
        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectEmpId();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string text = dt.Rows[i]["Employee_ID"].ToString();
                this.ComboBox1.Items.Add(text);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex == -1 || TextBox1.Text == "" || ComboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int ID = Int32.Parse(ComboBox1.Text);
                string c = ComboBox2.Text;
                int r = controllerObj.UpdateMManager(ID, Int32.Parse(TextBox1.Text.ToString()), c);
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
    }
}
