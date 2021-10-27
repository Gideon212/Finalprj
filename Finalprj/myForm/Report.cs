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
        public string BtnFlag { get; set; }

        public Report()
        {
            InitializeComponent();
            //Load();
        }


        public Report(string btnflag)
        {
            InitializeComponent();
            Load(btnflag);
        }

        private new void Load(string btnflag)
        {
            lb_flag.Text = btnflag;
            switch (btnflag) 
            {
                case "Kho hàng":
                    myForm.KhoHang khchild = new myForm.KhoHang();
                    AllUser.OpenChildForm(khchild, panel_details);
                    break;
                case "Doanh thu":
                    myForm.DoanhThu dtchild = new myForm.DoanhThu();
                    AllUser.OpenChildForm(dtchild, panel_details); 
                    break;
                    
                default: 
                    break;
            }

        }
    }
}
