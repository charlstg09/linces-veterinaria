namespace veterinaria.Presentación
{
    partial class MenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPerfil = new System.Windows.Forms.Button();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.BtnAgendarCitas = new System.Windows.Forms.Button();
            this.BtnMedicina = new System.Windows.Forms.Button();
            this.BtnCitas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelBienvenida = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.BtnPerfil);
            this.panel1.Controls.Add(this.BtnCerrarSesion);
            this.panel1.Controls.Add(this.BtnAgendarCitas);
            this.panel1.Controls.Add(this.BtnMedicina);
            this.panel1.Controls.Add(this.BtnCitas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 633);
            this.panel1.TabIndex = 0;
            // 
            // BtnPerfil
            // 
            this.BtnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnPerfil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPerfil.Font = new System.Drawing.Font("STXinwei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPerfil.ForeColor = System.Drawing.Color.White;
            this.BtnPerfil.Image = global::veterinaria.Properties.Resources.usuario_1_;
            this.BtnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPerfil.Location = new System.Drawing.Point(0, 575);
            this.BtnPerfil.Name = "BtnPerfil";
            this.BtnPerfil.Size = new System.Drawing.Size(275, 29);
            this.BtnPerfil.TabIndex = 7;
            this.BtnPerfil.Text = "PERFIL";
            this.BtnPerfil.UseVisualStyleBackColor = false;
            this.BtnPerfil.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("STXinwei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarSesion.Image = global::veterinaria.Properties.Resources.cerrar_sesion;
            this.BtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(0, 604);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(275, 29);
            this.BtnCerrarSesion.TabIndex = 6;
            this.BtnCerrarSesion.Text = "CERRAR SESION";
            this.BtnCerrarSesion.UseVisualStyleBackColor = false;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // BtnAgendarCitas
            // 
            this.BtnAgendarCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnAgendarCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAgendarCitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAgendarCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgendarCitas.Font = new System.Drawing.Font("STXinwei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAgendarCitas.ForeColor = System.Drawing.Color.White;
            this.BtnAgendarCitas.Image = global::veterinaria.Properties.Resources.doctor;
            this.BtnAgendarCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgendarCitas.Location = new System.Drawing.Point(0, 152);
            this.BtnAgendarCitas.Name = "BtnAgendarCitas";
            this.BtnAgendarCitas.Size = new System.Drawing.Size(275, 29);
            this.BtnAgendarCitas.TabIndex = 5;
            this.BtnAgendarCitas.Text = "AGENDAR CITAS";
            this.BtnAgendarCitas.UseVisualStyleBackColor = false;
            this.BtnAgendarCitas.Click += new System.EventHandler(this.BtnAgendarCitas_Click);
            // 
            // BtnMedicina
            // 
            this.BtnMedicina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnMedicina.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMedicina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnMedicina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedicina.Font = new System.Drawing.Font("STXinwei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMedicina.ForeColor = System.Drawing.Color.White;
            this.BtnMedicina.Image = global::veterinaria.Properties.Resources.estetoscopio;
            this.BtnMedicina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMedicina.Location = new System.Drawing.Point(0, 123);
            this.BtnMedicina.Name = "BtnMedicina";
            this.BtnMedicina.Size = new System.Drawing.Size(275, 29);
            this.BtnMedicina.TabIndex = 4;
            this.BtnMedicina.Text = "MEDICINAS";
            this.BtnMedicina.UseVisualStyleBackColor = false;
            this.BtnMedicina.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnCitas
            // 
            this.BtnCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCitas.Font = new System.Drawing.Font("STXinwei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCitas.ForeColor = System.Drawing.Color.White;
            this.BtnCitas.Image = global::veterinaria.Properties.Resources.informe_medico;
            this.BtnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCitas.Location = new System.Drawing.Point(0, 94);
            this.BtnCitas.Name = "BtnCitas";
            this.BtnCitas.Size = new System.Drawing.Size(275, 29);
            this.BtnCitas.TabIndex = 3;
            this.BtnCitas.Text = "CITAS REGISTRADAS";
            this.BtnCitas.UseVisualStyleBackColor = false;
            this.BtnCitas.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.BackgroundImage = global::veterinaria.Properties.Resources.veterinario;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 94);
            this.panel2.TabIndex = 3;
            // 
            // PanelBienvenida
            // 
            this.PanelBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.PanelBienvenida.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PanelBienvenida.ForeColor = System.Drawing.Color.Gray;
            this.PanelBienvenida.Location = new System.Drawing.Point(131, 172);
            this.PanelBienvenida.Name = "PanelBienvenida";
            this.PanelBienvenida.Size = new System.Drawing.Size(509, 236);
            this.PanelBienvenida.TabIndex = 2;
            this.PanelBienvenida.Text = "BIENVENIDO A LA VETERINARIA LINCE";
            this.PanelBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PanelBienvenida.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.PanelBienvenida);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(275, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1087, 633);
            this.panel4.TabIndex = 4;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 633);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label PanelBienvenida;
        private Button BtnCerrarSesion;
        private Button BtnAgendarCitas;
        private Button BtnCitas;
        private Panel panel2;
        protected internal Button BtnMedicina;
        private Panel panel4;
        private Button BtnPerfil;
    }
}