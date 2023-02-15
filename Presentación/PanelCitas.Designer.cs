namespace veterinaria.Presentación
{
    partial class PanelCitas
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TituloCitass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TituloCitass
            // 
            this.TituloCitass.BackColor = System.Drawing.Color.DimGray;
            this.TituloCitass.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloCitass.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TituloCitass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TituloCitass.Location = new System.Drawing.Point(0, 0);
            this.TituloCitass.Name = "TituloCitass";
            this.TituloCitass.Size = new System.Drawing.Size(912, 39);
            this.TituloCitass.TabIndex = 0;
            this.TituloCitass.Text = "Bienvenido A las Citas Agendadas";
            this.TituloCitass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(912, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reporte de Citas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(46, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 424);
            this.panel1.TabIndex = 2;
            // 
            // PanelCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TituloCitass);
            this.Name = "PanelCitas";
            this.Size = new System.Drawing.Size(912, 588);
            this.Load += new System.EventHandler(this.PanelCitas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label TituloCitass;
        private Label label1;
        private Panel panel1;
    }
}
