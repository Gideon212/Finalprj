namespace Finalprj.myForm
{
    partial class Report
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
            this.lb_flag = new System.Windows.Forms.Label();
            this.panel_details = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lb_flag
            // 
            this.lb_flag.AutoSize = true;
            this.lb_flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_flag.Location = new System.Drawing.Point(12, 9);
            this.lb_flag.Name = "lb_flag";
            this.lb_flag.Size = new System.Drawing.Size(100, 24);
            this.lb_flag.TabIndex = 0;
            this.lb_flag.Text = "Kho hàng";
            // 
            // panel_details
            // 
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_details.Location = new System.Drawing.Point(0, 39);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(1040, 531);
            this.panel_details.TabIndex = 4;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 570);
            this.Controls.Add(this.panel_details);
            this.Controls.Add(this.lb_flag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_flag;
        public System.Windows.Forms.Panel panel_details;
    }
}