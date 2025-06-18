using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    

    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.Write("Enter the item number of an appliance: ");

            // Create long variable to hold item number
            long itemNumber = 0;

            // Get user input as string and assign to variable.
            // Convert user input from string to long and store as item number variable.
            string userInput = Console.ReadLine();
            long ItemNumber = long.Parse(userInput ?? "0");
            Console.WriteLine();

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance foundAppliance = null;

            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable
            foreach (var appliance in Appliances)
            {
                if (appliance.ItemNumber == ItemNumber)
                {
                    foundAppliance = appliance;
                    itemNumber = ItemNumber;
                    // Break out of loop (since we found what need to)
                    break;
                }
            }
            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number.");
            }
            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance
            else
            {
                if (foundAppliance.IsAvailable)
                {
                    foundAppliance.Checkout();
                    // Write "Appliance has been checked out."
                    Console.WriteLine($"Appliance '{itemNumber}' has been checked out.");
                }
                else
                {
                    // Otherwise (appliance isn't available)
                    // Write "The appliance is not available to be checked out."
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }

            
            
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.Write("Enter brand to search for: ");

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            string Brand;
            string? brand = Console.ReadLine();
            Console.WriteLine();

            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();

            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list
            foreach (var appliance in Appliances)
            {
                if (appliance.Brand.ToLower() == brand.ToLower())
                {
                    found.Add(appliance);
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"
            Console.WriteLine("0 - Any");
            Console.WriteLine("2 - Double doors");
            Console.WriteLine("3 - Three doors");
            Console.WriteLine("4 - Four doors");

            // Write "Enter number of doors: "
            Console.Write("Enter number of doors: ");

            // Get user input as string and assign to variable
            string input = Console.ReadLine();
            Console.WriteLine('\n');

            // Convert user input from string to int and store as number of doors variable.
            int numDoors = int.Parse(input ?? "0");

            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();

            // Iterate/loop through Appliances
            // Test that current appliance is a refrigerator
            // Down cast Appliance to Refrigerator
            // Refrigerator refrigerator = (Refrigerator) appliance;
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Refrigerator refrigerator)
                {
                    // Test user entered 0 or refrigerator doors equals what user entered.
                    // Add current appliance in list to found list
                    if (numDoors == 0 || refrigerator.Doors == numDoors)
                    {
                        found.Add(appliance);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Residential");
            Console.WriteLine("2 - Commercial");

            // Write "Enter grade:"
            Console.Write("Enter grade: ");

            // Get user input as string and assign to variable
            string gradeInput = Console.ReadLine();
            Console.WriteLine('\n');

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade = "Any";

            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."
            if (gradeInput == "0") grade = "Any";
            else if (gradeInput == "1") grade = "Residential";
            else if (gradeInput == "2") grade = "Commercial";
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - 18 Volt");
            Console.WriteLine("2 - 24 Volt");

            // Write "Enter voltage:"
            Console.Write("Enter voltage: ");

            // Get user input as string
            // Create variable to hold voltage
            string? voltageInput = Console.ReadLine();
            int voltage = 0;
            Console.WriteLine('\n');

            // Test input is "0"
            // Assign 0 to voltage
            // Test input is "1"
            // Assign 18 to voltage
            // Test input is "2"
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;
            if (voltageInput == "0") voltage = 0;
            else if (voltageInput == "1") voltage = 18;
            else if (voltageInput == "2") voltage = 24;
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            // Create found variable to hold list of found appliances.
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Vacuum vacuum)
                {
                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                    // Add current appliance in list to found list
                    if ((grade == "Any" || vacuum.Grade == grade) &&
                       (voltage == 0 || vacuum.BatteryVoltage == voltage))
                    {
                        found.Add(appliance);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Kitchen");
            Console.WriteLine("2 - Work site");

            // Write "Enter room type:"
            Console.Write("Enter room type: ");

            // Get user input as string and assign to variable
            // Create character variable that holds room type
            string? input = Console.ReadLine();
            char roomType = 'A';
            Console.WriteLine('\n');

            // Test input is "0"
            // Assign 'A' to room type variable
            // Test input is "1"
            // Assign 'K' to room type variable
            // Test input is "2"
            // Assign 'W' to room type variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            // return;
            if (input == "0") roomType = 'A';
            else if (input == "1") roomType = 'K';
            else if (input == "2") roomType = 'W';
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            // Create variable that holds list of 'found' appliances
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Microwave microwave)
                {
                    // Test room type equals 'A' or microwave room type
                    // Add current appliance in list to found list
                    if (roomType == 'A' || microwave.RoomType == roomType)
                    {
                        found.Add(appliance);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Quietest");
            Console.WriteLine("2 - Quieter");
            Console.WriteLine("3 - Quiet");
            Console.WriteLine("4 - Moderate");

            // Write "Enter sound rating:"
            Console.Write("Enter sound rating: ");

            // Get user input as string and assign to variable
            string input = Console.ReadLine();
            Console.WriteLine('\n');

            // Create variable that holds sound rating
            string soundRating = "Any";

            // Test input is "0"
            // Assign "Any" to sound rating variable
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            // Test input is "4"
            // Assign "M" to sound rating variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            if (input == "0") soundRating = "Any";
            else if (input == "1") soundRating = "Qt";
            else if (input == "2") soundRating = "Qr";
            else if (input == "3") soundRating = "Qu";
            else if (input == "4") soundRating = "M";
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            // Create variable that holds list of found appliances
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Dishwasher dishwasher)
                {
                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                    // Add current appliance in list to found list
                    if (soundRating == "Any" || dishwasher.SoundRating == soundRating)
                    {
                        found.Add(appliance);
                    }
                }
            }
            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"
            Console.WriteLine("Appliance Types");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 – Refrigerators");
            Console.WriteLine("2 – Vacuums");
            Console.WriteLine("3 – Microwaves");
            Console.WriteLine("4 – Dishwashers");

            // Write "Enter type of appliance:"
            Console.Write("Enter type of appliance: ");

            // Get user input as string and assign to appliance type variable
            string typeInput = Console.ReadLine();
            Console.WriteLine('\n');

            // Write "Enter number of appliances: "
            Console.Write("Enter number of appliances: ");

            // Get user input as string and assign to variable
            string countInput = Console.ReadLine();
            Console.WriteLine();

            // Convert user input from string to int
            int num = int.Parse(countInput ?? "0");

            // Create variable to hold list of found appliances
            List<Appliance> found = new List<Appliance>();

            // Loop through appliances
            // Test inputted appliance type is "0"
            // Add current appliance in list to found list
            // Test inputted appliance type is "1"
            // Test current appliance type is Refrigerator
            // Add current appliance in list to found list
            // Test inputted appliance type is "2"
            // Test current appliance type is Vacuum
            // Add current appliance in list to found list
            // Test inputted appliance type is "3"
            // Test current appliance type is Microwave
            // Add current appliance in list to found list
            // Test inputted appliance type is "4"
            // Test current appliance type is Dishwasher
            // Add current appliance in list to found list
            foreach (Appliance appliance in Appliances)
            {
                if (typeInput == "0")
                {
                    found.Add(appliance);
                }
                else if (typeInput == "1" && appliance is Refrigerator)
                {
                    found.Add(appliance);
                }
                else if (typeInput == "2" && appliance is Vacuum)
                {
                    found.Add(appliance);
                }
                else if (typeInput == "3" && appliance is Microwave)
                {
                    found.Add(appliance);
                }
                else if (typeInput == "4" && appliance is Dishwasher)
                {
                    found.Add(appliance);
                }
            }

            // Randomize list of found appliances
            found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, num);
        }
    }
}
