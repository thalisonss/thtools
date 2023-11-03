namespace ThTools.Screens
{
    partial class frmMainScreen
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
            this.components = new System.ComponentModel.Container();
            this.lblUsoCPU = new System.Windows.Forms.Label();
            this.timerAtualizarInfoCPU = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cboPowerPlan = new System.Windows.Forms.ComboBox();
            this.lblPlanoAtivo = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsoCPU
            // 
            this.lblUsoCPU.BackColor = System.Drawing.Color.Transparent;
            this.lblUsoCPU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsoCPU.ForeColor = System.Drawing.Color.Snow;
            this.lblUsoCPU.Location = new System.Drawing.Point(272, -1);
            this.lblUsoCPU.Name = "lblUsoCPU";
            this.lblUsoCPU.Size = new System.Drawing.Size(44, 22);
            this.lblUsoCPU.TabIndex = 3;
            this.lblUsoCPU.Text = "100%";
            this.lblUsoCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerAtualizarInfoCPU
            // 
            this.timerAtualizarInfoCPU.Enabled = true;
            this.timerAtualizarInfoCPU.Interval = 700;
            this.timerAtualizarInfoCPU.Tick += new System.EventHandler(this.timerAtualizarInfoCPU_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(245, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 22);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.lblUsoCPU);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-2, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 22);
            this.panel2.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(5, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(307, 331);
            this.tabControl1.TabIndex = 7;
            // 
            // cboPowerPlan
            // 
            this.cboPowerPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPowerPlan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPowerPlan.FormattingEnabled = true;
            this.cboPowerPlan.Location = new System.Drawing.Point(9, 34);
            this.cboPowerPlan.Name = "cboPowerPlan";
            this.cboPowerPlan.Size = new System.Drawing.Size(148, 25);
            this.cboPowerPlan.TabIndex = 0;
            this.cboPowerPlan.SelectedIndexChanged += new System.EventHandler(this.cboPowerPlan_SelectedIndexChanged);
            // 
            // lblPlanoAtivo
            // 
            this.lblPlanoAtivo.AutoSize = true;
            this.lblPlanoAtivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanoAtivo.ForeColor = System.Drawing.Color.Snow;
            this.lblPlanoAtivo.Location = new System.Drawing.Point(6, 14);
            this.lblPlanoAtivo.Name = "lblPlanoAtivo";
            this.lblPlanoAtivo.Size = new System.Drawing.Size(0, 17);
            this.lblPlanoAtivo.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.tabPage1.Controls.Add(this.lblPlanoAtivo);
            this.tabPage1.Controls.Add(this.cboPowerPlan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(299, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Energia";
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(318, 385);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUsoCPU;
        private System.Windows.Forms.Timer timerAtualizarInfoCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblPlanoAtivo;
        private System.Windows.Forms.ComboBox cboPowerPlan;
    }
}