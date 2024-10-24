namespace kursus
{
    class Calculate()
    {
        public double AddOne(double value)
        {
            value++;
            return value;
        }
        public double PullOne(double value)
        {
            value--;
            return value;
        }
        public double AddValues(double value1, double value2)
        {
            return value1 + value2;
        }

        private double TotalValue;
        public void SetTotalValue(double TotalValue)
        {
            this.TotalValue = TotalValue;
        }
        public double GetTotalValue()
        {
            return TotalValue;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Calculate number = new Calculate();

            var var = new Random();
            double numbergen = var.Next(1, 101);
            Console.WriteLine(numbergen + " = x");
            
            // return skal fanges i en 'Console.WriteLine' for at den udskrives
            Console.WriteLine(number.AddOne(numbergen) + " = x + 1");

            Console.WriteLine(number.PullOne(numbergen) + " = x - 1");

            Console.WriteLine(number.AddValues(numbergen, numbergen) + " = x + x");


            number.SetTotalValue(numbergen + number.AddOne(numbergen) + number.PullOne(numbergen) + number.AddValues(numbergen, numbergen));
            Console.WriteLine(number.GetTotalValue() + " = Total sum value");
        }
    }
}
