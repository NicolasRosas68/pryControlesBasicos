namespace pryControlesBasicos
{
    partial class frmPrincipal
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
            this.lblejey = new System.Windows.Forms.Label();
            this.lblejex = new System.Windows.Forms.Label();
            this.lblVienvenidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblejey
            // 
            this.lblejey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblejey.AutoSize = true;
            this.lblejey.Location = new System.Drawing.Point(182, 127);
            this.lblejey.Name = "lblejey";
            this.lblejey.Size = new System.Drawing.Size(12, 13);
            this.lblejey.TabIndex = 0;
            this.lblejey.Text = "y";
            // 
            // lblejex
            // 
            this.lblejex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblejex.AutoSize = true;
            this.lblejex.Location = new System.Drawing.Point(182, 50);
            this.lblejex.Name = "lblejex";
            this.lblejex.Size = new System.Drawing.Size(12, 13);
            this.lblejex.TabIndex = 1;
            this.lblejex.Text = "x";
            this.lblejex.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblejex_MouseMove);
            // 
            // lblVienvenidos
            // 
            this.lblVienvenidos.AutoSize = true;
            this.lblVienvenidos.Location = new System.Drawing.Point(32, 157);
            this.lblVienvenidos.Name = "lblVienvenidos";
            this.lblVienvenidos.Size = new System.Drawing.Size(102, 13);
            this.lblVienvenidos.TabIndex = 2;
            this.lblVienvenidos.Text = "Nop dejes la carrera";
            this.lblVienvenidos.Visible = false;
            this.lblVienvenidos.Click += new System.EventHandler(this.lblVienvenidos_Click);
            this.lblVienvenidos.MouseEnter += new System.EventHandler(this.lblVienvenidos_MouseEnter);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 343);
            this.Controls.Add(this.lblVienvenidos);
            this.Controls.Add(this.lblejex);
            this.Controls.Add(this.lblejey);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Titulo de la ventana";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Click += new System.EventHandler(this.frmPrincipal_Click);
            this.MouseEnter += new System.EventHandler(this.frmPrincipal_MouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblejey;
        private System.Windows.Forms.Label lblejex;
        private System.Windows.Forms.Label lblVienvenidos;
    }
}