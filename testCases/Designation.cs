using OpenQA.Selenium;
using NUnit.Framework;

namespace TestProject
{
    public class DesignationTests : BaseClass
    {
        [Test]
        public void VerifyDesignationCreation()
        {
            // Navigate to 'Setups' menu
            IWebElement setupsMenu = Driver.FindElement(By.XPath("//span[normalize-space()='Setups']"));
            setupsMenu.Click();

            // Navigate to 'Designation' menu
            IWebElement designationMenu = Driver.FindElement(By.XPath("//span[normalize-space()='Designation']"));
            designationMenu.Click();

            // Click on 'New' button
            IWebElement newButton = Driver.FindElement(By.XPath("//span[normalize-space()='New']"));
            newButton.Click();

            // Fill in the form
            IWebElement codeField = Driver.FindElement(By.Name("Code"));
            codeField.SendKeys("1002");

            IWebElement nameField = Driver.FindElement(By.Name("Name"));
            String desg = "TestDesg2";
            nameField.SendKeys(desg);

            // Click on 'Save' button
            IWebElement saveButton = Driver.FindElement(By.XPath("//span[normalize-space()='Save']"));
            saveButton.Click();
            

            Driver.Navigate().Back();

            Driver.FindElement(By.XPath("/html[1]/body[1]/div[6]/div[2]/div[1]/div[1]/div[1]/div[5]/div[1]/table[1]/tbody[1]/tr[2]/td[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]")).SendKeys(desg);
            Thread.Sleep(2000);
            String actDesg= Driver.FindElement(By.XPath("/html[1]/body[1]/div[6]/div[2]/div[1]/div[1]/div[1]/div[6]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/span[1]/a[1]")).Text;

            Assert.AreEqual(desg, actDesg);
        }
    }
}
