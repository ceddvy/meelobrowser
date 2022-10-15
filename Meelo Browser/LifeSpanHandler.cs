using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Meelo_Browser
{
    class LifeSpanHandler : ILifeSpanHandler
    {
        
        public event Action<string> popup_request;
        

        public bool DoClose(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            return false;
        }

        public void OnAfterCreated(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            
        }

        public virtual void OnBeforeClose(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
           
        }

        public virtual bool OnBeforePopup(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            if (this.popup_request != null)
                this.popup_request(targetUrl);

            

            newBrowser = null;
            return true;
            
        }
    }
}
