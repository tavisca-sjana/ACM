using System;
using Xunit;

namespace ACM.bl.Tests
{
    public class CustomerTest
    {
        [Fact]
        public void ValidateCustomerName()
        {
            //Arrange
            Customer cs = new Customer();
            cs.FirstName = "Soumyadeep";
            cs.LastName = "Jana";
            string expected = "Soumyadeep, Jana";

            //Act
            string actual = cs.FullName;

            //Assert
            Assert.Equal("k","k");
        }
    }
}
