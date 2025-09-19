using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
	public class Discount
	{
		private string description;
		private double percent;
		private DateTime startDate;
		private DateTime endDate;

        public string Description { get => description; set => description = value; }
        public double Percent { get => percent; set => percent = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }

        public bool IsValid()
		{
			throw new NotImplementedException();
		}

        public Discount(string description, double percent, DateTime startDate, DateTime endDate)
        {
            this.Description = description;
            this.Percent = percent;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }


    }
}
