namespace prjLogin_sp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        int intentos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin")
            {
                this.Hide();
                frmInicio inicio = new frmInicio();
                inicio.Text = txtUsuario.Text;
                inicio.ShowDialog();
                this.Show();
                txtUsuario.Clear();
                txtContraseña.Clear();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error");
                intentos++;
                if (intentos >= 3)
                {
                    MessageBox.Show("Ha superado el número de intentos permitidos. La aplicación se cerrará.", "Error");
                    this.Close();
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
