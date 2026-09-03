namespace TaskFlow
{
    public partial class SignupForm : Form
    {
        private static readonly Color BarEmpty = Color.Gainsboro;
        private static readonly Color[] StrengthColors =
        {
            Color.FromArgb(220, 53, 69),   // Fraca
            Color.FromArgb(253, 126, 20),  // Média
            Color.FromArgb(255, 193, 7),   // Boa
            Color.FromArgb(40, 167, 69),   // Forte
        };
        private static readonly string[] StrengthLabels = { "Fraca", "Média", "Boa", "Forte" };

        public SignupForm()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            var password = txtPassword.Text;
            var score = PasswordStrength(password);
            var bars = new[] { pnlBar1, pnlBar2, pnlBar3, pnlBar4 };

            for (var i = 0; i < bars.Length; i++)
            {
                bars[i].BackColor = i < score ? StrengthColors[score - 1] : BarEmpty;
            }

            lblStrengthHint.Text = password.Length == 0
                ? "Digite uma senha forte (mín. 8 caracteres)"
                : StrengthLabels[Math.Max(score - 1, 0)];
        }

        private static int PasswordStrength(string password)
        {
            var score = 0;
            if (password.Length >= 8) score++;
            if (password.Any(char.IsUpper)) score++;
            if (password.Any(char.IsLower)) score++;
            if (password.Any(char.IsDigit)) score++;
            return score;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            // No backend/API integration in this issue.
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
