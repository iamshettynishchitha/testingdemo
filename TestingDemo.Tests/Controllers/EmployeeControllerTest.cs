using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingDemo.Tests.Controllers
{
    class EmployeeControllerTest
    {
        public void Employees()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

