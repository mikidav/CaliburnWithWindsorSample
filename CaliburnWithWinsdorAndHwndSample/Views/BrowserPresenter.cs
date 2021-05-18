using System;
using System.Windows;
using System.Windows.Controls;
using HwndExtensions.Host;

namespace CaliburnWithWinsdorAndHwndSample.Views
{
    public class BrowserPresenter : HwndHostPresenter
    {
        public BrowserPresenter()
        {
            var browser = new WebBrowser();
            browser.Source = new Uri("http://www.google.com/");

            HwndHost = browser;
            RegisterToAppShutdown();
        }

        private void RegisterToAppShutdown()
        {
            Application.Current.Dispatcher.ShutdownStarted += OnShutdownStarted;
        }

        private void OnShutdownStarted(object sender, EventArgs e)
        {
            Dispose();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                var host = HwndHost;
                if (host != null)
                    host.Dispose();
            }
        }
    }
}