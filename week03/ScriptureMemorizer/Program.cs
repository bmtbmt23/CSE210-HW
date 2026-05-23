using System;

class Program
{
    public static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture (new Reference ("John" 3, 16) ("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture (new Reference ("Proverbs" 3,5-6) ("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture (new Reference ("Alma" 32, 21) ("And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."),
        };
       
        Random random = new Random();
       
        Scripture scripture = scriptures[random.Next(scriptures.Count)];
       
        while(!scripture.CompletedHidden())
        {
            Console.Clear();
           
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
           
            Console.WriteLine("Press Enter to continue or type quit to end.");
            string quit = Console.ReadLine();
           
            if(quit.ToLower() == "quit")
            {
                break;
            }
       
            scripture.HideWords(3);
        }
       
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
       
        Console.WriteLine("Thanks! Program is end.");
        string end = Console.ReadLine();
       
        Console.ReadKey();
       
    }
}