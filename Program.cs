using System;
using System.Windows.Forms;

namespace Hurren2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar pantalla de carga primero
            using (var loadingScreen = new LoadingScreen())
            {
                loadingScreen.ShowDialog();
            }

            // Mostrar login
            using (var loginForm = new Login())
            {
                if (loginForm.ShowDialog() == DialogResult.OK) // Si el login es exitoso
                {
                    // Ejecutar el formulario principal como base de la aplicación
                    Application.Run(new Main());
                }
            }
        }
    }
}
