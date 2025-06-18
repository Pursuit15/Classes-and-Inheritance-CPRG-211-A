namespace ModernAppliances
{
    internal class Program
    {
        /// <summary>
        /// Entry point to program
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            ModernAppliances modernAppliances = new MyModernAppliances();
            ModernAppliances.Options option = ModernAppliances.Options.None;
            
            while (option != ModernAppliances.Options.SaveExit)
            {
                modernAppliances.DisplayMenu();

                string input = Console.ReadLine();
                
                // Better input validation
                if (!int.TryParse(input, out int optionValue) || !Enum.IsDefined(typeof(ModernAppliances.Options), optionValue))
                {
                    Console.WriteLine("Invalid option entered. Please try again.");
                    Console.WriteLine();
                    continue;
                }

                option = (ModernAppliances.Options)optionValue;
                
                switch (option)
                {
                    case ModernAppliances.Options.Checkout:
                    {
                        modernAppliances.Checkout();
                        break;
                    }
                    case ModernAppliances.Options.Find:
                    {
                        modernAppliances.Find();
                        break;
                    }
                    case ModernAppliances.Options.DisplayType:
                    {
                        modernAppliances.DisplayType();
                        break;
                    }
                    case ModernAppliances.Options.RandomList:
                    {
                        modernAppliances.RandomList();
                        break;
                    }
                    case ModernAppliances.Options.SaveExit:
                    {
                        modernAppliances.Save();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid option entered. Please try again.");
                        break;
                    }
                }
                
                Console.WriteLine();
            }
        }
    }
}