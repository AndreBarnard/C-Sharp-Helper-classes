using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
	[TestClass]
	public class UnitTestRegexValidator : TestClassBase
	{
		[TestMethod]
		public void ValidateInternationNumberWithPlus()
		{
			//arrange
			string CellNo = "+27725462359";

			//act
			SSOLib.Helpers.RegexValidator cellNoValidator = new SSOLib.Helpers.RegexValidator(SSOLib.Helpers.RegexValidator.ValidationType.InternationalMobile);

			//assert
			Assert.IsTrue(cellNoValidator.Validate(CellNo));

		}

		[TestMethod]
		public void ValidateInternationNumberWithOutPlus()
		{
			//arrange
			string CellNo = "0725462359";

			//act
			SSOLib.Helpers.RegexValidator cellNoValidator = new SSOLib.Helpers.RegexValidator(SSOLib.Helpers.RegexValidator.ValidationType.InternationalMobile);

			//assert
			Assert.IsTrue(cellNoValidator.Validate(CellNo));
		}

		[TestMethod]
		public void ValidateInternationNumberNoAlpha()
		{
			//arrange
			string CellNo = "abcdefghij";

			//act
			SSOLib.Helpers.RegexValidator cellNoValidator = new SSOLib.Helpers.RegexValidator(SSOLib.Helpers.RegexValidator.ValidationType.InternationalMobile);

			SSOLib.Helpers.RegexValidator cellNoValidator2 = new SSOLib.Helpers.RegexValidator(SSOLib.Helpers.RegexValidator.ValidationType.IPAddress);

			cellNoValidator2.Validate("1.0.0.1");

			//assert
			Assert.IsFalse(cellNoValidator.Validate(CellNo));
		}

	}
}
