using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;

namespace SmartHome
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public partial class Browser : Form
    {
        List<WebBrowser> browseri = new List<WebBrowser>();
        public Browser()
        {
            InitializeComponent();
            toolStripButtonForward.Enabled = false;
            toolStripButton1.Enabled = false;
            browseri.Add(webBrowser1);
            browseri[0].CanGoBackChanged += new EventHandler(webBrowser1_CanGoBackChanged);
            browseri[0].CanGoForwardChanged += new EventHandler(webBrowser1_CanGoForwardChanged);
            browseri[0].Navigate("google.com");
        }



        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {

                browseri[tabControl1.SelectedIndex].Navigate(new Uri(address));
                tabControl1.SelectedTab.Text = browseri[tabControl1.SelectedIndex].Document.Title;
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            browseri[tabControl1.SelectedIndex].GoBack();
        }
        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = browseri[tabControl1.SelectedIndex].CanGoBack;
        }

        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            toolStripButtonForward.Enabled = browseri[tabControl1.SelectedIndex].CanGoForward;
        }
        private void toolStripButtonGo_Click(object sender, EventArgs e)
        {
            Navigate(toolStripTextBox1.Text);
        }

        private void toolStripButtonForward_Click(object sender, EventArgs e)
        {
            browseri[tabControl1.SelectedIndex].GoForward();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!browseri[tabControl1.SelectedIndex].Url.Equals("about:blank"))
            {
                browseri[tabControl1.SelectedIndex].Refresh();
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.SelectAll();
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(toolStripTextBox1.Text);
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            toolStripTextBox1.Text = webBrowser1.Url.ToString();

        }
        private void webBrowser1_CanGoBackChanged()
        {
            toolStripButton1.Enabled = webBrowser1.CanGoBack;
        }
        private void webBrowser1_CanGoForwardChanged()
        {
            toolStripButtonForward.Enabled = webBrowser1.CanGoForward;
        }

        private void toolStripButtonhome_Click(object sender, EventArgs e)
        {

            Navigate("google.com");
        }

        private void toolStripButtonNT_Click(object sender, EventArgs e)
        {
            TabPage tabpage = new TabPage();
            tabpage.Text = "New tab";
            tabControl1.Controls.Add(tabpage);
            WebBrowser webbrowser = new WebBrowser();
            webbrowser.CanGoBackChanged += new EventHandler(webBrowser1_CanGoBackChanged);
            webbrowser.CanGoForwardChanged += new EventHandler(webBrowser1_CanGoForwardChanged);
            browseri.Add(webbrowser);
            webbrowser.Parent = tabpage;
            webbrowser.Dock = DockStyle.Fill;
            webbrowser.Navigate("www.google.com");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int k = tabControl1.SelectedIndex - 1;
            if (tabControl1.SelectedIndex != 0)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                tabControl1.SelectedIndex = k;
                browseri.RemoveAt(tabControl1.SelectedIndex);
            }


        }



    }
}
