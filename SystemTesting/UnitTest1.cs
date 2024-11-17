using Microsoft.VisualStudio.TestTools.UnitTesting;
using Endorsed.Controllers;
using Microsoft.AspNetCore.Mvc;
using Endorsed.Data.Repositories.HelperClasses;
using Moq;
using Endorsed.Models;

namespace SystemTesting
{
    [TestClass]
    public class UnitTest1 :ControllerBase
    {

        private Mock<IAddressHelper> _AddressHelperMock;
        private AddressController _addressController;

        public void Setup()
        {
            _AddressHelperMock = new Mock<IAddressHelper>();

        }



        [TestMethod]
        public void Address_Validation()
        {

            //Arrange
            //  var addressid = 5;
            Address address = new Address
            {
                AddressID = 1,
                HouseNumber = 1111111111111,
                StreetName = "Hers",
                CityName = "onw"
            };

            _AddressHelperMock.Setup

            //Act
            var res = _addressController.GetBy(addressid);

            //Assert

            // var res = QualificationsController.GetBy(5);

        }
    }
}
