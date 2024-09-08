namespace GlassBridge
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.lblVS = new System.Windows.Forms.Label();
            this.cbxDificultad = new System.Windows.Forms.ComboBox();
            this.lblDificultad = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.txtJugador2 = new System.Windows.Forms.TextBox();
            this.txtJugador1 = new System.Windows.Forms.TextBox();
            this.lblJugador2 = new System.Windows.Forms.Label();
            this.lblJugador1 = new System.Windows.Forms.Label();
            this.pnlFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackgroundImage = global::GlassBridge.Properties.Resources.pnl_fondo;
            this.pnlFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFondo.Controls.Add(this.cbxDificultad);
            this.pnlFondo.Controls.Add(this.lblDificultad);
            this.pnlFondo.Controls.Add(this.btnJugar);
            this.pnlFondo.Controls.Add(this.txtJugador2);
            this.pnlFondo.Controls.Add(this.txtJugador1);
            this.pnlFondo.Controls.Add(this.lblJugador2);
            this.pnlFondo.Controls.Add(this.lblJugador1);
            this.pnlFondo.Controls.Add(this.lblVS);
            this.pnlFondo.Location = new System.Drawing.Point(1, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1033, 668);
            this.pnlFondo.TabIndex = 0;
            // 
            // lblVS
            // 
            this.lblVS.Image = global::GlassBridge.Properties.Resources.lbl_vs;
            this.lblVS.Location = new System.Drawing.Point(473, 317);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(100, 75);
            this.lblVS.TabIndex = 7;
            // 
            // cbxDificultad
            // 
            this.cbxDificultad.FormattingEnabled = true;
            this.cbxDificultad.Items.AddRange(new object[] {
            "Facíl",
            "Normal",
            "Difícil"});
            this.cbxDificultad.Location = new System.Drawing.Point(323, 573);
            this.cbxDificultad.Name = "cbxDificultad";
            this.cbxDificultad.Size = new System.Drawing.Size(130, 21);
            this.cbxDificultad.TabIndex = 6;
            // 
            // lblDificultad
            // 
            this.lblDificultad.Image = global::GlassBridge.Properties.Resources.dificultad;
            this.lblDificultad.Location = new System.Drawing.Point(323, 536);
            this.lblDificultad.Name = "lblDificultad";
            this.lblDificultad.Size = new System.Drawing.Size(130, 23);
            this.lblDificultad.TabIndex = 5;
            this.lblDificultad.Click += new System.EventHandler(this.lblDificultad_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnJugar.Image = global::GlassBridge.Properties.Resources.btn_jugar;
            this.btnJugar.Location = new System.Drawing.Point(565, 536);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(213, 68);
            this.btnJugar.TabIndex = 4;
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // txtJugador2
            // 
            this.txtJugador2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtJugador2.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJugador2.Location = new System.Drawing.Point(565, 329);
            this.txtJugador2.Multiline = true;
            this.txtJugador2.Name = "txtJugador2";
            this.txtJugador2.Size = new System.Drawing.Size(230, 46);
            this.txtJugador2.TabIndex = 3;
            this.txtJugador2.TextChanged += new System.EventHandler(this.txtJugador2_TextChanged);
            // 
            // txtJugador1
            // 
            this.txtJugador1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtJugador1.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJugador1.Location = new System.Drawing.Point(252, 329);
            this.txtJugador1.Multiline = true;
            this.txtJugador1.Name = "txtJugador1";
            this.txtJugador1.Size = new System.Drawing.Size(230, 46);
            this.txtJugador1.TabIndex = 2;
            this.txtJugador1.TextChanged += new System.EventHandler(this.txtJugador1_TextChanged);
            // 
            // lblJugador2
            // 
            this.lblJugador2.Image = global::GlassBridge.Properties.Resources.lbl_jugador_1;
            this.lblJugador2.Location = new System.Drawing.Point(236, 275);
            this.lblJugador2.Name = "lblJugador2";
            this.lblJugador2.Size = new System.Drawing.Size(263, 51);
            this.lblJugador2.TabIndex = 1;
            this.lblJugador2.Click += new System.EventHandler(this.lblJugador2_Click);
            // 
            // lblJugador1
            // 
            this.lblJugador1.Image = global::GlassBridge.Properties.Resources.lbl_jugador_2;
            this.lblJugador1.Location = new System.Drawing.Point(552, 275);
            this.lblJugador1.Name = "lblJugador1";
            this.lblJugador1.Size = new System.Drawing.Size(263, 51);
            this.lblJugador1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 671);
            this.Controls.Add(this.pnlFondo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Label lblJugador1;
        private System.Windows.Forms.TextBox txtJugador2;
        private System.Windows.Forms.TextBox txtJugador1;
        private System.Windows.Forms.Label lblJugador2;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblDificultad;
        private System.Windows.Forms.ComboBox cbxDificultad;
        private System.Windows.Forms.Label lblVS;
    }
}

