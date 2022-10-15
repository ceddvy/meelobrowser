using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.IO;
using System.Data.OleDb;

namespace Meelo_Browser
{
    public partial class BrowserControl : UserControl
    {
        public bool isChanging = false;
        //MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\CEDDYY\source\repos\Meelo Browser\Meelo Browser\bin\Debug\meeloHistory.accdb;
                                                        Persist Security Info =false");
        public BrowserControl()
        {
            InitializeComponent();
            initializeBrowser();
        }

        ChromiumWebBrowser chrome, chromepop;
        
        ToolTip toolTip = new ToolTip();
        TabPage tabs;

       
      
        public bool TopLevel { get; internal set; }

        public void initializeBrowser()//function to call the browser 
        {

                settingBrowser();
                
                chrome = new ChromiumWebBrowser(urlField.Text);
            
                chrome.Dock = DockStyle.Fill;
                chrome.AddressChanged += Chrome_AddressChanged;//when the browser changes address we will call the function AddressChanged
                chrome.TitleChanged += Chrome_TitleChanged;//when the browser changes title we will call the function TitleChanged

                LifeSpanHandler lifespan = new LifeSpanHandler();
                lifespan.popup_request += life_popup_request;
                chrome.LifeSpanHandler = lifespan;
                
                browserPanel.Controls.Add(chrome);//adds the browser to  the panel
                

        }

     
        public void settingBrowser()
        {
            try
            {
                CefSettings settings = new CefSettings();
                //enabled WebRTC
                settings.CefCommandLineArgs.Add("enable-media-stream");
               

                Cef.Initialize(settings);


            }
            #pragma warning restore 0168
            catch (Exception)
            #pragma warning restore 0168
            {
            }
        }

        //function for the popup event to load in the current browser
        private void life_popup_request(string popup_request)
        {
            this.Invoke((MethodInvoker)delegate () {

                urlField.Text = popup_request;
                chromepop = new ChromiumWebBrowser(popup_request);
                chromepop.Load(urlField.Text);
                browserPanel.Controls.Clear();
                browserPanel.Controls.Add(chrome);
                chromepop.AddressChanged += Chrome_AddressChanged;
                chromepop.TitleChanged += Chrome_TitleChanged;
                chromepop.Dock = DockStyle.Fill;
            });

        }
        

        private void Chrome_TitleChanged(object sender, TitleChangedEventArgs e)
        {
           
            this.Invoke(new MethodInvoker(() =>
            {
                //set the title of the browser website to the tab
                Parent.Text = e.Title;
            }));
          
        }

