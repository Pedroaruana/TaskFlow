namespace TaskFlow
{
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Value) || string.IsNullOrWhiteSpace(txtPasswordConfirmation.Value))
            {
                lblError.Text = "Preencha os dois campos de senha.";
                return;
            }

            if (txtPassword.Value.Length < 8)
            {
                lblError.Text = "A senha deve ter no mínimo 8 caracteres.";
                return;
            }

            if (txtPassword.Value != txtPasswordConfirmation.Value)
            {
                lblError.Text = "As senhas não coincidem.";
                return;
            }

            lblError.Text = string.Empty;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
