using SDV.Models;
using SDV.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace SDV.Forms
{
  public partial class SalesForm : BaseForm
  {
    private readonly BindingList<CartItem> _cartItems = [];

    //****************************************************************************
    // Construtor
    //****************************************************************************
    public SalesForm()
    {
      InitializeComponent();
      SetTitle("Vendas");
      ConfigureGrid();
      this.KeyPreview = true;
      ToggleMaximize();
    }

    //****************************************************************************
    // Configurar o grid
    //****************************************************************************
    private void ConfigureGrid()
    {
      CartGrid.AutoGenerateColumns = false;
      CartGrid.DataSource = _cartItems;

      CartGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      CartGrid.MultiSelect = false;
      CartGrid.ReadOnly = true;
      CartGrid.AllowUserToAddRows = false;
      CartGrid.AllowUserToResizeRows = false;
      CartGrid.RowHeadersVisible = false;

      CartGrid.Columns.Add(new DataGridViewTextBoxColumn
      {
        HeaderText = "Código",
        DataPropertyName = "id",
        Width = 90
      });

      CartGrid.Columns.Add(new DataGridViewTextBoxColumn
      {
        HeaderText = "Nome",
        DataPropertyName = "Name",
        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
      });

      CartGrid.Columns.Add(new DataGridViewTextBoxColumn
      {
        HeaderText = "Qtd",
        DataPropertyName = "Quantidade",
        Width = 60,
        DefaultCellStyle = new DataGridViewCellStyle
        {
          Format = "F3",
          FormatProvider = new CultureInfo("pt-BR")
        }
      });

      CartGrid.Columns.Add(new DataGridViewTextBoxColumn
      {
        HeaderText = "Preço",
        DataPropertyName = "Price",
        Width = 90,
        DefaultCellStyle = new DataGridViewCellStyle
        {
          Format = "C2",
          FormatProvider = new CultureInfo("pt-BR")
        }
      });

      CartGrid.Columns.Add(new DataGridViewTextBoxColumn
      {
        HeaderText = "Total",
        DataPropertyName = "Total",
        Width = 90,
        DefaultCellStyle = new DataGridViewCellStyle
        {
          Format = "C2",
          FormatProvider = new CultureInfo("pt-BR")
        }
      });
    }

    //****************************************************************************
    // Adiciona Item
    //****************************************************************************
    private void AddItem(Product product, decimal quantidade)
    {
      var existing = _cartItems.FirstOrDefault(i => i.Id == product.Id);

      if (existing != null)
      {
        existing.Quantidade += quantidade;
        CartGrid.Refresh();
      }
      else
      {
        _cartItems.Add(new CartItem
        {
          Id = product.Id,
          Name = product.Name,
          Quantidade = quantidade,
          Price = product.Price,
        });

      }
      UpdateTotal();
    }

    //****************************************************************************
    // Atualiza o total da compra
    //****************************************************************************
    private void UpdateTotal()
    {
      decimal total = 0;
      foreach (var item in _cartItems)
        total += item.Quantidade * item.Price;

      textBoxTotal.Text = total.ToString("C2", new CultureInfo("pt-BR")) + " ";
    }

    //****************************************************************************
    // Evento de enter pressionado
    //****************************************************************************
    private void BarCodeText_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)Keys.Enter)
      {
        long id = -1;
        if (BarCodeText.Text != "")
          id = long.Parse(BarCodeText.Text);

        Product? product = AppServices.Products.FindById(id);

        decimal quantity = decimal.Parse(textBoxQuantity.Text, NumberStyles.Number, new CultureInfo("pt-BR"));

        if (product != null)
        {
          AddItem(product, quantity);
          textBoxQuantity.Text = "1";
        }
        else
          MessageBox.Show("Item não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        BarCodeText.Text = "";
        CartGrid.ClearSelection();
        e.Handled = true;
      }
      //impedir caracteres
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        e.Handled = true;
    }

    //****************************************************************************
    // Evento de tecla pressionada na grid
    //****************************************************************************
    private void CartGrid_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
      {
        if ((CartGrid.CurrentRow == null) ||
            (CartGrid.CurrentRow.DataBoundItem is not CartItem item) ||
            (MessageBox.Show("Tem certeza que deseja remover o item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes))
          return;

        _cartItems.Remove(item);
        UpdateTotal();

        e.Handled = true;
      }
    }

    //****************************************************************************
    // Evento de tecla pressionada no editor de quantidade
    //****************************************************************************
    private void TextBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
    {

      if (e.KeyChar == (char)Keys.Enter)
        BarCodeText.Focus();
        
      //impedir caracteres
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
      {
        if (((e.KeyChar == ',') && (textBoxQuantity.Text.Contains(','))) || (e.KeyChar != ','))
          e.Handled = true;
      }
    }

    //****************************************************************************
    // Atalhos
    //****************************************************************************
    private void SalesForm_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyCode)
      {
        case Keys.Escape:
          BarCodeText.Focus();
          break;
        case Keys.F1:
          //abrir modal de pesquisa
          break;
        case Keys.F2:
          textBoxQuantity.Focus();
          textBoxQuantity.SelectAll();
          break;
        case Keys.F3:
          CartGrid.Focus();
          break;
      }
    }
  }
}
