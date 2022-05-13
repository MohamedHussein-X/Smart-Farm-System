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
    public partial class F_ManMain : KryptonForm
    {
        int ID;
        Controller controllerObj;
        public F_ManMain(int id)
        {
            ID = id;
            InitializeComponent();
        }

        private void F_ManMain_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Farm_Manager F = new Farm_Manager();
            F.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Traders F = new Traders();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile f = new Profile(ID);
            f.Show();
        }
    }
}
