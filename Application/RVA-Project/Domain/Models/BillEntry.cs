using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
	public class BillEntry
	{
		string billId;
		double totalAmount;
		DateTime timestamp;
		IBillState currentState;
		public List<IProductEntry> products;
		List <IObserver> observers;

		public void ChangeState(IBillState state)
		{
			throw new NotImplementedException();
		}

		public double CalculateTotal()
		{
			throw new NotImplementedException();
		}

		public void NotifyObserver()
		{
			throw new NotImplementedException();
		}
	}
}
