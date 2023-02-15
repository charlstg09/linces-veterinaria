using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veterinaria.Presentación
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelMedicinas controlMedicinas = new PanelMedicinas();
            panel4.Controls.Clear();
            controlMedicinas.Dock = DockStyle.Fill;
            panel4.Controls.Add(controlMedicinas);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            PanelBienvenida.Dock = DockStyle.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PanelPerfil ControlPerfil = new PanelPerfil();
            panel4.Controls.Clear();
            ControlPerfil.Dock = DockStyle.Fill;
            panel4.Controls.Add(ControlPerfil);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelCitas Control = new PanelCitas();
            panel4.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            panel4.Controls.Add(Control);
        }

        private void BtnAgendarCitas_Click(object sender, EventArgs e)
        {
            PanelAgendarCitas ControlAgendarCitas = new PanelAgendarCitas();
            panel4.Controls.Clear();
            ControlAgendarCitas.Dock = DockStyle.Fill;
            panel4.Controls.Add(ControlAgendarCitas);
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
