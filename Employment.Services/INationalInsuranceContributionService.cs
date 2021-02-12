using System;
using System.Collections.Generic;
using System.Text;

namespace Employment.Services
{
	public interface INationalInsuranceContributionService
	{
		decimal NIContribution(decimal totalAmount);
	}
}
