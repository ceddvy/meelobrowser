using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meelo_Browser
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            createTab();
            /// set the Icon for the application
            Icon = Properties.Resources.meeloIcon1;
        }
        // creating variable for tab page
        TabPage tabs;
        ToolTip showTip = new ToolTip();

        /// this function will create a new tab with the user control
        public void createTab()
        {
            //calling the variable of TabPage
            tabs = new TabPage();
            //here we will call the browser control to add in the Tab Page
            BrowserControl browser = new BrowserControl();

            //here is for the browser to adapt to the tabpage
            browser.Show();
            browser.TopLevel= false;
            browser.Dock = DockStyle.Fill;

            //here is for the tab properties
            tabs.Text="New Tab"; 
            // this will be override by trhe site name when the browser loads
            tabs.Controls.Add(browser); 
            // adding the browser to the tab
            metroTabControl1.TabPages.Add(tabs); 
            // after adding the browser we will add the tabs to the tabpage
            metroTabControl1.SelectTab(metroTabControl1.TabCount - 1);

           

        }
        // this function will remove the current selected tab
        public void removeTab()
        {
            tabs = metroTabControl1.SelectedTab;
            metroTabControl1.TabPages.Remove(tabs);
        }

        
        private void addBtn_Click(object sender, EventArgs e)
        {
            //call the function createTabs to have a new Tab
            createTab();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            //call the function removeTabs to remove current selected Tab
            removeTab();
        }
        // this the design when the mouse is hover and leave
        private void addBtn_MouseHover(object sender, EventArgs e)
        {
            addBtn.BackColor = Color.Gainsboro;
            showTip.Show("New Tab", addBtn);
        }

        private void addBtn_MouseLeave(object sender, EventArgs e)
        {
            addBtn.BackColor = Color.Transparent;
        }

        private void removeBtn_MouseHover(object sender, EventArgs e)
        {
            removeBtn.BackColor = Color.Gainsboro;
            showTip.Show("Close Tab", removeBtn);
        }

        private void removeBtn_MouseLeave(object sender, EventArgs e)
        {
            removeBtn.BackColor = Color.Transparent;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            createTab();
        }
    }
}
