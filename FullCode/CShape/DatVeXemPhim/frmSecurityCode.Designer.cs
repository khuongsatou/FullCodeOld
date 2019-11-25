namespace Tuan5_lv5_WinForm
{
    partial class frmSecurityCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecurityCode));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbAccessLog = new System.Windows.Forms.RichTextBox();
            this.txtSecurity = new System.Windows.Forms.TextBox();
            this.flpControl = new System.Windows.Forms.FlowLayoutPanel();
            this.btnC = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Security";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Access log:";
            // 
            // rtbAccessLog
            // 
            this.rtbAccessLog.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbAccessLog.Location = new System.Drawing.Point(26, 266);
            this.rtbAccessLog.Name = "rtbAccessLog";
            this.rtbAccessLog.Size = new System.Drawing.Size(301, 96);
            this.rtbAccessLog.TabIndex = 2;
            this.rtbAccessLog.Text = "";
            this.rtbAccessLog.WordWrap = false;
            // 
            // txtSecurity
            // 
            this.txtSecurity.BackColor = System.Drawing.SystemColors.Control;
            this.txtSecurity.Location = new System.Drawing.Point(108, 38);
            this.txtSecurity.Name = "txtSecurity";
            this.txtSecurity.ReadOnly = true;
            this.txtSecurity.Size = new System.Drawing.Size(219, 20);
            this.txtSecurity.TabIndex = 3;
            // 
            // flpControl
            // 
            this.flpControl.Location = new System.Drawing.Point(108, 79);
            this.flpControl.Name = "flpControl";
            this.flpControl.Size = new System.Drawing.Size(164, 111);
            this.flpControl.TabIndex = 4;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(279, 79);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(48, 34);
            this.btnC.TabIndex = 5;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Image = ((System.Drawing.Image)(resources.GetObject("btnKiemTra.Image")));
            this.btnKiemTra.Location = new System.Drawing.Point(279, 119);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(48, 35);
            this.btnKiemTra.TabIndex = 6;
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(278, 160);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(48, 30);
            this.btn0.TabIndex = 7;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 373);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.flpControl);
            this.Controls.Add(this.txtSecurity);
            this.Controls.Add(this.rtbAccessLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbAccessLog;
        private System.Windows.Forms.TextBox txtSecurity;
        private System.Windows.Forms.FlowLayoutPanel flpControl;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Button btn0;
    }
}

