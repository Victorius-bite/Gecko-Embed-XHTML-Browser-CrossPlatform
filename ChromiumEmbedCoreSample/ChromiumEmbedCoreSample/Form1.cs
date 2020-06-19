
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChromiumEmbedCoreSample
{
    public partial class Form1 : Form
    {

        public ChromiumWebBrowser chromeBrowser;
        public Form1()
        {
            InitializeComponent();
            InitializeCromium();
        }

        private void InitializeCromium()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser("https://en.wikipedia.org/wiki/Main_Page");
            this.panel1.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
         

  //          Control control = (Control)sender;

//            this.panel1.Size = new Size(control.Size.Width, control.Size.Height - 20);
            // Ensure the Form remains square (Height = Width).
            //if (control.Size.Height != control.Size.Width)
            // {
            //    control.Size = new Size(control.Size.Width, control.Size.Width);
            //}
        }
    }

}
