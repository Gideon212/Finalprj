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
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
            Load();
        }

        private new void Load()
        {
            DBaccess.DoanhThuAccess dthu = new DBaccess.DoanhThuAccess();
            dgv_main.DataSource = null;
            dgv_main.Rows.Clear();
            dgv_main.DataSource = dthu.GetDoanhThu(DateTime.Now, DateTime.Now);
            dgv_main.AutoGenerateColumns = true;
        }

        private void Dgv_main_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
