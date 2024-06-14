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
        /// Option 1: Performs a checkout (DONE)
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance: ");
            // Get user input as string and assign to variable.
            string inputNum = Console.ReadLine();
            // Create long variable to hold item number
            long itemNumber;
            // Convert user input from string to long and store as item number variable.
            itemNumber = long.Parse(inputNum);
            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance foundAppliance = null;            
            // Loop through Appliances
                // Test appliance item number equals entered item number
                    // Assign appliance in list to foundAppliance variable
                    // Break out of loop (since we found what need to)
            foreach (Appliance appliance in Appliances){
                if (appliance.ItemNumber == itemNumber){
                    foundAppliance = appliance;
                    break;
                }
            }
            // Test appliance was not found (foundAppliance is null)
                // Write "No appliances found with that item number."
            if (foundAppliance == null){
                Console.WriteLine("No appliances found with that item number.");
            }
            // Otherwise (appliance was found)
                // Test found appliance is available
                    // Checkout found appliance

            // Write "Appliance has been checked out."
            // Otherwise (appliance isn't available)
                // Write "The appliance is not available to be checked out."
            else{
                if (foundAppliance.IsAvailable){
                    foundAppliance.Checkout();
                    Console.WriteLine("Appliance has been checked out.");
                }
                else{
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }
        }

        /// <summary>
        /// Option 2: Finds appliances (DONE)
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter Brand to search for: ");
            
            // Create string variable to hold entered brand
            string brandName = Console.ReadLine();
            
            // Get user input as string and assign to variable.
            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();

            // Iterate through loaded appliances
                // Test current appliance brand matches what user entered
                    // Add current appliance in list to found list
            foreach(Appliance appliance in Appliances){
                if(appliance.Brand == brandName){
                    foundAppliances.Add(appliance);
                }
            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances,0);
        }

        /// <summary>
        /// Displays Refridgerators (DONE)
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: \n 0 - Any \n 2 - Double doors \n 3 - Three doors \n 4 - Four doors");
            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"

            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: ");
            // Create variable to hold entered number of doors
            int numDoors = int.Parse(Console.ReadLine());
            // Get user input as string and assign to variable
            
            // Convert user input from string to int and store as number of doors variable.
            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();
            // Iterate/loop through Appliances
            foreach(Appliance appliance in Appliances)
            {
                if(appliance.Type == Appliance.ApplianceTypes.Refrigerator)
                {
                    Refrigerator refrigerator = (Refrigerator)appliance;
                    if(numDoors == 0 || numDoors == refrigerator.Doors)
                    {
                        foundAppliances.Add(appliance);
                    }
                }
            }
                // Test that current appliance is a refrigerator
                    // Down cast Appliance to Refrigerator
                    // Refrigerator refrigerator = (Refrigerator) appliance;
              
                    // Test user entered 0 or refrigerator doors equals what user entered.
                        // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances,0);
        }

        /// <summary>
        /// Displays Vacuums (DONE)
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: \n 0 - Any \n 1 - Residential \n 2 - Commercial");
            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"

            // Write "Enter grade:"
            Console.WriteLine("Enter grade: ");
            // Get user input as string and assign to variable
            string gradeInput = Console.ReadLine();
            string grade;
            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            // Test input is "0"
                // Assign "Any" to grade
            if(gradeInput == "0")
            {
                grade = "Any";
            }
            // Test input is "1"
                // Assign "Residential" to grade
            else if(gradeInput == "1")
            {
                grade = "Residential";
            }
            // Test input is "2"
                // Assign "Commercial" to grade
            else if(gradeInput == "2")
            {
                grade = "Commercial";
            }
            // Otherwise (input is something else)
                // Write "Invalid option."
            else
            {
                Console.WriteLine("Invalid Option");
                return;
            }

                // Return to calling (previous) method
                // return;

            // Write "Possible options:"
            Console.WriteLine("Possible options: \n 0 - Any \n 1 - 18 Volt \n 2 - 24 Volt");
            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"

            // Write "Enter voltage:"
            Console.WriteLine("Enter Voltage: ");
            // Get user input as string
            string voltInput = Console.ReadLine();
            int volt;
            // Create variable to hold voltage
            // Test input is "0"
            if (voltInput == "0")
            {
                volt = 0;
            }
                // Assign 0 to voltage
            // Test input is "1"
            else if (voltInput == "1")
            {
                volt = 18;
            }
                // Assign 18 to voltage
            // Test input is "2"
            else if (voltInput == "2")
            {
                volt = 24;
            }
                // Assign 24 to voltage
            // Otherwise
                // Write "Invalid option."
            else
            {
                Console.WriteLine("Invalid Option");
                return;
            }
                // Return to calling (previous) method
                // return;

            // Create found variable to hold list of found appliances.
            List<Appliance> foundAppliances = new List<Appliance>();

            foreach(Appliance appliance in Appliances){
                if(appliance.Type == Appliance.ApplianceTypes.Vacuum){
                    Vacuum vacuum = (Vacuum)appliance;
                    if((grade == "Any" || grade == vacuum.Grade) && (volt == 0 || volt == vacuum.BatteryVoltage)){
                        foundAppliances.Add(appliance);
                    }
                }
            }
            // Loop through Appliances
                // Check if current appliance is vacuum
                    // Down cast current Appliance to Vacuum object
                    // Vacuum vacuum = (Vacuum)appliance;

                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                        // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances,0);
        }

        /// <summary>
        /// Displays microwaves (DONE)
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: \n 0 - Any \n 1 - Kitchen \n 2 - Work site");
            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"

            // Write "Enter room type:"
            Console.WriteLine("Enter room type: ");
            // Get user input as string and assign to variable
            string roomInput = Console.ReadLine();
            // Create character variable that holds room type
            char roomType;
            // Test input is "0"
                // Assign 'A' to room type variable
                if (roomInput == "0")
            {
                roomType = 'A';
               
            }
            // Test input is "1"
                // Assign 'K' to room type variable
                if (roomInput == "1")
            {
                roomType = 'K';
               
            }
            // Test input is "2"
                // Assign 'W' to room type variable
            if (roomInput == "2")
            {
                roomType = 'W';
               
            }
            // Otherwise (input is something else)
            // Write "Invalid option."
            else
            {
                Console.WriteLine("Invalid Option");
                return;
            }
                // Return to calling method
                // return;

            // Create variable that holds list of 'found' appliances
            List<Appliance> foundAppliances = new List<Appliance>();
            // Loop through Appliances
            foreach(Appliance appliance in Appliances)
            {
                if(appliance.Type == Appliance.ApplianceTypes.Microwave)
                {
                    Microwave microwave = (Microwave)appliance;
                    if(roomType == 'A' || roomType == microwave.RoomType)
                    {
                        foundAppliances.Add(appliance);
                    }
                }
            }
                // Test current appliance is Microwave
                    // Down cast Appliance to Microwave

                    // Test room type equals 'A' or microwave room type
                        // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances,0);
        }

        /// <summary>
        /// Displays dishwashers (DONE)
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: \n 0 - Any \n 1 - Quietest \n 2 - Quieter \n 3 - Quiet \n 4 - Moderate");
            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"

            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating: ");
            // Get user input as string and assign to variable
            string soundInput = Console.ReadLine();
            // Create variable that holds sound rating
            string soundRating;
            // Test input is "0"
                // Assign "Any" to sound rating variable
            if(soundInput == "0"){
                soundRating = "Any";
            }
            // Test input is "1"
                // Assign "Qt" to sound rating variable
            else if(soundInput == "1"){
                soundRating = "Qt";
            }
            // Test input is "2"
                // Assign "Qr" to sound rating variable
            else if(soundInput == "2"){
                soundRating = "Qr";
            }
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            else if(soundInput == "3"){
                soundRating = "Qu";
            }
            // Test input is "4"
            // Assign "M" to sound rating variable
            else if(soundInput == "4"){
                soundRating = "M";
            }
            // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method
            else{
                Console.WriteLine("Invalid Option.");
                return;
            }

            // Create variable that holds list of found appliances
            List<Appliance> foundAppliances = new List<Appliance>();

            // Loop through Appliances
            foreach(Appliance appliance in Appliances){
                if(appliance.Type == Appliance.ApplianceTypes.Dishwasher){
                    Dishwasher dishwasher = (Dishwasher)appliance;
                    if(soundRating == "Any" || soundRating == dishwasher.SoundRating){
                        foundAppliances.Add(appliance);
                    }
                }
            }
                // Test if current appliance is dishwasher
                    // Down cast current Appliance to Dishwasher

                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                        // Add current appliance in list to found list

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances,0);
        }

        /// <summary>
        /// Generates random list of appliances (DONE)
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types: \n 0 - Any \n 1 - Refigerators \n 2 - Vacuums \n 3 - Microwaves \n 4 - Dishwashers");
            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"
            // Write "Enter type of appliance:"
            // Write "Enter type of appliance:"
            Console.WriteLine("Enter type of appliance: ");

            // Get user input as string and assign to appliance type variable
            string applianceType = Console.ReadLine();
            // Write "Enter number of appliances: 
            Console.WriteLine("Enter number of appliances: ");      

            // Get user input as string and assign to variable
            int num = int.Parse(Console.ReadLine());
            // Convert user input from string to int

            // Create variable to hold list of found appliances
            List<Appliance> foundAppliances = new List<Appliance>();
            // Loop through appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test inputted appliance type is "0"
                    // Add current appliance in list to found list
                if (applianceType == "0")
                {
                    foundAppliances.Add(appliance);
                }
                // Test inputted appliance type is "1"
                    // Test current appliance type is Refrigerator
                else if (applianceType == "1")
                {
                    if(appliance.Type == Appliance.ApplianceTypes.Refrigerator){
                        foundAppliances.Add(appliance);
                    }
                }
                        // Add current appliance in list to found list
                // Test inputted appliance type is "2"
                    // Test current appliance type is Vacuum
                else if (applianceType == "2")
                {
                    if(appliance.Type == Appliance.ApplianceTypes.Vacuum){
                        foundAppliances.Add(appliance);
                    }
                }
                        // Add current appliance in list to found list
                // Test inputted appliance type is "3"
                    // Test current appliance type is Microwave
                else if (applianceType == "3")
                {
                    if(appliance.Type == Appliance.ApplianceTypes.Microwave){
                        foundAppliances.Add(appliance);
                    }
                }
                        // Add current appliance in list to found list
                // Test inputted appliance type is "4"
                    // Test current appliance type is Dishwasher
                else if (applianceType == "4")
                {
                    if(appliance.Type == Appliance.ApplianceTypes.Dishwasher){
                        foundAppliances.Add(appliance);
                    }
                }
                        // Add current appliance in list to found list
            }
            // Randomize list of found appliances
            // found.Sort(new RandomComparer());

            foundAppliances.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);

            DisplayAppliancesFromList(foundAppliances, num);
        }
    }
}