        private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                //set the exact address of the url field
                urlField.Text = e.Address;
                //get the fav icon of the website
                favIcon();
                
            }));
     
        }

        //function to get the favicon of sites
        public void favIcon()
        {
            // using the api of google to get the favicons of every website
            Uri url = new Uri("https://www.google.com/s2/favicons?sz=64&domain_url=" + new Uri(chrome.Address).Host);
            try
            {
                Bitmap img = new Bitmap(new System.IO.MemoryStream(new WebClient().DownloadData(url)));

                pictureIcon.Image = img;
            }
            catch (Exception)
            {
                pictureIcon.Image = Properties.Resources.globe_96px;
            }
        }

        //check the urlfield if it contains block site
        public bool checkContains()
        {
            bool word_exist = false;
            try
            {
                if (urlField.Text.ToLower().Contains("porn")|| urlField.Text.ToLower().Contains("pornhub"))
                {
                    chrome.Load("meeloblocker.netlify.app");
                }
            }
            catch (Exception)
            {

            }
            return word_exist;
            
        }

        public bool checkContainsSave()
        {
            bool url_Exist = false;

            try
            {
                string query = "SELECT FROM history WHERE `Searches`= ('"+urlField.Text+"')";
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception)
            {

            }
            return url_Exist;
        }
    
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (chrome.CanGoBack)
            {
               
                if (!checkContainsSave())
                {
                    chrome.Back();
                }
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (chrome.CanGoForward)
            {
                
                if (!checkContainsSave())
                {
                    chrome.Forward();
                }
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            if (chrome != null)
            {
                
                if (!checkContainsSave())
                {
                    chrome.Reload();
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            optionMenu.Show(Cursor.Position.X, Cursor.Position.Y); ;
        }
        public void searchChoice()//function for search option
        {
            if (urlField.Text.Contains(".com") || urlField.Text.Contains(".org") || urlField.Text.Contains(".net"))
            {
                chrome.Load(urlField.Text);
                                 
            }
            else if (!urlField.Text.Contains(".com") || !urlField.Text.Contains(".org") || !urlField.Text.Contains(".net"))
            {
                chrome.Load("https://www.google.com/search?q=" + urlField.Text);    
            }
        }


        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.Gainsboro;
            toolTip.Show("Click to Go Back", btnBack);
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.Transparent;
        }

        private void btnForward_MouseHover(object sender, EventArgs e)
        {
            btnForward.BackColor = Color.Gainsboro;
            toolTip.Show("Click to Go Next", btnForward);
        }

        private void btnForward_MouseLeave(object sender, EventArgs e)
        {
            btnForward.BackColor = Color.Transparent;
        }
        private void btnReload_MouseHover(object sender, EventArgs e)
        {
            btnReload.BackColor = Color.Gainsboro;
            toolTip.Show("Click to Reload", btnReload);
        }

        private void btnReload_MouseLeave(object sender, EventArgs e)
        {
            btnReload.BackColor = Color.Transparent;
        }

        private void btnSettings_MouseHover(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.Gainsboro;
            toolTip.Show("Click to See Options", btnSettings);
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.Transparent;
        }

        private void pictureIcon_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show(Parent.Text, pictureIcon);
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Gainsboro;
            toolTip.Show("Click to Search", btnSearch);
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Transparent;
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryControl historyControl = new HistoryControl();
            tabs = new TabPage();
            historyControl.TopLevel = false;
            historyControl.Dock = DockStyle.Fill;

            tabs.Text = "History";
            tabs.Controls.Add(historyControl);
            
            FindForm().Controls.OfType<TabControl>().Single().TabPages.Add(tabs);
        }

        private void urlField_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Enter)
            {
                searchChoice();
            }       
        }

        private void urlField_TextChanged(object sender, EventArgs e)
        {

            if (!urlField.Text.Contains("https"))
            {

            }
            if (urlField.Text.Contains(""))
            {

            }
           
           
            if (urlField.Text.Contains("https://"))
            {
                
                btnReload.Visible = true;
                btnReload.Enabled = true;
                browserPanel.Controls.Remove(visitPanel);
                if (!checkContains())
                {
                    
                    if (urlField.Text.Contains("https://meeloblocker.netlify.app"))
                    {
                        //do nothing dont save
                    }
                    
                    else {
                        try
                        {
                            connection.Open();
                            OleDbCommand command = new OleDbCommand();
                            command.Connection = connection;
                            command.CommandText = "INSERT INTO history (`Searches`) VALUES ('" + urlField.Text + "')";

                            command.ExecuteNonQuery();
                            MessageBox.Show("Data Saved!");
                            connection.Close();
                        }
                        catch (Exception)
                        {
                           
                        }
                    }
                    
                }
            }
            
        } 

        private void pdfViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfViewer view = new PdfViewer();
            tabs = new TabPage();
            view.TopLevel = false;
            view.Dock = DockStyle.Fill;

            tabs.Text = "Pdf Viewer";
            tabs.Controls.Add(view);

            FindForm().Controls.OfType<TabControl>().Single().TabPages.Add(tabs);
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
           
            urlField.Text = "www.google.com";
            browserPanel.Controls.Remove(visitPanel);
            chrome.Load(urlField.Text);
            browserPanel.Controls.Add(chrome);
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            
            urlField.Text = "www.facebook.com";
            browserPanel.Controls.Remove(visitPanel);
            chrome.Load(urlField.Text);
            browserPanel.Controls.Add(chrome);
            
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
           
            urlField.Text = "www.youtube.com";
            browserPanel.Controls.Remove(visitPanel);
            chrome.Load(urlField.Text);
            browserPanel.Controls.Add(chrome);
           
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
           
            urlField.Text = "www.twitter.com";
            browserPanel.Controls.Remove(visitPanel);
            chrome.Load(urlField.Text);
            browserPanel.Controls.Add(chrome);

            
        }

        private void btnMeelo_Click(object sender, EventArgs e)
        {
            
            urlField.Text = "meelobrowser.netlify.app";
            browserPanel.Controls.Remove(visitPanel);
            chrome.Load(urlField.Text);
            browserPanel.Controls.Add(chrome);
            
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            browserPanel.Controls.Clear();
            browserPanel.Controls.Add(visitPanel);
            visitPanel.Visible = true; ;
            urlField.Text = "";
            pictureIcon.Image = Properties.Resources.globe_96px;
            Parent.Text = "New Tab";
            btnReload.Visible = false;
            btnReload.Enabled = false;
            
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Gainsboro;
            toolTip.Show("Click to Return Home", btnHome);
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Transparent;
        }

        private void urlField_MouseClick(object sender, MouseEventArgs e)
        {
            urlField.SelectAll();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchChoice();
        }
    }
}


