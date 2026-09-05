namespace TaskFlow
{
    partial class ForgotPasswordForm
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
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.LinkLabel lnkBackToLogin;

        private void InitializeComponent()
        {
            brandPanel = new BrandPanel();
            pnlForm = new System.Windows.Forms.Panel();
            tableForm = new System.Windows.Forms.TableLayoutPanel();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblError = new System.Windows.Forms.Label();
            btnSend = new System.Windows.Forms.Button();
            lnkBackToLogin = new System.Windows.Forms.LinkLabel();
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
            tableForm.Controls.Add(lblEmail, 0, 2);
            tableForm.Controls.Add(txtEmail, 0, 3);
            tableForm.Controls.Add(lblError, 0, 4);
            tableForm.Controls.Add(btnSend, 0, 5);
            tableForm.Controls.Add(lnkBackToLogin, 0, 6);
            tableForm.Dock = System.Windows.Forms.DockStyle.Top;
            tableForm.Location = new System.Drawing.Point(48, 56);
            tableForm.Name = "tableForm";
            tableForm.RowCount = 7;
            for (int i = 0; i < 7; i++)
            {
                tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            }
            tableForm.Size = new System.Drawing.Size(304, 260);
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
            lblTitle.Text = "Esqueceu sua senha?";
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
            lblSubtitle.Text = "Digite seu email e enviaremos um código de verificação.";
            //
            // lblEmail
            //
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblEmail.Location = new System.Drawing.Point(3, 90);
            lblEmail.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(112, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email Corporativo";
            //
            // txtEmail
            //
            txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            txtEmail.Location = new System.Drawing.Point(3, 109);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "nome@empresa.com";
            txtEmail.Size = new System.Drawing.Size(298, 23);
            txtEmail.TabIndex = 3;
            //
            // lblError
            //
            lblError.AutoSize = true;
            lblError.ForeColor = System.Drawing.Color.Firebrick;
            lblError.Location = new System.Drawing.Point(3, 140);
            lblError.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            lblError.MaximumSize = new System.Drawing.Size(300, 0);
            lblError.MinimumSize = new System.Drawing.Size(0, 16);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(20, 16);
            lblError.TabIndex = 4;
            //
            // btnSend
            //
            btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            btnSend.BackColor = System.Drawing.Color.FromArgb(79, 55, 138);
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(61, 40, 110);
            btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSend.ForeColor = System.Drawing.Color.White;
            btnSend.Location = new System.Drawing.Point(3, 168);
            btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 16);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(298, 40);
            btnSend.TabIndex = 5;
            btnSend.Text = "Enviar OTP";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += new System.EventHandler(btnSend_Click);
            //
            // lnkBackToLogin
            //
            lnkBackToLogin.AutoSize = true;
            lnkBackToLogin.LinkColor = System.Drawing.Color.FromArgb(79, 55, 138);
            lnkBackToLogin.Location = new System.Drawing.Point(3, 232);
            lnkBackToLogin.Name = "lnkBackToLogin";
            lnkBackToLogin.Size = new System.Drawing.Size(120, 15);
            lnkBackToLogin.TabIndex = 6;
            lnkBackToLogin.TabStop = true;
            lnkBackToLogin.Text = "Voltar para o login";
            lnkBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(lnkBackToLogin_LinkClicked);
            //
            // ForgotPasswordForm
            //
            AcceptButton = btnSend;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 560);
            Controls.Add(pnlForm);
            Controls.Add(brandPanel);
            MinimumSize = new System.Drawing.Size(700, 480);
            Name = "ForgotPasswordForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "TaskFlow - Esqueci minha senha";
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            tableForm.ResumeLayout(false);
            tableForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
