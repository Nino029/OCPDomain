using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaOCP.Interfaces;

namespace PracticaOCP.CalculatorCountrys
{
    public class USATaxCalculator : ITaxCalculator
    {

        public decimal CalculateTax(decimal taxableIncome)
        {
            decimal taxAmount = 0.0m;

            if (taxableIncome <= 9875)
            {
                taxAmount = taxableIncome * 0.10m;
            }
            else if (taxableIncome <= 40125)
            {
                taxAmount = 987.50m + (taxableIncome - 9875) * 0.12m;
            }
            else if (taxableIncome <= 85525)
            {
                taxAmount = 4617.50m + (taxableIncome - 40125) * 0.22m;
            }
            else if (taxableIncome <= 163300)
            {
                taxAmount = 14605.50m + (taxableIncome - 85525) * 0.24m;
            }

    

            return taxAmount;
        }




    }
}
