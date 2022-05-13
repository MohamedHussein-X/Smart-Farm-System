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
    public partial class A_EngMain : KryptonForm
    {
        int ID;
        Controller controllerObj;
        public A_EngMain(int id)
        {
            ID = id;
            InitializeComponent();
        }

        private void A_EngMain_Load(object sender, EventArgs e)
        {
            Controller controllerObj;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A_Engineer F = new A_Engineer();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile f = new Profile(ID);
            f.Show();
        }
    }
}
