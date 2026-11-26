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
                var trns = new Dictionary<string, string>()
{
        {"Thank you", "Salamat"},
        {"Expensive", "Mahal"},
        {"How much", "Magkano"},
        {"Thirsty", "Nauuhaw"},
        {"Hungry", "Gutom"},
        {"Sorry", "Pasensya"},
        {"Yes", "Oo"},
        {"No", "Hindi"},
        {"Leave", "Alis"},
        {"Goodbye", "Paalam"}
};
                string choice = "i";
                while (choice != "N") {

                    Console.WriteLine("AVAILABLE WORDS:");
                    Console.WriteLine("- Thank you");
                    Console.WriteLine("- Expensive");
                    Console.WriteLine("- How much");
                    Console.WriteLine("- Thirsty");
                    Console.WriteLine("- Hungry");
                    Console.WriteLine("- Sorry");
                    Console.WriteLine("- Yes");
                    Console.WriteLine("- No");
                    Console.WriteLine("- Leave");
                    Console.WriteLine("- Goodbye");
                    Console.WriteLine("");
                    Console.Write("Enter the English world to translate: ");
                    string word = Console.ReadLine();
                    Console.WriteLine("");
                    if (trns.ContainsKey(word))
                    {
                        Console.WriteLine($"Translation: {trns[word]}");
                    }
                    else { Console.WriteLine("Unavailable Word."); }
                    Console.WriteLine("");
                    Console.Write("Do you want to translate another word? (Y/N): ");
                    choice = Console.ReadLine();

                }
                Console.WriteLine("");
                Console.WriteLine("left the program");



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