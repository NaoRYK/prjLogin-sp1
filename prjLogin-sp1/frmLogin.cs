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
            if (txtUsuario.Text == "admin" && txtContrase�a.Text == "admin")
            {
                this.Hide();
                frmInicio inicio = new frmInicio();
                inicio.Text = txtUsuario.Text;
                inicio.ShowDialog();
                this.Show();
                txtUsuario.Clear();
                txtContrase�a.Clear();
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos", "Error");
                intentos++;
                if (intentos >= 3)
                {
                    MessageBox.Show("Ha superado el n�mero de intentos permitidos. La aplicaci�n se cerrar�.", "Error");
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
