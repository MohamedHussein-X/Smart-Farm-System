using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_DB
{
    public partial class Wherehouse_Supervisor : Form
    {
        Controller controllerobj = new Controller();
        public Wherehouse_Supervisor()
        {
            InitializeComponent();
            DataTable dt1 = controllerobj.SelectAllIDS();
            DataTable dt2 = controllerobj.SelectAllTypes();
            comboBox1.DataSource = dt1;
            comboBox2.DataSource = dt2;
            comboBox1.DisplayMember = "Product_ID";
            comboBox2.DisplayMember = "Product_Type";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt9 = controllerobj.getweeklyExports(Convert.ToDateTime(dateTimePicker1.Text));
            dataGridView2.DataSource = dt9;
            dataGridView2.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt9 = controllerobj.getmonthlyExports(Convert.ToDateTime(dateTimePicker1.Text));
            dataGridView2.DataSource = dt9;
            dataGridView2.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt9 = controllerobj.getyearlyexports(Convert.ToDateTime(dateTimePicker1.Text));
            dataGridView2.DataSource = dt9;
            dataGridView2.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt9 = controllerobj.getweeklyvet(Convert.ToDateTime(dateTimePicker1.Text));
            dataGridView2.DataSource = dt9;
            dataGridView2.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt9 = controllerobj.getmonthlyvet(Convert.ToDateTime(dateTimePicker1.Text));
            dataGridView2.DataSource = dt9;
            dataGridView2.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt9 = controllerobj.getyearlyvet(Convert.ToDateTime(dateTimePicker1.Text));
            dataGridView2.DataSource = dt9;
            dataGridView2.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dt9 = controllerobj.getweeklyAgriculture(Convert.ToDateTime(dateTimePicker1.Text));
            dataGridView2.DataSource = dt9;
            dataGridView2.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataTable dt9 = controllerobj.getmonthlyAgriculture(Convert.ToDateTime(dateTimePicker1.Text));
            dataGridView2.DataSource = dt9;
            dataGridView2.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataTable dt9 = controllerobj.getyearlyAgriculture(Convert.ToDateTime(dateTimePicker1.Text));
            dataGridView2.DataSource = dt9;
            dataGridView2.Refresh();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Product_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            if (textBox1.Text == "" || Int32.TryParse(ID.Text, out x) || ID.Text == "" || Int32.TryParse(Product.Text, out y))
                MessageBox.Show("invalid entry renter a valid value");
            else
            {
                x = controllerobj.createinfo(Convert.ToDateTime(dateTimePicker1.Text), Int32.Parse(ID.Text), Product.Text, Int32.Parse(textBox1.Text));
                if (x == 0) { MessageBox.Show("unsuccessfull attempt"); }
                else { MessageBox.Show("succefull Attempt"); }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DataTable dt9 = controllerobj.geteverything();
            dataGridView2.DataSource = dt9;
            dataGridView2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            if (textBox1.Text == "" || Int32.TryParse(comboBox2.Text, out x) || Int32.TryParse(textBox1.Text, out y))
                MessageBox.Show("invalid entry renter a valid value");
            else
            {
                x = controllerobj.changeinfo(Convert.ToDateTime(dateTimePicker1.Text), Int32.Parse(comboBox1.Text), comboBox2.Text, Int32.Parse(textBox1.Text));
                if (x == 0) { MessageBox.Show("unsuccessfull attempt"); }
                else { MessageBox.Show("succefull Attempt"); }
            }
        }

        private void Wherehouse_Supervisor_Load(object sender, EventArgs e)
        {

        }
    }
}
