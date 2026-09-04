namespace TaskFlow
{
    partial class LoginForm
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

        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.TableLayoutPanel tableStats;
        private System.Windows.Forms.FlowLayoutPanel flowStat1;
        private System.Windows.Forms.Label lblStat1Value;
        private System.Windows.Forms.Label lblStat1Caption;
        private System.Windows.Forms.FlowLayoutPanel flowStat2;
        private System.Windows.Forms.Label lblStat2Value;
        private System.Windows.Forms.Label lblStat2Caption;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.TableLayoutPanel tableForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TableLayoutPanel tablePasswordHeader;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.FlowLayoutPanel flowSignupRow;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.LinkLabel lnkSignup;

        private void InitializeComponent()
        {
            pnlBrand = new System.Windows.Forms.Panel();
            lblLogo = new System.Windows.Forms.Label();
            pnlStats = new System.Windows.Forms.Panel();
            pnlDivider = new System.Windows.Forms.Panel();
            tableStats = new System.Windows.Forms.TableLayoutPanel();
            flowStat1 = new System.Windows.Forms.FlowLayoutPanel();
            lblStat1Value = new System.Windows.Forms.Label();
            lblStat1Caption = new System.Windows.Forms.Label();
            flowStat2 = new System.Windows.Forms.FlowLayoutPanel();
            lblStat2Value = new System.Windows.Forms.Label();
            lblStat2Caption = new System.Windows.Forms.Label();
            pnlForm = new System.Windows.Forms.Panel();
            tableForm = new System.Windows.Forms.TableLayoutPanel();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            tablePasswordHeader = new System.Windows.Forms.TableLayoutPanel();
            lblPassword = new System.Windows.Forms.Label();
            lnkForgotPassword = new System.Windows.Forms.LinkLabel();
            txtPassword = new System.Windows.Forms.TextBox();
            lblError = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            flowSignupRow = new System.Windows.Forms.FlowLayoutPanel();
            lblNoAccount = new System.Windows.Forms.Label();
            lnkSignup = new System.Windows.Forms.LinkLabel();
            pnlBrand.SuspendLayout();
            pnlStats.SuspendLayout();
            tableStats.SuspendLayout();
            flowStat1.SuspendLayout();
            flowStat2.SuspendLayout();
            pnlForm.SuspendLayout();
            tableForm.SuspendLayout();
            tablePasswordHeader.SuspendLayout();
            flowSignupRow.SuspendLayout();
            SuspendLayout();
            //
            // pnlBrand
            //
            pnlBrand.BackColor = System.Drawing.Color.FromArgb(79, 55, 138);
            pnlBrand.Controls.Add(pnlStats);
            pnlBrand.Controls.Add(lblLogo);
            pnlBrand.Dock = System.Windows.Forms.DockStyle.Left;
            pnlBrand.Location = new System.Drawing.Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new System.Drawing.Size(300, 560);
            pnlBrand.TabIndex = 0;
            //
            // lblLogo
            //
            lblLogo.AutoSize = true;
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblLogo.ForeColor = System.Drawing.Color.White;
            lblLogo.Location = new System.Drawing.Point(28, 28);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(100, 32);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "TaskFlow";
            //
            // pnlStats
            //
            pnlStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            pnlStats.Controls.Add(tableStats);
            pnlStats.Controls.Add(pnlDivider);
            pnlStats.Location = new System.Drawing.Point(28, 484);
            pnlStats.Name = "pnlStats";
            pnlStats.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            pnlStats.Size = new System.Drawing.Size(244, 60);
            pnlStats.TabIndex = 1;
            //
            // pnlDivider
            //
            pnlDivider.BackColor = System.Drawing.Color.FromArgb(140, 120, 180);
            pnlDivider.Dock = System.Windows.Forms.DockStyle.Top;
            pnlDivider.Location = new System.Drawing.Point(0, 12);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new System.Drawing.Size(244, 1);
            pnlDivider.TabIndex = 0;
            //
            // tableStats
            //
            tableStats.ColumnCount = 2;
            tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableStats.Controls.Add(flowStat1, 0, 0);
            tableStats.Controls.Add(flowStat2, 1, 0);
            tableStats.Dock = System.Windows.Forms.DockStyle.Fill;
            tableStats.Location = new System.Drawing.Point(0, 13);
            tableStats.Name = "tableStats";
            tableStats.RowCount = 1;
            tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableStats.Size = new System.Drawing.Size(244, 47);
            tableStats.TabIndex = 1;
            //
            // flowStat1
            //
            flowStat1.Controls.Add(lblStat1Value);
            flowStat1.Controls.Add(lblStat1Caption);
            flowStat1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowStat1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowStat1.Location = new System.Drawing.Point(3, 3);
            flowStat1.Name = "flowStat1";
            flowStat1.Size = new System.Drawing.Size(116, 41);
            flowStat1.TabIndex = 0;
            flowStat1.WrapContents = false;
            //
            // lblStat1Value
            //
            lblStat1Value.AutoSize = true;
            lblStat1Value.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblStat1Value.ForeColor = System.Drawing.Color.White;
            lblStat1Value.Location = new System.Drawing.Point(3, 0);
            lblStat1Value.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            lblStat1Value.Name = "lblStat1Value";
            lblStat1Value.Size = new System.Drawing.Size(50, 24);
            lblStat1Value.TabIndex = 0;
            lblStat1Value.Text = "10k+";
            //
            // lblStat1Caption
            //
            lblStat1Caption.AutoSize = true;
            lblStat1Caption.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            lblStat1Caption.ForeColor = System.Drawing.Color.FromArgb(220, 210, 235);
            lblStat1Caption.Location = new System.Drawing.Point(3, 24);
            lblStat1Caption.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            lblStat1Caption.Name = "lblStat1Caption";
            lblStat1Caption.Size = new System.Drawing.Size(90, 15);
            lblStat1Caption.TabIndex = 1;
            lblStat1Caption.Text = "EQUIPES ATIVAS";
            //
            // flowStat2
            //
            flowStat2.Controls.Add(lblStat2Value);
            flowStat2.Controls.Add(lblStat2Caption);
            flowStat2.Dock = System.Windows.Forms.DockStyle.Fill;
            flowStat2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowStat2.Location = new System.Drawing.Point(125, 3);
            flowStat2.Name = "flowStat2";
            flowStat2.Size = new System.Drawing.Size(116, 41);
            flowStat2.TabIndex = 1;
            flowStat2.WrapContents = false;
            //
            // lblStat2Value
            //
            lblStat2Value.AutoSize = true;
            lblStat2Value.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblStat2Value.ForeColor = System.Drawing.Color.White;
            lblStat2Value.Location = new System.Drawing.Point(3, 0);
            lblStat2Value.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            lblStat2Value.Name = "lblStat2Value";
            lblStat2Value.Size = new System.Drawing.Size(60, 24);
            lblStat2Value.TabIndex = 0;
            lblStat2Value.Text = "99.9%";
            //
            // lblStat2Caption
            //
            lblStat2Caption.AutoSize = true;
            lblStat2Caption.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            lblStat2Caption.ForeColor = System.Drawing.Color.FromArgb(220, 210, 235);
            lblStat2Caption.Location = new System.Drawing.Point(3, 24);
            lblStat2Caption.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            lblStat2Caption.Name = "lblStat2Caption";
            lblStat2Caption.Size = new System.Drawing.Size(100, 15);
            lblStat2Caption.TabIndex = 1;
            lblStat2Caption.Text = "UPTIME GARANTIDO";
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
            tableForm.Controls.Add(tablePasswordHeader, 0, 4);
            tableForm.Controls.Add(txtPassword, 0, 5);
            tableForm.Controls.Add(lblError, 0, 6);
            tableForm.Controls.Add(btnLogin, 0, 7);
            tableForm.Controls.Add(flowSignupRow, 0, 8);
            tableForm.Dock = System.Windows.Forms.DockStyle.Top;
            tableForm.Location = new System.Drawing.Point(48, 56);
            tableForm.Name = "tableForm";
            tableForm.RowCount = 9;
            tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableForm.Size = new System.Drawing.Size(304, 402);
            tableForm.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(3, 0);
            lblTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(220, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bem-vindo de volta";
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            lblSubtitle.Location = new System.Drawing.Point(3, 40);
            lblSubtitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 16);
            lblSubtitle.MaximumSize = new System.Drawing.Size(300, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(280, 30);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Acesse sua conta para continuar gerenciando seus projetos.";
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
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "nome@empresa.com";
            txtEmail.Size = new System.Drawing.Size(298, 23);
            txtEmail.TabIndex = 3;
            //
            // tablePasswordHeader
            //
            tablePasswordHeader.AutoSize = true;
            tablePasswordHeader.ColumnCount = 2;
            tablePasswordHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablePasswordHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablePasswordHeader.Controls.Add(lblPassword, 0, 0);
            tablePasswordHeader.Controls.Add(lnkForgotPassword, 1, 0);
            tablePasswordHeader.Dock = System.Windows.Forms.DockStyle.Top;
            tablePasswordHeader.Location = new System.Drawing.Point(3, 148);
            tablePasswordHeader.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            tablePasswordHeader.Name = "tablePasswordHeader";
            tablePasswordHeader.RowCount = 1;
            tablePasswordHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tablePasswordHeader.Size = new System.Drawing.Size(298, 19);
            tablePasswordHeader.TabIndex = 4;
            //
            // lblPassword
            //
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPassword.Location = new System.Drawing.Point(3, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(41, 15);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Senha";
            //
            // lnkForgotPassword
            //
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Dock = System.Windows.Forms.DockStyle.Right;
            lnkForgotPassword.LinkColor = System.Drawing.Color.FromArgb(79, 55, 138);
            lnkForgotPassword.Location = new System.Drawing.Point(149, 0);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new System.Drawing.Size(146, 15);
            lnkForgotPassword.TabIndex = 1;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Esqueci minha senha";
            lnkForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lnkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(lnkForgotPassword_LinkClicked);
            //
            // txtPassword
            //
            txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            txtPassword.Location = new System.Drawing.Point(3, 171);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "********";
            txtPassword.Size = new System.Drawing.Size(298, 23);
            txtPassword.TabIndex = 5;
            //
            // lblError
            //
            lblError.AutoSize = true;
            lblError.ForeColor = System.Drawing.Color.Firebrick;
            lblError.Location = new System.Drawing.Point(3, 198);
            lblError.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            lblError.MinimumSize = new System.Drawing.Size(0, 16);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(20, 16);
            lblError.TabIndex = 6;
            //
            // btnLogin
            //
            btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            btnLogin.BackColor = System.Drawing.Color.FromArgb(79, 55, 138);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(61, 40, 110);
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(3, 226);
            btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 16);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(298, 40);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += new System.EventHandler(btnLogin_Click);
            //
            // flowSignupRow
            //
            flowSignupRow.AutoSize = true;
            flowSignupRow.Controls.Add(lblNoAccount);
            flowSignupRow.Controls.Add(lnkSignup);
            flowSignupRow.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            flowSignupRow.Location = new System.Drawing.Point(3, 290);
            flowSignupRow.Name = "flowSignupRow";
            flowSignupRow.Size = new System.Drawing.Size(220, 21);
            flowSignupRow.TabIndex = 8;
            flowSignupRow.WrapContents = false;
            //
            // lblNoAccount
            //
            lblNoAccount.AutoSize = true;
            lblNoAccount.Location = new System.Drawing.Point(3, 3);
            lblNoAccount.Margin = new System.Windows.Forms.Padding(3, 3, 4, 0);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new System.Drawing.Size(120, 15);
            lblNoAccount.TabIndex = 0;
            lblNoAccount.Text = "Não tem uma conta?";
            //
            // lnkSignup
            //
            lnkSignup.AutoSize = true;
            lnkSignup.LinkColor = System.Drawing.Color.FromArgb(79, 55, 138);
            lnkSignup.Location = new System.Drawing.Point(127, 3);
            lnkSignup.Name = "lnkSignup";
            lnkSignup.Size = new System.Drawing.Size(74, 15);
            lnkSignup.TabIndex = 1;
            lnkSignup.TabStop = true;
            lnkSignup.Text = "Cadastre-se";
            lnkSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(lnkSignup_LinkClicked);
            //
            // LoginForm
            //
            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 560);
            Controls.Add(pnlForm);
            Controls.Add(pnlBrand);
            MinimumSize = new System.Drawing.Size(700, 480);
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "TaskFlow - Login";
            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            pnlStats.ResumeLayout(false);
            tableStats.ResumeLayout(false);
            flowStat1.ResumeLayout(false);
            flowStat1.PerformLayout();
            flowStat2.ResumeLayout(false);
            flowStat2.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            tableForm.ResumeLayout(false);
            tableForm.PerformLayout();
            tablePasswordHeader.ResumeLayout(false);
            tablePasswordHeader.PerformLayout();
            flowSignupRow.ResumeLayout(false);
            flowSignupRow.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
