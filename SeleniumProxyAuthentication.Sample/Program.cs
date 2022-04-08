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
                EdgeOptions.AddProxyAuthenticationExtension(new Proxy(ProxyProtocols.HTTP, "proxy_server:proxy_port:proxy_username:proxy_password"));

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
