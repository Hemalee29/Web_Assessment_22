using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebTest_Assesment
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver();

        [TestInitialize]
        public void setup()
        {
            driver.Url = "https://d3nay7txmslpgb.cloudfront.net/#/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
        }

        [TestMethod]
        public void NavigateToContactPage_Enter_Email_Telephone_VerifyErrorMessage()
        {
            //Arrange
            driver.FindElement(By.CssSelector("[aria-label=contact]")).Click();
            Thread.Sleep(1000);

            //Act
            driver.FindElement(By.Id("email")).SendKeys("abc@gmail");
            driver.FindElement(By.Id("telephone")).SendKeys("abcg");
            driver.FindElement(By.CssSelector("[aria-label=submit]")).Click();


            //Assert
            String expectedmsg = "Email is invalid.";
            WebElement email = (WebElement)driver.FindElement(By.Id("email"));
            String actualmsg = email.getText();
            Console.WriteLine("Error message is: "+ actualmsg);
            Assert.AreEqual(expectedmsg, actualmsg);
        }


        //I try to finish my first task but I cound't finish beacuse getText() method is not work for me
        //Asssertion is left for first task

        [TestMethod]
        public void Click_MenuPage_Click_SidesTab_Verify_MenuItem()
        {
            //Arrange
            
            driver.FindElement(By.CssSelector("[aria-label=menu]")).Click();

            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/main/div/div/div[2]/div[1]/div[2]/div/div[3]")).Click();
            
            //Act


            //Assert
           
            Assert.AreEqual(3273, SidesPage.GetKilojoules("caption").kilojoules);


        }
        
        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }

        //In the second task I not finish the verify menu item
    }
}

