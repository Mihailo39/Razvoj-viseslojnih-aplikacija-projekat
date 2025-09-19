using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
	public class CashRegister
	{
		private string cashier;
		private DateTime shiftEndTime;
		public List<BillEntry> bills;
		FileManager fileManager;
		CommandManager commandManager;

		public void AddBill(BillEntry bill)
		{
			throw new NotImplementedException();
		}

		public void SaveData()
		{
			throw new NotImplementedException();
		}
	}
}
