namespace TaskFlow
{
    public partial class VerifyOtpForm : Form
    {
        public VerifyOtpForm()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOtp.Text))
            {
                lblError.Text = "Digite o código recebido por email.";
                return;
            }

            if (txtOtp.Text.Length != 6 || !txtOtp.Text.All(char.IsDigit))
            {
                lblError.Text = "O código deve ter 6 dígitos.";
                return;
            }

            lblError.Text = string.Empty;

            using var reset = new ResetPasswordForm();
            var result = reset.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void lnkResend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtOtp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
