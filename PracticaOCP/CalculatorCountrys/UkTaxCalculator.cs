using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaOCP.Interfaces;

namespace PracticaOCP.CalculatorCountrys
{
    public class UkTaxCalculator : ITaxCalculator
    {

        public decimal CalculateTax(decimal taxableIncome)
        {
            decimal taxAmount = 0.0m;

            if (taxableIncome <= 12500)
            {
                taxAmount = 0.0m;
            }
            else if (taxableIncome <= 50000)
            {
                taxAmount = (taxableIncome - 12500) * 0.20m;
            }
            else if (taxableIncome <= 150000)
            {
                taxAmount = 7500.00m + (taxableIncome - 50000) * 0.40m;
            }
            else
            {
                taxAmount = 47500.00m + (taxableIncome - 150000) * 0.45m;
            }
           

            return taxAmount;
        }

    }
}
