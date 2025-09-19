using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
	public interface IObserver
	{
		void Update(BillEntry bill);
	}
}
