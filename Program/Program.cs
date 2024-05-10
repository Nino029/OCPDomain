
    using PracticaOCP;
    using PracticaOCP.CalculatorCountrys;
    


    class Program { 


        static void Main(string[] args)
        {

        TaxCalculator calculator = new TaxCalculator(new USATaxCalculator());

        decimal totalIncome = 100000;
        decimal deduction = 15000;
        decimal taxAmount = calculator.Calculate(totalIncome, deduction);

        Console.WriteLine("\n");
        Console.WriteLine("======MONTO USA:=======");
        Console.WriteLine($"El Monto en USA es de: {taxAmount}");

        Console.WriteLine("\n");
        Console.WriteLine("======MONTO REINO UNIDO:=======");
        calculator.SetStrategy(new UkTaxCalculator());
        taxAmount = calculator.Calculate(totalIncome, taxAmount);
        Console.WriteLine($"El Monto en Reino unido es de : {taxAmount}");

        Console.WriteLine("\n");
        Console.WriteLine("======MONTO INDIA:=======");
        calculator.SetStrategy(new IndiaTaxCalculator());
        taxAmount = calculator.Calculate(totalIncome, deduction);
        Console.WriteLine($"El Monto en India es de : {taxAmount}");



        }
    }
