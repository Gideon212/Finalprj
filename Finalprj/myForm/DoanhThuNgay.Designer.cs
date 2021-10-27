namespace Finalprj.myForm
{
    partial class DoanhThuNgay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dgv_main = new System.Windows.Forms.DataGridView();
            this.btn_switch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_back = new System.Windows.Forms.Button();
            this.Date_NgayChitiet = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dgv_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 379);
            this.panel1.TabIndex = 0;
            // 
            // Dgv_main
            // 
            this.Dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_main.Location = new System.Drawing.Point(0, 0);
            this.Dgv_main.Name = "Dgv_main";
            this.Dgv_main.Size = new System.Drawing.Size(800, 379);
            this.Dgv_main.TabIndex = 0;
            // 
            // btn_switch
            // 
            this.btn_switch.Location = new System.Drawing.Point(713, 42);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(75, 23);
            this.btn_switch.TabIndex = 1;
            this.btn_switch.Text = "Nhập Hàng";
            this.btn_switch.UseVisualStyleBackColor = true;
            this.btn_switch.Click += new System.EventHandler(this.Btn_switch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đổi danh sách";
            // 
            // Btn_back
            // 
            this.Btn_back.Location = new System.Drawing.Point(12, 42);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(75, 23);
            this.Btn_back.TabIndex = 3;
            this.Btn_back.Text = "Trở lại";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Visible = false;
            // 
            // Date_NgayChitiet
            // 
            this.Date_NgayChitiet.Location = new System.Drawing.Point(184, 42);
            this.Date_NgayChitiet.Name = "Date_NgayChitiet";
            this.Date_NgayChitiet.Size = new System.Drawing.Size(200, 20);
            this.Date_NgayChitiet.TabIndex = 4;
            // 
            // DoanhThuNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Date_NgayChitiet);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_switch);
            this.Controls.Add(this.panel1);
            this.Name = "DoanhThuNgay";
            this.Text = "DoanhThuNgay";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dgv_main;
        private System.Windows.Forms.Button btn_switch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_back;
        public System.Windows.Forms.DateTimePicker Date_NgayChitiet;
    }
}