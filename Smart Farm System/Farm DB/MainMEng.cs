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
    public partial class MainMEng : KryptonForm
    {
        int ID;
        Controller controllerObj;
        public MainMEng(int id)
        {
            ID = id;
            InitializeComponent();
        }

        private void MainMEng_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mechanical_Engineer F = new Mechanical_Engineer();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile f = new Profile(ID);
            f.Show();
        }
    }
}
