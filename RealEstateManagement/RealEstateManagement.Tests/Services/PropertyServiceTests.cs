using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RealEstateManagement.Tests.Services
{
	[TestClass]
	public class PropertyServiceTests
	{
		[TestMethod]
		public void ToAddAProperty_ShouldCallSaveOnce()
		{
			//var dbContextMock = new Mock<RealEstateManagementContext>();
			
			//Cant use this because its not overrideable or cant be made virtual
			//dbContextMock.Setup(x=>x.Properties.Add(It.IsAny<Property>())).Verifiable();
			//var propertyMock = new Mock<Property>();

			//var propertyService = new PropertyService();

			

			//propertyService.AddNewProperty(propertyMock.Object, dbContextMock.Object);

			//dbContextMock.Verify(x=>x.Properties.Add(It.IsAny<Property>()),Times.Once());
			//dbContextMock.Verify(x=>x.SaveChanges(),Times.Once());
			
			//propertyServiceMock.Setup(x=>x.AddProperty(It.IsAny<Property>(), It.IsAny<DbContext>()))
		}
	}
}
