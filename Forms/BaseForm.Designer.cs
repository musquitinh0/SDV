namespace SDV.Forms
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            labelTitle = new Label();
            pictureBox1 = new PictureBox();
            buttonMinimize = new Button();
            buttonMaximize = new Button();
            buttonClose = new Button();
            contentPanel = new Panel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTop.BackColor = Color.FromArgb(41, 41, 41);
            panelTop.Controls.Add(labelTitle);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Controls.Add(buttonMinimize);
            panelTop.Controls.Add(buttonMaximize);
            panelTop.Controls.Add(buttonClose);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1200, 25);
            panelTop.TabIndex = 2;
            panelTop.MouseDown += PanelTopMouseDown;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelTitle.ForeColor = SystemColors.ControlLight;
            labelTitle.Location = new Point(66, 0);
            labelTitle.Margin = new Padding(3);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new Padding(0, 3, 0, 3);
            labelTitle.Size = new Size(40, 26);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Title";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.TitleIcon1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 25);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.FromArgb(41, 41, 41);
            buttonMinimize.Dock = DockStyle.Right;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 45, 45);
            buttonMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.ForeColor = SystemColors.ControlLightLight;
            buttonMinimize.Location = new Point(1095, 0);
            buttonMinimize.Margin = new Padding(10, 3, 10, 3);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(35, 25);
            buttonMinimize.TabIndex = 5;
            buttonMinimize.Text = "➖";
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += ButtonMinimize_Click;
            // 
            // buttonMaximize
            // 
            buttonMaximize.BackColor = Color.FromArgb(41, 41, 41);
            buttonMaximize.Dock = DockStyle.Right;
            buttonMaximize.FlatAppearance.BorderSize = 0;
            buttonMaximize.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 45, 45);
            buttonMaximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            buttonMaximize.FlatStyle = FlatStyle.Flat;
            buttonMaximize.ForeColor = SystemColors.ControlLightLight;
            buttonMaximize.Location = new Point(1130, 0);
            buttonMaximize.Margin = new Padding(10, 3, 10, 3);
            buttonMaximize.Name = "buttonMaximize";
            buttonMaximize.Size = new Size(35, 25);
            buttonMaximize.TabIndex = 4;
            buttonMaximize.Text = "❐";
            buttonMaximize.UseVisualStyleBackColor = false;
            buttonMaximize.Click += ButtonMaximize_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.FromArgb(41, 41, 41);
            buttonClose.Dock = DockStyle.Right;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 45, 45);
            buttonClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.ForeColor = SystemColors.ControlLightLight;
            buttonClose.Location = new Point(1165, 0);
            buttonClose.Margin = new Padding(10, 3, 3, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(35, 25);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "✕";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += ButtonClose_Click;
            // 
            // contentPanel
            // 
            contentPanel.Location = new Point(4, 25);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1196, 576);
            contentPanel.TabIndex = 3;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(1200, 700);
            Controls.Add(contentPanel);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(400, 300);
            Name = "BaseForm";
            Text = "BaseForm";
            Resize += BaseForm_Resize;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonClose;
        private PictureBox pictureBox1;
        private Button buttonMaximize;
        private Button buttonMinimize;
        private Label labelTitle;
        protected Panel panelTop;
        protected Panel contentPanel;
    }
}