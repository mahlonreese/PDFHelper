// looks great, very interesting project

namespace CodeJam4
{
    internal class Program
    {
        public static void Main()
        {
            // Print app title and start menu
            Helpers.PrintStartMenu();

            // Prompt user to choose from menu
            string? choice = Helpers.GetUserInput("\n➡️ Select:");

            // User choice input validation
            while (true)
            {
                if (string.IsNullOrEmpty(choice) || (choice != "1" && choice != "2"))
                {
                    Helpers.SetConsoleColor("red");
                    Console.WriteLine("❌ Please enter 1 or 2\n");
                    Helpers.ResetConsoleColor();
                    choice = Helpers.GetUserInput("➡️ Select:");
                }
                else break;
            }
            Console.WriteLine();

            // Handle user choice
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    AppLogic.OptPdfToText();
                    break;
                case "2":
                    Console.Clear();
                    AppLogic.OptTextToPdf();
                    break;
            }

            // Prompt user to quit or restart
            Helpers.EndOfProgram();
        }
    }
}
