using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
	public class RegexValidator
	{

		public enum ValidationType
		{
			InternationalMobile,
			Email,
			IPAddress,
			Trust,
			CompanyRegistation,
			AlphaChars
		}

		private string ValidInternationalMobileRegString = @"(^\+[1-9]{1}[0-9]{3,14}$)*[0-9{17}]";
		private string ValidEmailRegexString = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
		private string ValidIPAddressRegexString = @"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
		private string ValidTrustRegexString = @"^IT[0-9]{5}[/][0-9]{4}$";
		private string ValidCompanyRegNotRegexString = @"^IT[0-9]{5}[/][0-9]{4}$";
		private string ValidAlphaCharString = "[a-z][A-Z]";

		private ValidationType validationType;
		private bool isCustomRegularExpression = false;
		private string regularExpressionString = "";


		public RegexValidator(ValidationType ValidationType)
		{
			validationType = ValidationType;
		}

		public RegexValidator(string RegularExpression)
		{
			isCustomRegularExpression = true;
			regularExpressionString = RegularExpression;
		}


		public bool	Validate(string value)
		{
			System.Text.RegularExpressions.Regex regularExpression = new System.Text.RegularExpressions.Regex(getRegularExpressionString());

			return regularExpression.IsMatch(value);
		}

		public bool Validate(string value, System.Text.RegularExpressions.RegexOptions options)
		{
			System.Text.RegularExpressions.Regex regularExpression = new System.Text.RegularExpressions.Regex(getRegularExpressionString(), options);

			return regularExpression.IsMatch(value);
		}

		private string getRegularExpressionString()
		{

			if (isCustomRegularExpression)
			{
				return regularExpressionString;
			}

			switch (validationType)
			{
				case ValidationType.InternationalMobile:
					return ValidInternationalMobileRegString;
				case ValidationType.Email:
					return ValidEmailRegexString;
				case ValidationType.IPAddress:
					return ValidIPAddressRegexString;
				case ValidationType.Trust:
					return ValidTrustRegexString;
				case ValidationType.CompanyRegistation:
					return ValidCompanyRegNotRegexString;
				case ValidationType.AlphaChars:
					return ValidAlphaCharString;
				default:
					break;
			}

			return "";
		}
	}
}
