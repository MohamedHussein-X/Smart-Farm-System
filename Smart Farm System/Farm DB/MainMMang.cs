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
    public partial class MainMMang : KryptonForm
    {
        int ID;
        Controller controllerObj;
        public MainMMang(int id)
        {
            ID = id;
            InitializeComponent();
        }

        private void MainMMang_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MiddleManager F = new MiddleManager();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile f = new Profile(ID);
            f.Show();
        }
    }
}
