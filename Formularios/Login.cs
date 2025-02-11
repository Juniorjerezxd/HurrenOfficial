namespace Hurren2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Agregar los usuarios al combo box
            cmbUsername.Items.Add("Julia");
            cmbUsername.Items.Add("Johnson");
            cmbUsername.Items.Add("Abigail");
            cmbUsername.Items.Add("Willy");

            // Seleccionar el primer usuario por defecto
            cmbUsername.SelectedIndex = 0;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Obtener el usuario seleccionado y la contraseña ingresada
            string username = cmbUsername.SelectedItem.ToString();
            string password = txtPassword.Text;

            // Validar la contraseña
            string contrasenaValida = "1234";

            if (password == contrasenaValida)
            {
                MessageBox.Show($"Inicio de sesión correcto. Bienvenido, {username}.");

                // Indicar que el login fue exitoso y cerrar este formulario
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Este evento puede ser usado si necesitas realizar alguna acción al cambiar de usuario
        }
    }
}

