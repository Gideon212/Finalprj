namespace Finalprj
{
    partial class Main
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
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_tool = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.Btn_khohang = new System.Windows.Forms.Button();
            this.Btn_doanhthu = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.DimGray;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(100, 100);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_menu.Controls.Add(this.Btn_doanhthu);
            this.panel_menu.Controls.Add(this.Btn_khohang);
            this.panel_menu.Location = new System.Drawing.Point(0, 100);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(100, 500);
            this.panel_menu.TabIndex = 1;
            // 
            // panel_tool
            // 
            this.panel_tool.BackColor = System.Drawing.Color.Cyan;
            this.panel_tool.Location = new System.Drawing.Point(100, 0);
            this.panel_tool.Name = "panel_tool";
            this.panel_tool.Size = new System.Drawing.Size(1040, 30);
            this.panel_tool.TabIndex = 2;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel_main.Location = new System.Drawing.Point(100, 30);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1040, 570);
            this.panel_main.TabIndex = 3;
            this.panel_main.DoubleClick += new System.EventHandler(this.panel_main_DoubleClick);
            // 
            // Btn_khohang
            // 
            this.Btn_khohang.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_khohang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_khohang.Location = new System.Drawing.Point(0, 0);
            this.Btn_khohang.Name = "Btn_khohang";
            this.Btn_khohang.Size = new System.Drawing.Size(100, 50);
            this.Btn_khohang.TabIndex = 0;
            this.Btn_khohang.Text = "ho hàng";
            this.Btn_khohang.UseVisualStyleBackColor = false;
            this.Btn_khohang.Click += new System.EventHandler(this.Btn_khohang_Click);
            // 
            // Btn_doanhthu
            // 
            this.Btn_doanhthu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_doanhthu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_doanhthu.Location = new System.Drawing.Point(0, 50);
            this.Btn_doanhthu.Name = "Btn_doanhthu";
            this.Btn_doanhthu.Size = new System.Drawing.Size(100, 50);
            this.Btn_doanhthu.TabIndex = 0;
            this.Btn_doanhthu.Text = "Doanh thu";
            this.Btn_doanhthu.UseVisualStyleBackColor = false;
            this.Btn_doanhthu.Click += new System.EventHandler(this.Btn_doanhthu_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 601);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_tool);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_logo);
            this.Name = "Main";
            this.Text = "Main";
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_tool;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button Btn_doanhthu;
        private System.Windows.Forms.Button Btn_khohang;
    }
}