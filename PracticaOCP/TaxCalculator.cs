using PracticaOCP.Interfaces;
using System;
using System.Collections.Generic;



public class TaxCalculator
{

    private ITaxCalculator _estrategia;

    public TaxCalculator(ITaxCalculator tax)
    {
        _estrategia = tax;
    }


    public void SetStrategy(ITaxCalculator estrategia)
    {
        _estrategia = estrategia;
    }

    public decimal Calculate(decimal totalIncome, decimal deduction)
    {
        decimal taxableIncome = totalIncome - deduction;
        decimal taxAmount = _estrategia.CalculateTax(taxableIncome);
        return taxAmount;
    }

}
