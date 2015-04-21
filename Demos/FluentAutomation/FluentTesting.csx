
using FluentAutomation;
var test = new FluentTest();
SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);

var I = test.I;

I.Open("http://thoughtworks.com");
I.Click(".header__menu>.menu-item>.menu-item__link");
I.Click(".section-links .grid__cell a");

// var Test = Require<F14N>()  
//     .Init<FluentAutomation.SeleniumWebDriver>()
//     .Bootstrap("Chrome")
//     .Config(settings => {
//         // Easy access to FluentAutomation.Settings values
//         settings.DefaultWaitUntilTimeout = TimeSpan.FromSeconds(3);
//     });

// Test.Run("Hello GIDS", I => {  
//     I.Open("http://www.developermarch.com/developersummit/");
//     I.Click(".registerbt");
//     I.Click("regclick");
// });
