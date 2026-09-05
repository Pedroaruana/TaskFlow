using System.Text.RegularExpressions;

namespace TaskFlow
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private static readonly Regex EmailFormat = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblError.Text = "Digite seu email.";
                return;
            }

            if (!EmailFormat.IsMatch(txtEmail.Text))
            {
                lblError.Text = "Digite um email válido.";
                return;
            }

            lblError.Text = string.Empty;

            using var verify = new VerifyOtpForm();
            var result = verify.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void lnkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
