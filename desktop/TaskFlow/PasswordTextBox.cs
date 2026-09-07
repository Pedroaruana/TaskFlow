using System.ComponentModel;

namespace TaskFlow
{
    public class PasswordTextBox : Panel
    {
        private readonly TextBox textBox;
        private readonly Button toggleButton;
        private bool passwordVisible;

        public PasswordTextBox()
        {
            Height = 23;

            textBox = new TextBox
            {
                Dock = DockStyle.Fill,
                PasswordChar = '•',
            };

            toggleButton = new Button
            {
                Text = "👁",
                Dock = DockStyle.Right,
                Width = 32,
                FlatStyle = FlatStyle.Flat,
                TabStop = false,
                Cursor = Cursors.Hand,
            };
            toggleButton.FlatAppearance.BorderSize = 0;
            toggleButton.Click += (_, _) => ToggleVisibility();

            Controls.Add(textBox);
            Controls.Add(toggleButton);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Value
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PlaceholderText
        {
            get => textBox.PlaceholderText;
            set => textBox.PlaceholderText = value;
        }

        public event EventHandler ValueChanged
        {
            add => textBox.TextChanged += value;
            remove => textBox.TextChanged -= value;
        }

        private void ToggleVisibility()
        {
            passwordVisible = !passwordVisible;
            textBox.PasswordChar = passwordVisible ? '\0' : '•';
            toggleButton.Text = passwordVisible ? "🙈" : "👁";
        }
    }
}
