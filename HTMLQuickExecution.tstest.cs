using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace WebProject1
{

    public class HTMLQuickExecution : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"Navigate to : 'https://www.wikipedia.org/'")]
        public void HTMLQuickExecution_CodedStep()
        {
            // Clear Browser Cache
            ActiveBrowser.ClearCache(ArtOfTest.WebAii.Core.BrowserCacheType.Cookies);
            ActiveBrowser.ClearCache(ArtOfTest.WebAii.Core.BrowserCacheType.TempFilesCache);
            ActiveBrowser.ClearCache(ArtOfTest.WebAii.Core.BrowserCacheType.History);
            // Navigate to : 'https://www.wikipedia.org/'
            ActiveBrowser.NavigateTo("https://www.wikipedia.org/", false);
            
        }
    }
}
