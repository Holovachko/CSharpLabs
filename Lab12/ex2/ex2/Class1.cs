using System;
using System.Collections.Generic;
using System.Text;

namespace ex2
{
    class TFirm
    {
        string name;
        string activity;
        int numOfWorkers;
        int numOfProduct;
        int productPerDay;

        public TFirm(string name, string activity, int numOfWorkers, int numOfProduct, int productPerDay)
        {
            this.name = name;
            this.activity = activity;
            this.numOfWorkers = numOfWorkers;
            this.numOfProduct = numOfProduct;
            this.productPerDay = productPerDay;
        }

        public decimal productPerHour()
        {
            return Math.Floor(Convert.ToDecimal(productPerDay / 24));
        }
        public decimal hourForProduct(int hour) { 
        return productPerHour() * hour;
        
        }
    }
}
