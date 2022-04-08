using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace SeleniumProxyAuthentication.Sample
{
    public record Program
    {
        private static readonly EdgeOptions EdgeOptions = new();
        public static void Main()
        {
            try
            {
                // with proxy credential
                EdgeOptions.AddProxyAuthenticationExtension(new Proxy(ProxyProtocols.HTTP, "209.127.191.180:9279:iazgeluc:buxw7bzlke0x"));

                // without proxy credential
                //EdgeOptions.AddProxyAuthenticationExtension(new Proxy(ProxyProtocols.HTTP, "proxy_server:proxy_port"));

                IWebDriver driver = new EdgeDriver(EdgeOptions);
                driver.Navigate().GoToUrl(new Uri("https://myip.ms"));
            }
            finally
            {
                EdgeOptions.DeleteExtensionsCache();
            }
        }
    }
}