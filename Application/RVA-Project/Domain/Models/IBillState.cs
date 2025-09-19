using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
	public interface IBillState
	{
		void Handle(BillEntry bill);

		string GetStateName();
	}
}
