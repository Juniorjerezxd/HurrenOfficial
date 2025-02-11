using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hurren2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void joyeriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Joyeria JoyeriaForm = new Joyeria();
            JoyeriaForm.Show();

        }

        private void electronicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Electronicos ElectronicosForm = new Electronicos();
            ElectronicosForm.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario usuarioForm = new FrmUsuario();
            usuarioForm.Show();

        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoProductos listadoProductosForm = new ListadoProductos();
            listadoProductosForm.Show();
        }

        private void articulosEnSubastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticulosEnSubasta articulosEnSubastaForm = new FrmArticulosEnSubasta();
            articulosEnSubastaForm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientesForm = new Clientes();
            clientesForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
