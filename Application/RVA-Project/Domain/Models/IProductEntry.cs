using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
	public interface IProductEntry
	{
		string getProductName();

		double getProductPrice();

		int getQuantity();

		CurrencyType getCurrencyType();

		double getEntryPrice();

		Discount getDiscount();

		string toString();
	}
}
