using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.pageObjects;

namespace TestProject.testCases
{
    public class DesignationTest:BaseClass
    {
        private DesignationPage _designationPage;

        [SetUp]
        public void Init()
        {
            // Initialize the DesignationPage object with the driver
            _designationPage = new DesignationPage(Driver);
        }

        [Test]
        public void VerifyDesignation()
        {
            // Navigate to Designation setup
            _designationPage.NavigateToDesignation();

            _designationPage.CreateDesignation();

            Assert.True(_designationPage.isDesgCreated());

            
        }
    }
}
