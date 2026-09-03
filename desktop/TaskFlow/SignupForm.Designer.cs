namespace TaskFlow
{
    partial class SignupForm
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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.FlowLayoutPanel flowStrengthBars;
        private System.Windows.Forms.Panel pnlBar1;
        private System.Windows.Forms.Panel pnlBar2;
        private System.Windows.Forms.Panel pnlBar3;
        private System.Windows.Forms.Panel pnlBar4;
        private System.Windows.Forms.Label lblStrengthHint;
        private System.Windows.Forms.Label lblPasswordConfirmation;
        private System.Windows.Forms.TextBox txtPasswordConfirmation;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.FlowLayoutPanel flowLoginRow;
        private System.Windows.Forms.Label lblHasAccount;
        private System.Windows.Forms.LinkLabel lnkLogin;

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
            lblName = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            flowStrengthBars = new System.Windows.Forms.FlowLayoutPanel();
            pnlBar1 = new System.Windows.Forms.Panel();
            pnlBar2 = new System.Windows.Forms.Panel();
            pnlBar3 = new System.Windows.Forms.Panel();
            pnlBar4 = new System.Windows.Forms.Panel();
            lblStrengthHint = new System.Windows.Forms.Label();
            lblPasswordConfirmation = new System.Windows.Forms.Label();
            txtPasswordConfirmation = new System.Windows.Forms.TextBox();
            lblError = new System.Windows.Forms.Label();
            btnSignup = new System.Windows.Forms.Button();
            flowLoginRow = new System.Windows.Forms.FlowLayoutPanel();
            lblHasAccount = new System.Windows.Forms.Label();
            lnkLogin = new System.Windows.Forms.LinkLabel();
            pnlBrand.SuspendLayout();
            pnlStats.SuspendLayout();
            tableStats.SuspendLayout();
            flowStat1.SuspendLayout();
            flowStat2.SuspendLayout();
            pnlForm.SuspendLayout();
            tableForm.SuspendLayout();
            flowStrengthBars.SuspendLayout();
            flowLoginRow.SuspendLayout();
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
            pnlBrand.Size = new System.Drawing.Size(300, 640);
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
            pnlStats.Location = new System.Drawing.Point(28, 564);
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
            pnlForm.Padding = new System.Windows.Forms.Padding(48, 40, 48, 24);
            pnlForm.Size = new System.Drawing.Size(400, 640);
            pnlForm.TabIndex = 1;
            //
            // tableForm
            //
            tableForm.AutoSize = true;
            tableForm.ColumnCount = 1;
            tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableForm.Controls.Add(lblTitle, 0, 0);
            tableForm.Controls.Add(lblSubtitle, 0, 1);
            tableForm.Controls.Add(lblName, 0, 2);
            tableForm.Controls.Add(txtName, 0, 3);
            tableForm.Controls.Add(lblEmail, 0, 4);
            tableForm.Controls.Add(txtEmail, 0, 5);
            tableForm.Controls.Add(lblPassword, 0, 6);
            tableForm.Controls.Add(txtPassword, 0, 7);
            tableForm.Controls.Add(flowStrengthBars, 0, 8);
            tableForm.Controls.Add(lblStrengthHint, 0, 9);
            tableForm.Controls.Add(lblPasswordConfirmation, 0, 10);
            tableForm.Controls.Add(txtPasswordConfirmation, 0, 11);
            tableForm.Controls.Add(lblError, 0, 12);
            tableForm.Controls.Add(btnSignup, 0, 13);
            tableForm.Controls.Add(flowLoginRow, 0, 14);
            tableForm.Dock = System.Windows.Forms.DockStyle.Top;
            tableForm.Location = new System.Drawing.Point(48, 40);
            tableForm.Name = "tableForm";
            tableForm.RowCount = 15;
            for (int i = 0; i < 15; i++)
            {
                tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            }
            tableForm.Size = new System.Drawing.Size(304, 560);
            tableForm.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(3, 0);
            lblTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            lblTitle.MaximumSize = new System.Drawing.Size(300, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(260, 56);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Crie sua conta no TaskFlow";
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            lblSubtitle.Location = new System.Drawing.Point(3, 60);
            lblSubtitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            lblSubtitle.MaximumSize = new System.Drawing.Size(300, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(290, 45);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Junte-se a milhares de equipes e comece a organizar seus projetos hoje mesmo.";
            //
            // lblName
            //
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblName.Location = new System.Drawing.Point(3, 117);
            lblName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(96, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Nome Completo";
            //
            // txtName
            //
            txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            txtName.Location = new System.Drawing.Point(3, 136);
            txtName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Seu nome";
            txtName.Size = new System.Drawing.Size(298, 23);
            txtName.TabIndex = 3;
            //
            // lblEmail
            //
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblEmail.Location = new System.Drawing.Point(3, 171);
            lblEmail.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(112, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email Corporativo";
            //
            // txtEmail
            //
            txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            txtEmail.Location = new System.Drawing.Point(3, 190);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "nome@empresa.com";
            txtEmail.Size = new System.Drawing.Size(298, 23);
            txtEmail.TabIndex = 5;
            //
            // lblPassword
            //
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPassword.Location = new System.Drawing.Point(3, 225);
            lblPassword.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(41, 15);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Senha";
            //
            // txtPassword
            //
            txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            txtPassword.Location = new System.Drawing.Point(3, 244);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "********";
            txtPassword.Size = new System.Drawing.Size(298, 23);
            txtPassword.TabIndex = 7;
            txtPassword.TextChanged += new System.EventHandler(txtPassword_TextChanged);
            //
            // flowStrengthBars
            //
            flowStrengthBars.Controls.Add(pnlBar1);
            flowStrengthBars.Controls.Add(pnlBar2);
            flowStrengthBars.Controls.Add(pnlBar3);
            flowStrengthBars.Controls.Add(pnlBar4);
            flowStrengthBars.Location = new System.Drawing.Point(3, 279);
            flowStrengthBars.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            flowStrengthBars.Name = "flowStrengthBars";
            flowStrengthBars.Size = new System.Drawing.Size(298, 8);
            flowStrengthBars.TabIndex = 8;
            flowStrengthBars.WrapContents = false;
            //
            // pnlBar1
            //
            pnlBar1.BackColor = System.Drawing.Color.Gainsboro;
            pnlBar1.Location = new System.Drawing.Point(0, 0);
            pnlBar1.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            pnlBar1.Name = "pnlBar1";
            pnlBar1.Size = new System.Drawing.Size(70, 8);
            pnlBar1.TabIndex = 0;
            //
            // pnlBar2
            //
            pnlBar2.BackColor = System.Drawing.Color.Gainsboro;
            pnlBar2.Location = new System.Drawing.Point(74, 0);
            pnlBar2.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            pnlBar2.Name = "pnlBar2";
            pnlBar2.Size = new System.Drawing.Size(70, 8);
            pnlBar2.TabIndex = 1;
            //
            // pnlBar3
            //
            pnlBar3.BackColor = System.Drawing.Color.Gainsboro;
            pnlBar3.Location = new System.Drawing.Point(148, 0);
            pnlBar3.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            pnlBar3.Name = "pnlBar3";
            pnlBar3.Size = new System.Drawing.Size(70, 8);
            pnlBar3.TabIndex = 2;
            //
            // pnlBar4
            //
            pnlBar4.BackColor = System.Drawing.Color.Gainsboro;
            pnlBar4.Location = new System.Drawing.Point(222, 0);
            pnlBar4.Margin = new System.Windows.Forms.Padding(0);
            pnlBar4.Name = "pnlBar4";
            pnlBar4.Size = new System.Drawing.Size(70, 8);
            pnlBar4.TabIndex = 3;
            //
            // lblStrengthHint
            //
            lblStrengthHint.AutoSize = true;
            lblStrengthHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            lblStrengthHint.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            lblStrengthHint.Location = new System.Drawing.Point(3, 289);
            lblStrengthHint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 8);
            lblStrengthHint.Name = "lblStrengthHint";
            lblStrengthHint.Size = new System.Drawing.Size(220, 15);
            lblStrengthHint.TabIndex = 9;
            lblStrengthHint.Text = "Digite uma senha forte (mín. 8 caracteres)";
            //
            // lblPasswordConfirmation
            //
            lblPasswordConfirmation.AutoSize = true;
            lblPasswordConfirmation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPasswordConfirmation.Location = new System.Drawing.Point(3, 319);
            lblPasswordConfirmation.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            lblPasswordConfirmation.Name = "lblPasswordConfirmation";
            lblPasswordConfirmation.Size = new System.Drawing.Size(120, 15);
            lblPasswordConfirmation.TabIndex = 10;
            lblPasswordConfirmation.Text = "Confirme a senha";
            //
            // txtPasswordConfirmation
            //
            txtPasswordConfirmation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            txtPasswordConfirmation.Location = new System.Drawing.Point(3, 338);
            txtPasswordConfirmation.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            txtPasswordConfirmation.PasswordChar = '•';
            txtPasswordConfirmation.PlaceholderText = "********";
            txtPasswordConfirmation.Size = new System.Drawing.Size(298, 23);
            txtPasswordConfirmation.TabIndex = 11;
            //
            // lblError
            //
            lblError.AutoSize = true;
            lblError.ForeColor = System.Drawing.Color.Firebrick;
            lblError.Location = new System.Drawing.Point(3, 365);
            lblError.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            lblError.MinimumSize = new System.Drawing.Size(0, 16);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(20, 16);
            lblError.TabIndex = 12;
            //
            // btnSignup
            //
            btnSignup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            btnSignup.BackColor = System.Drawing.Color.FromArgb(79, 55, 138);
            btnSignup.FlatAppearance.BorderSize = 0;
            btnSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(61, 40, 110);
            btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSignup.ForeColor = System.Drawing.Color.White;
            btnSignup.Location = new System.Drawing.Point(3, 393);
            btnSignup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 16);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new System.Drawing.Size(298, 40);
            btnSignup.TabIndex = 13;
            btnSignup.Text = "Cadastre-se";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += new System.EventHandler(btnSignup_Click);
            //
            // flowLoginRow
            //
            flowLoginRow.AutoSize = true;
            flowLoginRow.Controls.Add(lblHasAccount);
            flowLoginRow.Controls.Add(lnkLogin);
            flowLoginRow.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            flowLoginRow.Location = new System.Drawing.Point(3, 457);
            flowLoginRow.Name = "flowLoginRow";
            flowLoginRow.Size = new System.Drawing.Size(190, 21);
            flowLoginRow.TabIndex = 14;
            flowLoginRow.WrapContents = false;
            //
            // lblHasAccount
            //
            lblHasAccount.AutoSize = true;
            lblHasAccount.Location = new System.Drawing.Point(3, 3);
            lblHasAccount.Margin = new System.Windows.Forms.Padding(3, 3, 4, 0);
            lblHasAccount.Name = "lblHasAccount";
            lblHasAccount.Size = new System.Drawing.Size(110, 15);
            lblHasAccount.TabIndex = 0;
            lblHasAccount.Text = "Já tem uma conta?";
            //
            // lnkLogin
            //
            lnkLogin.AutoSize = true;
            lnkLogin.LinkColor = System.Drawing.Color.FromArgb(79, 55, 138);
            lnkLogin.Location = new System.Drawing.Point(117, 3);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new System.Drawing.Size(48, 15);
            lnkLogin.TabIndex = 1;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Entrar";
            lnkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(lnkLogin_LinkClicked);
            //
            // SignupForm
            //
            AcceptButton = btnSignup;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 640);
            Controls.Add(pnlForm);
            Controls.Add(pnlBrand);
            MinimumSize = new System.Drawing.Size(700, 560);
            Name = "SignupForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "TaskFlow - Cadastro";
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
            flowStrengthBars.ResumeLayout(false);
            flowLoginRow.ResumeLayout(false);
            flowLoginRow.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
