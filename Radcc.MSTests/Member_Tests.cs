using Microsoft.VisualStudio.TestTools.UnitTesting;
using Radcc.Model;

namespace Radcc.MSTests
{
    [TestClass]
    public class Member_Tests
    {
        [TestMethod]
        public void ThatFirstNameisAddedToANewInstanceOfMember()
        {
            var member = new ApplicationUser { FirstName = "Paul", LastName = "Redshaw", EmailAddress = "paul.rigly@gmail.com" };

            Assert.AreEqual("Paul", member.FirstName);
        }
    }
}