namespace Part_4___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            // ------------------------------------------------------------------------------------- ONE
            
            Console.WriteLine("Random Integers");
            int minNum, maxNum, randInt1_1, randInt1_2, randInt1_3, randInt1_4, randInt1_5;
            Console.WriteLine("Enter a minimum value: ");
            minNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a maximum value: ");
            maxNum = Convert.ToInt32(Console.ReadLine());
            randInt1_1 = generator.Next(minNum, maxNum + 1);
            randInt1_2 = generator.Next(minNum, maxNum + 1);
            randInt1_3 = generator.Next(minNum, maxNum + 1);
            randInt1_4 = generator.Next(minNum, maxNum + 1);
            randInt1_5 = generator.Next(minNum, maxNum + 1);
            Console.WriteLine($"{randInt1_1}, {randInt1_2}, {randInt1_3}, {randInt1_4}, {randInt1_5}");
            Console.WriteLine("");

            // ------------------------------------------------------------------------------------- TWO
            /*
            int die1, die2, rollsum;
            Console.WriteLine("Dice Roller");
            die1 = generator.Next(0, 7);
            die2 = generator.Next(0, 7);
            Console.WriteLine($"First die: {die1}");
            Console.WriteLine($"Second die: {die2}");
            rollsum = die1 + die2;
            Console.WriteLine($"The sum of your rolls is: {rollsum}");
            Console.WriteLine("");
            */
            // ------------------------------------------------------------------------------------- THREE

            //double minDouble = minNum, maxDouble = maxNum, ranDecNum1;
            double randDouble1_1, randDouble1_2, randDouble1_3;
            int randInt2_1, randInt2_2, randInt2_3;
            Console.WriteLine("Random Decimal Numbers");
            //ranDecNum1 = generator.NextDouble(minDouble, maxDouble);
            randDouble1_1 = generator.NextDouble();
            randDouble1_2 = generator.NextDouble();
            randDouble1_3 = generator.NextDouble();

            randInt2_1 = generator.Next(minNum, maxNum);
            randInt2_2 = generator.Next(minNum, maxNum);
            randInt2_3 = generator.Next(minNum, maxNum);


        }
    }
}