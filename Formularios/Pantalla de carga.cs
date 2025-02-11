using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hurren2
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();

            // Personalizar el Label
            lblMessage.ForeColor = Color.LightSlateGray;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;

            lblMessage.Location = new Point(
                progressBar.Location.X,
                progressBar.Location.Y + progressBar.Height + 10); // 10 píxeles de espacio entre ellos
            lblMessage.Width = progressBar.Width;

            // Personalizar ProgressBar
            progressBar.Style = ProgressBarStyle.Continuous;
        }
        private async void LoadingScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                await Task.Delay(50);
                progressBar.Value = i;

                if (i < 30)
                    lblMessage.Text = "Preparando el sistema...";
                else if (i < 60)
                    lblMessage.Text = "Cargando recursos necesarios...";
                else if (i < 90)
                    lblMessage.Text = "Aplicando configuraciones...";
                else
                    lblMessage.Text = "¡Casi listo!";
            }

            // Cerrar la pantalla de carga
            this.Close();
        }

    }
}
