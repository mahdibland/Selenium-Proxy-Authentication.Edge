# Selenium Proxy Authentication For Edge

> Easily add your auth proxies to your edge Driver with one line of code With Extension

## Installation

> You Can Simply Add this Library to your project with Nuget Package: <a href="https://www.nuget.org/packages/SeleniumProxyAuthentication.Edge/">
    <img src="https://www.nuget.org/Content/gallery/img/logo-header.svg" width="80" height="25"/>
    </a>
```markdown
Install-Package SeleniumProxyAuthentication.Edge -Version 1.0.0
```

## How to Use it

- First you need to download the edge driver from here (make sure that the version of your edge browser should be match with the version of edge driver that you download!)

```
https://developer.microsoft.com/en-us/microsoft-edge/tools/webdriver/
```
- Then put "msedgedriver.exe" in your project bin directory

- Create a new Instance of EdgeOptions class

```C#
private static readonly EdgeOptions EdgeOptions = new();
```
 
- Attach your proxy to the edge option using the extension method that comes with nuget package

```C#
EdgeOptions.AddProxyAuthenticationExtension(new SeleniumProxyAuthentication.Proxy(
                    ProxyProtocols.HTTP,
                    "host:port:username:password"
                    ));
```

- create a new instance of edge driver and pass the edge options instance

```C#
IWebDriver driver = new EdgeDriver(EdgeOptions);
driver.Navigate().GoToUrl(new Uri("https://myip.ms"));
```

- Remove Entire Cache That Created By Extensions (In the Dispose Function)

```C#
EdgeOptions.DeleteExtensionsCache();
```

* also see the sample project to see how it's work <a href="https://github.com/mahdibland/SeleniumProxyAuthentication.Edge/blob/8f86ea44b0331f3336749abc204dafb7da351b11/SeleniumProxyAuthentication.Sample/Program.cs">Link to sample project</a>

##  Guides

#### Proxy Format

* Host:Port:Username:Password
* Host:Port

## Contact

> Email: mahdi.blandsoft98.ir@gmail.com<br/>
> Telegram: https://t.me/ONll_CH4N<br />
    
## Licence

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](https://github.com/mahdibland/Selenium-Proxy-Authentication.Edge)
