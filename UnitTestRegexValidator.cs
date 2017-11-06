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
			Helpers.RegexValidator cellNoValidator = new Helpers.RegexValidator(Helpers.RegexValidator.ValidationType.InternationalMobile);

			//assert
			Assert.IsTrue(cellNoValidator.Validate(CellNo));

		}

		[TestMethod]
		public void ValidateInternationNumberWithOutPlus()
		{
			//arrange
			string CellNo = "0725462359";

			//act
			Helpers.RegexValidator cellNoValidator = new Helpers.RegexValidator(Helpers.RegexValidator.ValidationType.InternationalMobile);

			//assert
			Assert.IsTrue(cellNoValidator.Validate(CellNo));
		}

			[TestMethod]
		public void ValidateInternationNumberNoAlpha()
		{
			//arrange
			string CellNo = "abcdefghij";

			//act
			Helpers.RegexValidator cellNoValidator = new Helpers.RegexValidator(Helpers.RegexValidator.ValidationType.InternationalMobile);

			//assert
			Assert.IsFalse(cellNoValidator.Validate(CellNo));
		}


		[TestMethod]
		public void ValidateEmailAddress()
		{
			//arrange
			string email = "name@email.com";

			//act
			Helpers.RegexValidator emailValidator = new Helpers.RegexValidator(Helpers.RegexValidator.ValidationType.Email);

			//assert
			Assert.IsTrue(emailValidator.Validate(email));
		}

		[TestMethod]
		public void ValidateIncorrectEmailAddressWithOutAT()
		{
			//arrange
			string email = "nameemail.com";

			//act
			Helpers.RegexValidator emailValidator = new Helpers.RegexValidator(Helpers.RegexValidator.ValidationType.Email);

			//assert
			Assert.IsFalse(emailValidator.Validate(email));
		}

		[TestMethod]
		public void ValidateIncorrectEmailAddressWithOutDot()
		{
			//arrange
			string email = "name@emailcom";

			//act
			Helpers.RegexValidator emailValidator = new Helpers.RegexValidator(Helpers.RegexValidator.ValidationType.Email);

			//assert
			Assert.IsFalse(emailValidator.Validate(email));
		}

		[TestMethod]
		public void ValidateIncorrectEmailAddressWithOutDomain()
		{
			//arrange
			string email = "name@.com";

			//act
			Helpers.RegexValidator emailValidator = new Helpers.RegexValidator(Helpers.RegexValidator.ValidationType.Email);

			//assert
			Assert.IsFalse(emailValidator.Validate(email));
		}


		[TestMethod]
		public void ValidateIPAddress()
		{
			//arrange
			string ipaddress = "192.168.10.10";

			//act
			Helpers.RegexValidator ipAddressValidator = new Helpers.RegexValidator(Helpers.RegexValidator.ValidationType.IPAddress);

			//assert
			Assert.IsTrue(ipAddressValidator.Validate(ipaddress));
		}

		[TestMethod]
		public void ValidateInvalidIPAddress()
		{
			//arrange
			string ipaddress = "192.16810.10";

			//act
			Helpers.RegexValidator ipAddressValidator = new Helpers.RegexValidator(Helpers.RegexValidator.ValidationType.IPAddress);

			//assert
			Assert.IsFalse(ipAddressValidator.Validate(ipaddress));
		}


		[TestMethod]
		public void ValidateAlphaChar()
		{
			//arrange
			string alpha = "abcdEFGH";

			//act
			Helpers.RegexValidator alphaValidator = new Helpers.RegexValidator(Helpers.RegexValidator.ValidationType.AlphaChars);

			//assert
			Assert.IsTrue(alphaValidator.Validate(alpha));
		}

		[TestMethod]
		public void ValidateNonAlphaChar()
		{
			//arrange
			string alpha = "abcdEFGH1234";

			//act
			Helpers.RegexValidator alphaValidator = new Helpers.RegexValidator(Helpers.RegexValidator.ValidationType.AlphaChars);

			//assert
			Assert.IsFalse(alphaValidator.Validate(alpha));
		}

		[TestMethod]
		public void ValidateNumeric()
		{
			//arrange
			string value = "1234567";

			//act
			Helpers.RegexValidator validator = new Helpers.RegexValidator(Helpers.RegexValidator.ValidationType.Numeric);

			//assert
			Assert.IsTrue(validator.Validate(value));
		}

		[TestMethod]
		public void ValidateNotNumeric()
		{
			//arrange
			string value = "123A4567";

			//act
			Helpers.RegexValidator validator = new Helpers.RegexValidator(Helpers.RegexValidator.ValidationType.Numeric);

			//assert
			Assert.IsFalse(validator.Validate(value));
		}
		
			[TestMethod]
		public void ValidateBitCoinAddress()
		{
			//arrange
			string value = "1MzJvJNZnTZx13MLAMUPkUuyaeKtgF2PSH";

			//act
			Helpers.RegexValidator validator = new Helpers.RegexValidator(SSOLib.Helpers.RegexValidator.ValidationType.BitCoinAddress);

			//assert
			Assert.IsTrue(validator.Validate(value));
		}

	}
}
