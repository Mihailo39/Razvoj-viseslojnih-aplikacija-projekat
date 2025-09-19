using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class ProductEntry : IProductEntry
    {
        private string productName;
        private double productPrice;
        private int quantity;
        private CurrencyType currency;
        private double entryPrice;
        private Discount appliedDiscount;

        public ProductEntry(string productName, double productPrice, int quantity, CurrencyType currency, Discount discount = null)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.quantity = quantity;
            this.currency = currency;
            this.appliedDiscount = discount;
            CalculateEntryPrice();
        }

        public void CalculateEntryPrice()
        {
            double total = productPrice * quantity;

            if (appliedDiscount != null)
            {
                total -= total * (appliedDiscount.Percent / 100.0);
            }

            entryPrice = total;
        }

        public string getProductName()
        {
            return productName;
        }

        public double getProductPrice()
        {
            return productPrice;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public double getEntryPrice()
        {
            return entryPrice;
        }

        public Discount getDiscount()
        {
            return appliedDiscount;
        }

        public string toString()
        {
            string discountInfo = appliedDiscount != null ? $" (Discount: {appliedDiscount.Percent}%)" : "";
            return $"{productName} - {quantity} x {productPrice} {currency}{discountInfo} = {entryPrice} {currency}";
        }

        public CurrencyType getCurrencyType()
        {
            return currency;
        }
    }

}
