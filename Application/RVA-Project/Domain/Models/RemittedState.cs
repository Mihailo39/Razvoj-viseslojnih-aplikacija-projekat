using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
	public class RemittedState : IBillState
	{
        public string GetStateName()
        {
            throw new NotImplementedException();
        }
        public void Handle(BillEntry bill)
        {
            throw new NotImplementedException();
        }
    }
}
