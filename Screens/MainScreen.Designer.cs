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
            this.cboPowerPlan = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.lblPlanoAtivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboPowerPlan
            // 
            this.cboPowerPlan.FormattingEnabled = true;
            this.cboPowerPlan.Location = new System.Drawing.Point(12, 212);
            this.cboPowerPlan.Name = "cboPowerPlan";
            this.cboPowerPlan.Size = new System.Drawing.Size(697, 21);
            this.cboPowerPlan.TabIndex = 0;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(628, 240);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 1;
            this.btnAplicar.Text = "button1";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // lblPlanoAtivo
            // 
            this.lblPlanoAtivo.AutoSize = true;
            this.lblPlanoAtivo.Location = new System.Drawing.Point(251, 124);
            this.lblPlanoAtivo.Name = "lblPlanoAtivo";
            this.lblPlanoAtivo.Size = new System.Drawing.Size(38, 13);
            this.lblPlanoAtivo.TabIndex = 2;
            this.lblPlanoAtivo.Text = "label1";
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(733, 276);
            this.Controls.Add(this.lblPlanoAtivo);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.cboPowerPlan);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPowerPlan;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label lblPlanoAtivo;
    }
}