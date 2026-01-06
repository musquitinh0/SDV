using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SDV.Forms
{
    public partial class BaseForm : Form
    {
        [DllImport("user32.dll")]
        protected static extern void ReleaseCapture();
        [DllImport("user32.dll")]
        protected static extern void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        /// <summary>
        /// Evento para controlar o resize da janela
        /// </summary>
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && WindowState == FormWindowState.Normal)
            {
                Point cursor = PointToClient(Cursor.Position);
                int resizeArea = 4; // espessura da borda para resize

                if (cursor.X <= resizeArea && cursor.Y <= resizeArea)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (cursor.X >= Width - resizeArea && cursor.Y <= resizeArea)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (cursor.X <= resizeArea && cursor.Y >= Height - resizeArea)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (cursor.X >= Width - resizeArea && cursor.Y >= Height - resizeArea)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (cursor.X <= resizeArea)
                    m.Result = (IntPtr)HTLEFT;
                else if (cursor.X >= Width - resizeArea)
                    m.Result = (IntPtr)HTRIGHT;
                else if (cursor.Y <= resizeArea)
                    m.Result = (IntPtr)HTTOP;
                else if (cursor.Y >= Height - resizeArea)
                    m.Result = (IntPtr)HTBOTTOM;
            }
        }

        /// <summary>
        /// Evento para controlar o arrastar da janela
        /// </summary>
        internal static class DwmApi
        {
            [DllImport("dwmapi.dll")]
            public static extern int DwmSetWindowAttribute(
                IntPtr hwnd,
                int dwAttribute,
                ref int pvAttribute,
                int cbAttribute
            );
        };

        /// <summary>
        /// Configurar os handles
        /// </summary>
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if (OperatingSystem.IsWindowsVersionAtLeast(10, 0, 22000)) // Windows 11
            {
                const int DWMWA_WINDOW_CORNER_PREFERENCE = 33;
                const int DWMWCP_ROUND = 2;

                int preference = DWMWCP_ROUND;
                _ = DwmApi.DwmSetWindowAttribute(
                    Handle,
                    DWMWA_WINDOW_CORNER_PREFERENCE,
                    ref preference,
                    sizeof(int)
                );
            }
        }

        /// <summary>
        /// buttonClose_Click
        /// </summary>
        protected void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Evento para controlar o arrastar da janela
        /// </summary>
        protected void PanelTopMouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public BaseForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = true;
            Opacity = 1;
        }

        /// <summary>
        /// click no botao de maximizar
        /// </summary>
        protected void ButtonMaximize_Click(object sender, EventArgs e)
        {
            ToggleMaximize();
        }

        /// <summary>
        /// Trocar o maximizar
        /// </summary>
        protected void ToggleMaximize()
        {
            if (WindowState == FormWindowState.Normal)
            {
                MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// Resize do form faz o update do icone do maximizar
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateMaximizeIcon();
        }

        /// <summary>
        /// Update do icone de maxizar/voltar ao normal
        /// </summary>
        private void UpdateMaximizeIcon()
        {
            if (WindowState == FormWindowState.Maximized)
                buttonMaximize.Text = "❐"; // restaurar
            else
                buttonMaximize.Text = "⬜"; // maximizar
        }

        /// <summary>
        /// click no minimizar
        /// </summary>
        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Set do titulo da janela
        /// </summary>
        protected void SetTitle(string title)
        {
            if (title != null && title.Length > 0)
                this.labelTitle.Text = title;
            else
                this.labelTitle.Visible = false;
        }

        /// <summary>
        /// Resize
        /// </summary>
        private void BaseForm_Resize(object sender, EventArgs e)
        {
            const int margin = 4;

            contentPanel.Height = this.Height - panelTop.Height - margin;
            contentPanel.Width = this.Width - margin;
        }
    }
}
