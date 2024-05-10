using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaOCP.Interfaces;

namespace PracticaOCP.CalculatorCountrys
{
    public class IndiaTaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(decimal taxableIncome)
        {
            decimal taxAmount = 0.0m;

            if (taxableIncome <= 250000)
            {
                taxAmount = 0.0m;
            }
            else if (taxableIncome <= 500000)
            {
                taxAmount = (taxableIncome - 250000) * 0.05m;
            }
            else if (taxableIncome <= 1000000)
            {
                taxAmount = 12500.00m + (taxableIncome - 500000) * 0.20m;
            }
            else
            {
                taxAmount = 112500.00m + (taxableIncome - 1000000) * 0.30m;
            }
           

            return taxAmount;
        }
    }
}
