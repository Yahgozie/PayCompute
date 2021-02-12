using System;
using System.Collections.Generic;
using System.Text;

namespace Employment.Services
{
	public interface ITaxService
	{
		decimal TaxAmount(decimal totalAmount);
	}
}
