namespace pryControlesBasicos
{
    partial class frmsecundario
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
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.ComboBox();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.optFreezer = new System.Windows.Forms.RadioButton();
            this.optHeladera = new System.Windows.Forms.RadioButton();
            this.optAlacena = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(43, 66);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(41, 13);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "usuario";
            this.lblusuario.Click += new System.EventHandler(this.lblusuario_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.FormattingEnabled = true;
            this.txtUsuario.Location = new System.Drawing.Point(192, 58);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 21);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.SelectedIndexChanged += new System.EventHandler(this.txtUsuario_SelectedIndexChanged);
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Location = new System.Drawing.Point(46, 151);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(45, 17);
            this.optAzul.TabIndex = 4;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Location = new System.Drawing.Point(149, 177);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(47, 17);
            this.optRojo.TabIndex = 5;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.Location = new System.Drawing.Point(269, 151);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(75, 23);
            this.cmdAsignar.TabIndex = 6;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = true;
            // 
            // optFreezer
            // 
            this.optFreezer.AutoSize = true;
            this.optFreezer.Location = new System.Drawing.Point(214, 252);
            this.optFreezer.Name = "optFreezer";
            this.optFreezer.Size = new System.Drawing.Size(60, 17);
            this.optFreezer.TabIndex = 7;
            this.optFreezer.TabStop = true;
            this.optFreezer.Text = "Freezer";
            this.optFreezer.UseVisualStyleBackColor = true;
            // 
            // optHeladera
            // 
            this.optHeladera.AutoSize = true;
            this.optHeladera.Location = new System.Drawing.Point(112, 252);
            this.optHeladera.Name = "optHeladera";
            this.optHeladera.Size = new System.Drawing.Size(68, 17);
            this.optHeladera.TabIndex = 8;
            this.optHeladera.TabStop = true;
            this.optHeladera.Text = "Heladera";
            this.optHeladera.UseVisualStyleBackColor = true;
            // 
            // optAlacena
            // 
            this.optAlacena.AutoSize = true;
            this.optAlacena.Location = new System.Drawing.Point(30, 252);
            this.optAlacena.Name = "optAlacena";
            this.optAlacena.Size = new System.Drawing.Size(64, 17);
            this.optAlacena.TabIndex = 9;
            this.optAlacena.TabStop = true;
            this.optAlacena.Text = "Alacena";
            this.optAlacena.UseVisualStyleBackColor = true;
            // 
            // frmsecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.optAlacena);
            this.Controls.Add(this.optHeladera);
            this.Controls.Add(this.optFreezer);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblusuario);
            this.Name = "frmsecundario";
            this.Text = "frmsecundario";
            this.Load += new System.EventHandler(this.frmsecundario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.ComboBox txtUsuario;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.RadioButton optFreezer;
        private System.Windows.Forms.RadioButton optHeladera;
        private System.Windows.Forms.RadioButton optAlacena;
    }
}