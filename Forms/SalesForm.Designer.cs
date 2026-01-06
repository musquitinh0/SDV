namespace SDV.Forms
{
    partial class SalesForm : BaseForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelLeft = new Panel();
            label1 = new Label();
            textBoxQuantity = new TextBox();
            labelShortcuts = new Label();
            BarCodeText = new TextBox();
            pictureBox2 = new PictureBox();
            panelRight = new Panel();
            panel1 = new Panel();
            labelTotal = new Label();
            textBoxTotal = new TextBox();
            CartGrid = new DataGridView();
            contentPanel.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelRight.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CartGrid).BeginInit();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(panelRight);
            contentPanel.Controls.Add(panelLeft);
            contentPanel.Padding = new Padding(5);
            contentPanel.Size = new Size(1193, 671);
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(61, 61, 61);
            panelLeft.Controls.Add(label1);
            panelLeft.Controls.Add(textBoxQuantity);
            panelLeft.Controls.Add(labelShortcuts);
            panelLeft.Controls.Add(BarCodeText);
            panelLeft.Controls.Add(pictureBox2);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(5, 5);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(10);
            panelLeft.Size = new Size(400, 661);
            panelLeft.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(103, 613);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 7;
            label1.Text = "X";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxQuantity.BackColor = Color.FromArgb(75, 75, 75);
            textBoxQuantity.BorderStyle = BorderStyle.FixedSingle;
            textBoxQuantity.Cursor = Cursors.IBeam;
            textBoxQuantity.Font = new Font("Segoe UI", 24F);
            textBoxQuantity.ForeColor = Color.White;
            textBoxQuantity.Location = new Point(10, 598);
            textBoxQuantity.MaxLength = 5;
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(87, 50);
            textBoxQuantity.TabIndex = 6;
            textBoxQuantity.Text = "1";
            textBoxQuantity.TextAlign = HorizontalAlignment.Center;
            textBoxQuantity.KeyPress += TextBoxQuantity_KeyPress;
            // 
            // labelShortcuts
            // 
            labelShortcuts.AutoSize = true;
            labelShortcuts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelShortcuts.ForeColor = SystemColors.ButtonFace;
            labelShortcuts.Location = new Point(13, 402);
            labelShortcuts.Name = "labelShortcuts";
            labelShortcuts.Size = new Size(166, 60);
            labelShortcuts.TabIndex = 5;
            labelShortcuts.Text = "F1 - Pesquisar produto\r\nF2 - Alterar quantidade\r\nF3 - Selecionar a Tabela\r\n";
            // 
            // BarCodeText
            // 
            BarCodeText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BarCodeText.BackColor = Color.FromArgb(75, 75, 75);
            BarCodeText.BorderStyle = BorderStyle.FixedSingle;
            BarCodeText.Cursor = Cursors.IBeam;
            BarCodeText.Font = new Font("Segoe UI", 24F);
            BarCodeText.ForeColor = Color.White;
            BarCodeText.Location = new Point(128, 598);
            BarCodeText.MaxLength = 13;
            BarCodeText.Name = "BarCodeText";
            BarCodeText.Size = new Size(239, 50);
            BarCodeText.TabIndex = 2;
            BarCodeText.TextAlign = HorizontalAlignment.Center;
            BarCodeText.KeyPress += BarCodeText_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = Properties.Resources.CompanyLogo;
            pictureBox2.Location = new Point(10, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(380, 380);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(panel1);
            panelRight.Controls.Add(CartGrid);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(405, 5);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(783, 661);
            panelRight.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTotal);
            panel1.Controls.Add(textBoxTotal);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 561);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 100);
            panel1.TabIndex = 1;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 16F);
            labelTotal.ForeColor = SystemColors.ButtonFace;
            labelTotal.Location = new Point(554, 37);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(59, 30);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "Total";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxTotal.BackColor = Color.FromArgb(75, 75, 75);
            textBoxTotal.BorderStyle = BorderStyle.FixedSingle;
            textBoxTotal.Cursor = Cursors.IBeam;
            textBoxTotal.Font = new Font("Segoe UI", 18F);
            textBoxTotal.ForeColor = Color.White;
            textBoxTotal.Location = new Point(619, 33);
            textBoxTotal.MaxLength = 13;
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(152, 39);
            textBoxTotal.TabIndex = 3;
            textBoxTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // CartGrid
            // 
            CartGrid.AllowUserToAddRows = false;
            CartGrid.AllowUserToDeleteRows = false;
            CartGrid.AllowUserToResizeColumns = false;
            CartGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(120, 120, 120);
            CartGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CartGrid.BackgroundColor = Color.FromArgb(65, 65, 65);
            CartGrid.BorderStyle = BorderStyle.None;
            CartGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(65, 65, 65);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(65, 65, 65);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CartGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CartGrid.ColumnHeadersHeight = 22;
            CartGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(120, 120, 120);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CartGrid.DefaultCellStyle = dataGridViewCellStyle3;
            CartGrid.Dock = DockStyle.Fill;
            CartGrid.EnableHeadersVisualStyles = false;
            CartGrid.Location = new Point(0, 0);
            CartGrid.Name = "CartGrid";
            CartGrid.ReadOnly = true;
            CartGrid.Size = new Size(783, 661);
            CartGrid.TabIndex = 0;
            CartGrid.KeyDown += CartGrid_KeyDown;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Name = "SalesForm";
            Text = "SalesForm";
            KeyDown += SalesForm_KeyDown;
            contentPanel.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelRight.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CartGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private PictureBox pictureBox2;
        private TextBox BarCodeText;
        private Panel panelRight;
        private Panel panel1;
        private DataGridView CartGrid;
        private Label labelTotal;
        private TextBox textBoxTotal;
        private TextBox textBoxQuantity;
        private Label labelShortcuts;
        private Label label1;
    }
}