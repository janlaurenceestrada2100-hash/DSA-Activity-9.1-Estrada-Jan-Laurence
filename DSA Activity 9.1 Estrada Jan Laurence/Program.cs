namespace dsaactivity91
{
    class Program
    {

        public static void Main(string[] args)
        {
            /*
             * 
             */
            try
            {
                var cities = new Dictionary<string, string>()
{
        {"UK", "London, Manchester, Birmingham"},
        {"USA", "Chicago, New York, Washington"},
        {"India", "Mumbai, New Delhi, Pune"}
};
                string choice = "i";
                while (choice != "N") {

                    Console.WriteLine("AVAILABLE WORDS:");
                    Console.WriteLine("- ASDF");
                    Console.WriteLine("- ");
                    Console.WriteLine("- ");
                    Console.WriteLine("- ");
                    Console.WriteLine("- ");
                    Console.WriteLine("- ");
                    Console.WriteLine("- ");
                    Console.WriteLine("- ");
                    Console.WriteLine("- ");
                    Console.WriteLine("- ");
                    Console.WriteLine("");
                    Console.Write("Enter the English world to translate: ");
                    string word = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Translation");





                }


            }



            catch (Exception e)
            {
                Console.WriteLine("Error Encountered " + e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }


        }

    }

}