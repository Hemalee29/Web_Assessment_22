using OpenQA.Selenium;

namespace WebTest_Assesment
{
    internal class SidesPage
    {
        private IWebDriver driver;
        private IWebElement sidespage;

        public SidesPage(IWebElement sidespage)
        {
            this.sidespage = sidespage;

        }
        public String kilojoules => driver.FindElement(By.ClassName("caption")).Text.ToLower();

        
        
    
        

    }
    

}