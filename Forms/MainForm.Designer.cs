namespace SDV.Forms
{
    partial class MainForm : BaseForm
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
            panelToolBox = new Panel();
            buttonSales = new Button();
            panelToolBox.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            contentPanel.Size = new Size(1171, 671);
            // 
            // panelToolBox
            // 
            panelToolBox.BackColor = Color.FromArgb(41, 41, 41);
            panelToolBox.Controls.Add(buttonSales);
            panelToolBox.Dock = DockStyle.Top;
            panelToolBox.Location = new Point(0, 25);
            panelToolBox.Name = "panelToolBox";
            panelToolBox.Padding = new Padding(2);
            panelToolBox.Size = new Size(1200, 25);
            panelToolBox.TabIndex = 8;
            // 
            // buttonSales
            // 
            buttonSales.AutoSize = true;
            buttonSales.BackColor = Color.FromArgb(41, 41, 41);
            buttonSales.Dock = DockStyle.Left;
            buttonSales.FlatAppearance.BorderSize = 0;
            buttonSales.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 45, 45);
            buttonSales.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            buttonSales.FlatStyle = FlatStyle.Flat;
            buttonSales.ForeColor = SystemColors.ControlLightLight;
            buttonSales.Location = new Point(2, 2);
            buttonSales.Margin = new Padding(10, 3, 10, 3);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(54, 21);
            buttonSales.TabIndex = 8;
            buttonSales.Text = "Vendas";
            buttonSales.UseVisualStyleBackColor = false;
            buttonSales.Click += ButtonSales_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelToolBox);
            Name = "MainForm";
            Text = "MainForm";
            Controls.SetChildIndex(panelTop, 0);
            Controls.SetChildIndex(contentPanel, 0);
            Controls.SetChildIndex(panelToolBox, 0);
            panelToolBox.ResumeLayout(false);
            panelToolBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolBox;
        private Button buttonSales;
    }
}