using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace SDV.Forms
{
    public partial class MainForm : BaseForm
    {
        private SalesForm? _salesForm;

        //****************************************************************************
        // construtor
        //****************************************************************************
        public MainForm()
        {
            InitializeComponent();
            SetTitle("Sistema de Vendas");
        }

        //****************************************************************************
        // Click no botão de vendas
        //****************************************************************************
        private void ButtonSales_Click(object sender, EventArgs e)
        {
            if (_salesForm == null || _salesForm.IsDisposed)
            {
                _salesForm = new SalesForm();
                _salesForm.Show();
            }
            else
            {
                _salesForm.BringToFront();
                _salesForm.Focus();
            }
        }
    }
}
