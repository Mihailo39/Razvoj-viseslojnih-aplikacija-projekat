using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
	public abstract class ThirdPartyStoreData
	{
        private string productCode;
        private string name;
        private string countryOfOrigin;

        public string ProductCode { get => productCode; set => productCode = value; }
        public string Name { get => name; set => name = value; }
        public string CountryOfOrigin { get => countryOfOrigin; set => countryOfOrigin = value; }

        public ThirdPartyStoreData(string productCode, string name, string countryOfOrigin)
        {
            this.ProductCode = productCode;
            this.Name = name;
            this.CountryOfOrigin = countryOfOrigin;
        }
    }
}
