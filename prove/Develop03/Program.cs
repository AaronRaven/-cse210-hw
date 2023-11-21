using System;

class Program
{
        Reference ref1 = new Reference("John",3,16);
        Scripture scrip1 = new Scripture(ref1, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        string line = "enter";
        Reference ref2 = new Reference("Proverbs", 3,5,6);
        Scripture scrip2 = new Scripture(ref2,"Trust in the LORD with all your heart and lean not on your own understanding;in all your ways submit to him, and he will make your paths straight");
        Reference ref3 = new Reference("Phillipians", 4,13);
        Scripture scrip3 = new Scripture(ref3, "I can do all this through him who gives me strength.");

        List<Scripture> scripList = new List<Scripture>();

        scripList.Add(scrip1);
        scripList.Add(scrip2);
        scripList.Add(scrip3);

        Random sort = new Random();
        int num = sort.Next(0,scripList.Count());

        Scripture scripchosen = new Scripture(scripList[num].GetReference(), scripList[num].GetReference().GetDisplayText());
        scripchosen = scripList[num];


        bool hidden = scripchosen.IsCompletelyHidden();
      
    static void Main(string[] args)
    {
  
        string input = "";
        while (input != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();


            if (input == "")
            {
                if (scripture.GetIsFullyHidden() == false)
                {
                    scripture.HideWords();
                }
                else
                {
                    break;
                }
            }
        }
    }
}