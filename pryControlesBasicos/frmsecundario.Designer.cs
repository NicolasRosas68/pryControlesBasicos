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
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.optFreezer = new System.Windows.Forms.RadioButton();
            this.optHeladera = new System.Windows.Forms.RadioButton();
            this.optAlacena = new System.Windows.Forms.RadioButton();
            this.mrcsalsa = new System.Windows.Forms.GroupBox();
            this.chkMayo = new System.Windows.Forms.CheckBox();
            this.chkSalsa = new System.Windows.Forms.CheckBox();
            this.chkPicante = new System.Windows.Forms.CheckBox();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.lstLista = new System.Windows.Forms.ComboBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblmostrar = new System.Windows.Forms.Label();
            this.mrcsalsa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(57, 81);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(51, 16);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "usuario";
            this.lblusuario.Click += new System.EventHandler(this.lblusuario_Click);
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Location = new System.Drawing.Point(61, 186);
            this.optAzul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(53, 20);
            this.optAzul.TabIndex = 4;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            this.optAzul.CheckedChanged += new System.EventHandler(this.optAzul_CheckedChanged);
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Location = new System.Drawing.Point(205, 190);
            this.optRojo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(57, 20);
            this.optRojo.TabIndex = 5;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            this.optRojo.CheckedChanged += new System.EventHandler(this.optRojo_CheckedChanged);
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.Location = new System.Drawing.Point(359, 186);
            this.cmdAsignar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(100, 28);
            this.cmdAsignar.TabIndex = 6;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = true;
            // 
            // optFreezer
            // 
            this.optFreezer.AutoSize = true;
            this.optFreezer.Location = new System.Drawing.Point(285, 310);
            this.optFreezer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optFreezer.Name = "optFreezer";
            this.optFreezer.Size = new System.Drawing.Size(74, 20);
            this.optFreezer.TabIndex = 7;
            this.optFreezer.TabStop = true;
            this.optFreezer.Text = "Freezer";
            this.optFreezer.UseVisualStyleBackColor = true;
            // 
            // optHeladera
            // 
            this.optHeladera.AutoSize = true;
            this.optHeladera.Location = new System.Drawing.Point(149, 310);
            this.optHeladera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optHeladera.Name = "optHeladera";
            this.optHeladera.Size = new System.Drawing.Size(85, 20);
            this.optHeladera.TabIndex = 8;
            this.optHeladera.TabStop = true;
            this.optHeladera.Text = "Heladera";
            this.optHeladera.UseVisualStyleBackColor = true;
            // 
            // optAlacena
            // 
            this.optAlacena.AutoSize = true;
            this.optAlacena.Location = new System.Drawing.Point(40, 310);
            this.optAlacena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optAlacena.Name = "optAlacena";
            this.optAlacena.Size = new System.Drawing.Size(78, 20);
            this.optAlacena.TabIndex = 9;
            this.optAlacena.TabStop = true;
            this.optAlacena.Text = "Alacena";
            this.optAlacena.UseVisualStyleBackColor = true;
            // 
            // mrcsalsa
            // 
            this.mrcsalsa.Controls.Add(this.chkMayo);
            this.mrcsalsa.Controls.Add(this.chkSalsa);
            this.mrcsalsa.Controls.Add(this.chkPicante);
            this.mrcsalsa.Location = new System.Drawing.Point(61, 353);
            this.mrcsalsa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcsalsa.Name = "mrcsalsa";
            this.mrcsalsa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcsalsa.Size = new System.Drawing.Size(267, 123);
            this.mrcsalsa.TabIndex = 11;
            this.mrcsalsa.TabStop = false;
            this.mrcsalsa.Text = "salsa";
            this.mrcsalsa.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkMayo
            // 
            this.chkMayo.AutoSize = true;
            this.chkMayo.Location = new System.Drawing.Point(29, 52);
            this.chkMayo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMayo.Name = "chkMayo";
            this.chkMayo.Size = new System.Drawing.Size(63, 20);
            this.chkMayo.TabIndex = 2;
            this.chkMayo.Text = "Mayo";
            this.chkMayo.UseVisualStyleBackColor = true;
            // 
            // chkSalsa
            // 
            this.chkSalsa.AutoSize = true;
            this.chkSalsa.Location = new System.Drawing.Point(29, 80);
            this.chkSalsa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSalsa.Name = "chkSalsa";
            this.chkSalsa.Size = new System.Drawing.Size(64, 20);
            this.chkSalsa.TabIndex = 1;
            this.chkSalsa.Text = "Salsa";
            this.chkSalsa.UseVisualStyleBackColor = true;
            // 
            // chkPicante
            // 
            this.chkPicante.AutoSize = true;
            this.chkPicante.Location = new System.Drawing.Point(29, 23);
            this.chkPicante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPicante.Name = "chkPicante";
            this.chkPicante.Size = new System.Drawing.Size(74, 20);
            this.chkPicante.TabIndex = 0;
            this.chkPicante.Text = "Picante";
            this.chkPicante.UseVisualStyleBackColor = true;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(336, 416);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(100, 28);
            this.cmdConsultar.TabIndex = 12;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Location = new System.Drawing.Point(281, 496);
            this.lblConsultar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(0, 16);
            this.lblConsultar.TabIndex = 13;
            // 
            // lstLista
            // 
            this.lstLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(336, 452);
            this.lstLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(160, 24);
            this.lstLista.TabIndex = 14;
            this.lstLista.SelectedIndexChanged += new System.EventHandler(this.lstLista_SelectedIndexChanged);
            this.lstLista.DropDownStyleChanged += new System.EventHandler(this.txtUsuario_SelectedIndexChanged);
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(190, 75);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 22);
            this.txtusuario.TabIndex = 15;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // lblmostrar
            // 
            this.lblmostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmostrar.Location = new System.Drawing.Point(163, 132);
            this.lblmostrar.Name = "lblmostrar";
            this.lblmostrar.Size = new System.Drawing.Size(139, 23);
            this.lblmostrar.TabIndex = 16;
            // 
            // frmsecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 554);
            this.Controls.Add(this.lblmostrar);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.mrcsalsa);
            this.Controls.Add(this.optAlacena);
            this.Controls.Add(this.optHeladera);
            this.Controls.Add(this.optFreezer);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.lblusuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmsecundario";
            this.Text = "frmsecundario";
            this.Load += new System.EventHandler(this.frmsecundario_Load);
            this.mrcsalsa.ResumeLayout(false);
            this.mrcsalsa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.RadioButton optFreezer;
        private System.Windows.Forms.RadioButton optHeladera;
        private System.Windows.Forms.RadioButton optAlacena;
        private System.Windows.Forms.GroupBox mrcsalsa;
        private System.Windows.Forms.CheckBox chkMayo;
        private System.Windows.Forms.CheckBox chkSalsa;
        private System.Windows.Forms.CheckBox chkPicante;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.ComboBox lstLista;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblmostrar;
    }
}