namespace Finalprj.myForm
{
    partial class DoanhThu
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
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.Date_from = new System.Windows.Forms.DateTimePicker();
            this.Date_to = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_main
            // 
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(0, 140);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.Size = new System.Drawing.Size(1040, 390);
            this.dgv_main.TabIndex = 8;
            this.dgv_main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_main_CellDoubleClick);
            this.dgv_main.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_main_CellEnter);
            // 
            // Date_from
            // 
            this.Date_from.Location = new System.Drawing.Point(86, 73);
            this.Date_from.Name = "Date_from";
            this.Date_from.Size = new System.Drawing.Size(200, 20);
            this.Date_from.TabIndex = 9;
            this.Date_from.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // Date_to
            // 
            this.Date_to.Location = new System.Drawing.Point(86, 99);
            this.Date_to.Name = "Date_to";
            this.Date_to.Size = new System.Drawing.Size(200, 20);
            this.Date_to.TabIndex = 9;
            this.Date_to.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Từ Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đến Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lọc";
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 531);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_to);
            this.Controls.Add(this.Date_from);
            this.Controls.Add(this.dgv_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoanhThu";
            this.Text = "KhoHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.DateTimePicker Date_from;
        private System.Windows.Forms.DateTimePicker Date_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}