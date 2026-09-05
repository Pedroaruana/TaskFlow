namespace TaskFlow
{
    partial class ResetPasswordForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private BrandPanel brandPanel;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.TableLayoutPanel tableForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblPassword;
        private PasswordTextBox txtPassword;
        private System.Windows.Forms.Label lblPasswordConfirmation;
        private PasswordTextBox txtPasswordConfirmation;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnReset;

        private void InitializeComponent()
        {
            brandPanel = new BrandPanel();
            pnlForm = new System.Windows.Forms.Panel();
            tableForm = new System.Windows.Forms.TableLayoutPanel();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new PasswordTextBox();
            lblPasswordConfirmation = new System.Windows.Forms.Label();
            txtPasswordConfirmation = new PasswordTextBox();
            lblError = new System.Windows.Forms.Label();
            btnReset = new System.Windows.Forms.Button();
            pnlForm.SuspendLayout();
            tableForm.SuspendLayout();
            SuspendLayout();
            //
            // pnlForm
            //
            pnlForm.Controls.Add(tableForm);
            pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlForm.Location = new System.Drawing.Point(300, 0);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new System.Windows.Forms.Padding(48, 56, 48, 24);
            pnlForm.Size = new System.Drawing.Size(400, 560);
            pnlForm.TabIndex = 1;
            //
            // tableForm
            //
            tableForm.AutoSize = true;
            tableForm.ColumnCount = 1;
            tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableForm.Controls.Add(lblTitle, 0, 0);
            tableForm.Controls.Add(lblSubtitle, 0, 1);
            tableForm.Controls.Add(lblPassword, 0, 2);
            tableForm.Controls.Add(txtPassword, 0, 3);
            tableForm.Controls.Add(lblPasswordConfirmation, 0, 4);
            tableForm.Controls.Add(txtPasswordConfirmation, 0, 5);
            tableForm.Controls.Add(lblError, 0, 6);
            tableForm.Controls.Add(btnReset, 0, 7);
            tableForm.Dock = System.Windows.Forms.DockStyle.Top;
            tableForm.Location = new System.Drawing.Point(48, 56);
            tableForm.Name = "tableForm";
            tableForm.RowCount = 8;
            for (int i = 0; i < 8; i++)
            {
                tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            }
            tableForm.Size = new System.Drawing.Size(304, 320);
            tableForm.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(3, 0);
            lblTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            lblTitle.MaximumSize = new System.Drawing.Size(300, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(260, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Crie uma nova senha";
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            lblSubtitle.Location = new System.Drawing.Point(3, 40);
            lblSubtitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 16);
            lblSubtitle.MaximumSize = new System.Drawing.Size(300, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(290, 30);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sua nova senha deve ser diferente da anterior.";
            //
            // lblPassword
            //
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPassword.Location = new System.Drawing.Point(3, 90);
            lblPassword.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(65, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Nova senha";
            //
            // txtPassword
            //
            txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            txtPassword.Location = new System.Drawing.Point(3, 109);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "********";
            txtPassword.Size = new System.Drawing.Size(298, 23);
            txtPassword.TabIndex = 3;
            //
            // lblPasswordConfirmation
            //
            lblPasswordConfirmation.AutoSize = true;
            lblPasswordConfirmation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPasswordConfirmation.Location = new System.Drawing.Point(3, 148);
            lblPasswordConfirmation.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            lblPasswordConfirmation.Name = "lblPasswordConfirmation";
            lblPasswordConfirmation.Size = new System.Drawing.Size(130, 15);
            lblPasswordConfirmation.TabIndex = 4;
            lblPasswordConfirmation.Text = "Confirme a nova senha";
            //
            // txtPasswordConfirmation
            //
            txtPasswordConfirmation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            txtPasswordConfirmation.Location = new System.Drawing.Point(3, 167);
            txtPasswordConfirmation.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            txtPasswordConfirmation.PlaceholderText = "********";
            txtPasswordConfirmation.Size = new System.Drawing.Size(298, 23);
            txtPasswordConfirmation.TabIndex = 5;
            //
            // lblError
            //
            lblError.AutoSize = true;
            lblError.ForeColor = System.Drawing.Color.Firebrick;
            lblError.Location = new System.Drawing.Point(3, 198);
            lblError.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            lblError.MaximumSize = new System.Drawing.Size(300, 0);
            lblError.MinimumSize = new System.Drawing.Size(0, 16);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(20, 16);
            lblError.TabIndex = 6;
            //
            // btnReset
            //
            btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            btnReset.BackColor = System.Drawing.Color.FromArgb(79, 55, 138);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(61, 40, 110);
            btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReset.ForeColor = System.Drawing.Color.White;
            btnReset.Location = new System.Drawing.Point(3, 226);
            btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 16);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(298, 40);
            btnReset.TabIndex = 7;
            btnReset.Text = "Resetar senha";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += new System.EventHandler(btnReset_Click);
            //
            // ResetPasswordForm
            //
            AcceptButton = btnReset;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 560);
            Controls.Add(pnlForm);
            Controls.Add(brandPanel);
            MinimumSize = new System.Drawing.Size(700, 480);
            Name = "ResetPasswordForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "TaskFlow - Resetar senha";
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            tableForm.ResumeLayout(false);
            tableForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
