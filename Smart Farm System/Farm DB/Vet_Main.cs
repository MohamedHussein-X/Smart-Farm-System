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
    public partial class Vet_Main : KryptonForm
    {
        int ID;
        Controller controllerObj;
        public Vet_Main(int id)
        {

            InitializeComponent();
            ID = id;
        }

        private void Vet_Main_Load(object sender, EventArgs e)
        {
             controllerObj= new Controller();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vet F = new Vet();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile f = new Profile(ID);
            f.Show();
        }
    }
}
