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
    public partial class KhoHang : Form
    {
        int themFlag = 1;   //Flag = 0 sua, Flag = 1 them

        public KhoHang()
        {
            InitializeComponent();
            Load();
        }

        private new void Load()
        {
            dgv_main.DataSource = null;
            dgv_main.Rows.Clear();
            dgv_main.Refresh();
            DBaccess.KhoHangAccess kh = new DBaccess.KhoHangAccess();
            dgv_main.DataSource = kh.Get();
            dgv_main.AutoGenerateColumns = true;
            try
            {
                txt_mathang.Text = dgv_main.Rows[0].Cells[1].Value.ToString();
                txt_soluong.Text = dgv_main.Rows[0].Cells[3].Value.ToString();
                txt_dongia.Text = dgv_main.Rows[0].Cells[4].Value.ToString();
                lb_donvi.Text = txt_donvi.Text = dgv_main.Rows[0].Cells[2].Value.ToString();
                txt_id.Text = dgv_main.Rows[0].Cells[0].Value.ToString();
            }
            catch
            {

            }
            btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled = true;
            btn_ok.Visible = btn_huy.Visible = false;
            txt_id.Enabled = txt_mathang.Enabled = txt_soluong.Enabled = txt_donvi.Enabled = txt_dongia.Enabled = false;
            txt_donvi.Visible = lb_donvithem.Visible = false;
            lb_donvi.Visible = true;
        }

        private void Btn_them_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled = false;
            btn_ok.Visible = btn_huy.Visible = true;
            txt_id.Text = txt_mathang.Text = txt_soluong.Text = txt_donvi.Text = txt_dongia.Text = "";
            txt_id.Enabled = txt_mathang.Enabled = txt_soluong.Enabled = txt_donvi.Enabled = txt_dongia.Enabled = true;
            txt_donvi.Visible = lb_donvithem.Visible = true;
            lb_donvi.Visible = false;
            themFlag = 1;
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                myDataBase.KhoHang kh = new myDataBase.KhoHang
                {
                    ID = txt_id.Text,
                    Ten = txt_mathang.Text,
                    DonViTinh = txt_donvi.Text,
                    soLuong = int.Parse(txt_soluong.Text),
                    DonGia = float.Parse(txt_dongia.Text)
                };
                DBaccess.KhoHangAccess kha = new DBaccess.KhoHangAccess();
                if (themFlag == 1)
                {
                    kha.Them(kh);
                    MessageBox.Show("Da them xong", "Them", MessageBoxButtons.OK);
                }
                else
                {
                    kha.Sua(kh);
                    MessageBox.Show("Da sua xong", "sua", MessageBoxButtons.OK);
                }
                //
                Load();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OK);
            }
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ban co chac chan muon xoa?", "Xoa", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                string ID = txt_id.Text;
                DBaccess.KhoHangAccess kha = new DBaccess.KhoHangAccess();
                kha.Xoa(ID);
                Load();
            }
            else
            {

            }
        }

        private void Btn_sua_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled = false;
            btn_ok.Visible = btn_huy.Visible = true;
            txt_id.Enabled = txt_mathang.Enabled = txt_soluong.Enabled = txt_donvi.Enabled = txt_dongia.Enabled = true;
            txt_donvi.Visible = lb_donvithem.Visible = true;
            lb_donvi.Visible = false;
            themFlag = 0;
        }

        private void Btn_huy_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void Dgv_main_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txt_id.Text = dgv_main.Rows[index].Cells[0].Value.ToString();
            txt_mathang.Text = dgv_main.Rows[index].Cells[1].Value.ToString();
            txt_soluong.Text = dgv_main.Rows[index].Cells[3].Value.ToString();
            txt_dongia.Text = dgv_main.Rows[index].Cells[4].Value.ToString();
            lb_donvi.Text = txt_donvi.Text = dgv_main.Rows[index].Cells[2].Value.ToString();
        }
    }
}
