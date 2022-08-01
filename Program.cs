namespace Day4
{
    class Ifelse
    {
       public static void Main(string[] args)
        {
            // Sequences ------> simple executable command

            Console.WriteLine("Sequences");

            Random random = new Random();

            //Selections
            if (random.Next(1,10)<5)
            {
                Console.WriteLine("if Statement Executed");
            }
            else if(random.Next(1, 10) == 5)
            {
                Console.WriteLine("Else if executed");
            }
            else
            {
                Console.WriteLine("Else executed");
            }

            if (random.Next(1, 10) < 5 && random.Next(1, 10) < 3) // and condition
            {
                Console.WriteLine("if Statement Executed");
            }
            else if (random.Next(1, 10) == 5 || random.Next(1, 10) < 5)// or condition
            {
                Console.WriteLine("Else if executed");
            }
            else
            {
                Console.WriteLine("Else executed");
            }

        }
    }
}