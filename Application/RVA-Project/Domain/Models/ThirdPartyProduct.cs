using System;
using System.Globalization;

namespace Domain.Models
{
    public class ThirdPartyProduct : IProductEntry
    {
        private string priceTag;
        private double parsedPrice;
        private ThirdPartyStoreData thirdPartyData;
        private CurrencyType currencyType;

        public ThirdPartyProduct(string priceTag, ThirdPartyStoreData thirdPartyData)
        {
            this.priceTag = priceTag;
            this.thirdPartyData = thirdPartyData;
            ParsePriceTag();
        }

        private void ParsePriceTag()
        {
            if (!string.IsNullOrEmpty(priceTag))
            {
                var parts = priceTag.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    if (!double.TryParse(parts[0], NumberStyles.Any, CultureInfo.InvariantCulture, out parsedPrice))
                    {
                        parsedPrice = 0;
                    }

                    if (!Enum.TryParse(parts[1], true, out currencyType))
                    {
                        currencyType = CurrencyType.RSD;
                    }
                }
                else
                {
                    parsedPrice = 0;
                    currencyType = CurrencyType.RSD;
                }
            }
            else
            {
                parsedPrice = 0;
                currencyType = CurrencyType.RSD;
            }
        }

        public double getEntryPrice()
        {
            return parsedPrice;
        }

        public string getProductName()
        {
            return thirdPartyData.Name;
        }

        public double getProductPrice()
        {
            return parsedPrice;
        }

        public int getQuantity()
        {
            return 1;
        }

        public Discount getDiscount()
        {
            return null;
        }

        public CurrencyType getCurrencyType()
        {
            return currencyType;
        }

        public string toString()
        {
            return $"{getProductName()} - {getProductPrice()} {currencyType}, Qty: {getQuantity()}, Origin: {thirdPartyData.CountryOfOrigin}";
        }
    }
}
