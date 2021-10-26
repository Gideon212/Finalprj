using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalprj.myForm
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            Load();
        }

        private new void Load()
        {
            //myForm.KhoHang child = new myForm.KhoHang();
            //AllUser.OpenChildForm(child, panel_details);

            myForm.DoanhThu child = new myForm.DoanhThu();
            AllUser.OpenChildForm(child,panel_details);
        }
    }
}
