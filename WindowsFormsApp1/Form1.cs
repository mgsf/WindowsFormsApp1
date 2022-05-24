using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.SetVirtualHostNameToFolderMapping("test.fon", "HtmlSample", CoreWebView2HostResourceAccessKind.Allow);
            webView.Source = new Uri(@"https://test.fon/SampleWebMessage.html");
        }

        private void Sendmsg_Click(object sender, EventArgs e)
        {
            var msg = txtSendmsg.Text;
            webView.ExecuteScriptAsync($"MessageReceived(' {msg} ')");
        }

        private void webView_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            lblRecivmsg.Text = e.TryGetWebMessageAsString();
        }

        private void btnShowChild_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog(this);
        }

        public void NotifyMe(string s)
        {
            MessageBox.Show(s);
        }
    }
}
