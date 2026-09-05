namespace TaskFlow
{
    public class BrandPanel : Panel
    {
        private static readonly Color Purple = Color.FromArgb(79, 55, 138);
        private static readonly Color DividerColor = Color.FromArgb(140, 120, 180);
        private static readonly Color CaptionColor = Color.FromArgb(220, 210, 235);

        public BrandPanel()
        {
            BackColor = Purple;
            Dock = DockStyle.Left;
            Width = 300;

            var lblLogo = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(28, 28),
                Text = "TaskFlow",
            };

            var pnlStats = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 88,
                Padding = new Padding(28, 12, 28, 28),
            };

            var pnlDivider = new Panel
            {
                BackColor = DividerColor,
                Dock = DockStyle.Top,
                Height = 1,
            };

            var tableStats = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
            };
            tableStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableStats.Controls.Add(CreateStat("10k+", "EQUIPES ATIVAS"), 0, 0);
            tableStats.Controls.Add(CreateStat("99.9%", "UPTIME GARANTIDO"), 1, 0);

            pnlStats.Controls.Add(tableStats);
            pnlStats.Controls.Add(pnlDivider);

            Controls.Add(pnlStats);
            Controls.Add(lblLogo);
        }

        private static FlowLayoutPanel CreateStat(string value, string caption)
        {
            var flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
            };

            flow.Controls.Add(new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.White,
                Text = value,
            });

            flow.Controls.Add(new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 7.5F),
                ForeColor = CaptionColor,
                Text = caption,
            });

            return flow;
        }
    }
}
