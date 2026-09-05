namespace TaskFlow
{
    partial class VerifyOtpForm
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
        private System.Windows.Forms.Label lblOtp;
        private System.Windows.Forms.TextBox txtOtp;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.LinkLabel lnkResend;

        private void InitializeComponent()
        {
            brandPanel = new BrandPanel();
            pnlForm = new System.Windows.Forms.Panel();
            tableForm = new System.Windows.Forms.TableLayoutPanel();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblOtp = new System.Windows.Forms.Label();
            txtOtp = new System.Windows.Forms.TextBox();
            lblError = new System.Windows.Forms.Label();
            btnVerify = new System.Windows.Forms.Button();
            lnkResend = new System.Windows.Forms.LinkLabel();
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
            tableForm.Controls.Add(lblOtp, 0, 2);
            tableForm.Controls.Add(txtOtp, 0, 3);
            tableForm.Controls.Add(lblError, 0, 4);
            tableForm.Controls.Add(btnVerify, 0, 5);
            tableForm.Controls.Add(lnkResend, 0, 6);
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
            lblTitle.Size = new System.Drawing.Size(240, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Verifique seu código";
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
            lblSubtitle.Text = "Digite o código de 6 dígitos que enviamos para seu email.";
            //
            // lblOtp
            //
            lblOtp.AutoSize = true;
            lblOtp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblOtp.Location = new System.Drawing.Point(3, 90);
            lblOtp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            lblOtp.Name = "lblOtp";
            lblOtp.Size = new System.Drawing.Size(75, 15);
            lblOtp.TabIndex = 2;
            lblOtp.Text = "Código OTP";
            //
            // txtOtp
            //
            txtOtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            txtOtp.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtOtp.Location = new System.Drawing.Point(3, 109);
            txtOtp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            txtOtp.MaxLength = 6;
            txtOtp.Name = "txtOtp";
            txtOtp.PlaceholderText = "000000";
            txtOtp.Size = new System.Drawing.Size(298, 29);
            txtOtp.TabIndex = 3;
            txtOtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtOtp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtOtp_KeyPress);
            //
            // lblError
            //
            lblError.AutoSize = true;
            lblError.ForeColor = System.Drawing.Color.Firebrick;
            lblError.Location = new System.Drawing.Point(3, 146);
            lblError.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            lblError.MaximumSize = new System.Drawing.Size(300, 0);
            lblError.MinimumSize = new System.Drawing.Size(0, 16);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(20, 16);
            lblError.TabIndex = 4;
            //
            // btnVerify
            //
            btnVerify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            btnVerify.BackColor = System.Drawing.Color.FromArgb(79, 55, 138);
            btnVerify.FlatAppearance.BorderSize = 0;
            btnVerify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(61, 40, 110);
            btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVerify.ForeColor = System.Drawing.Color.White;
            btnVerify.Location = new System.Drawing.Point(3, 174);
            btnVerify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 16);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new System.Drawing.Size(298, 40);
            btnVerify.TabIndex = 5;
            btnVerify.Text = "Verificar OTP";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += new System.EventHandler(btnVerify_Click);
            //
            // lnkResend
            //
            lnkResend.AutoSize = true;
            lnkResend.LinkColor = System.Drawing.Color.FromArgb(79, 55, 138);
            lnkResend.Location = new System.Drawing.Point(3, 238);
            lnkResend.Name = "lnkResend";
            lnkResend.Size = new System.Drawing.Size(140, 15);
            lnkResend.TabIndex = 6;
            lnkResend.TabStop = true;
            lnkResend.Text = "Não recebeu o código?";
            lnkResend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(lnkResend_LinkClicked);
            //
            // VerifyOtpForm
            //
            AcceptButton = btnVerify;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 560);
            Controls.Add(pnlForm);
            Controls.Add(brandPanel);
            MinimumSize = new System.Drawing.Size(700, 480);
            Name = "VerifyOtpForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "TaskFlow - Verificar OTP";
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            tableForm.ResumeLayout(false);
            tableForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
