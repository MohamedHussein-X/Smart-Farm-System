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
    public partial class Profile : KryptonForm
    {
        Controller controllerObj;
        int ID;
        public Profile(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            NText.Text= controllerObj.getname(ID);
            IDText.Text = ID.ToString();
            Wtext.Text = controllerObj.getWorkas(ID);
           // BText.Text = controllerObj.getBOD(ID);
            AText.Text = controllerObj.getadd(ID);
            GText.Text= controllerObj.getGen(ID);

        }
      

    }
}
