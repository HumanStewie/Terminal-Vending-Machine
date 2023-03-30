// first simple console app

public class VendingMachine
{
    public static void Main()
    {
        while (true)
        {
            Products();
            Console.WriteLine("Press Enter to restart the program.\n");
            Console.ReadKey();
            continue;
        }
        Console.ReadKey();
    }

    public static void Products()
    {      
        Console.Title = "Vending Machine";  
        Console.WriteLine("What drinks would you like?\n1.CocaCola\n2.Fanta\n3.Pepsi\nYour choice:");
        string userInput = Console.ReadLine()!;
        int userInputasInt;
        int num;
        // prevent program from crashing
        if (Int32.TryParse(userInput, out num))
        {
            userInputasInt = num;
        }
        else { // if unable to Parse, tell the user.
            userInputasInt = 0;
            Console.WriteLine("Please enter a valid number.");
        }
        // userInputasInt use the value 0 as above
        
        // results
        if (userInputasInt == 1) {
                Console.WriteLine("Here's your Coca Cola.");
        } else if (userInputasInt == 2){
                Console.WriteLine("Here's your Fanta");
        } else if (userInputasInt == 3){
                Console.WriteLine("Here's your Pepsi");
        } else if (userInputasInt > 3) { // cant use else here since we assigned userInputasInt = 0 above.
                Console.WriteLine("Invalid number, please make sure you entered the correct number.");
        }
        
        
    }
    
}

