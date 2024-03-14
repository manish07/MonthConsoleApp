class MonthApp {
    public static void MonthDisplayApp(string userResponse) {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        Console.WriteLine($"User input: {userResponse}");
        if(string.IsNullOrWhiteSpace(userResponse)){
            Console.WriteLine("Please enter a valid month.");
            return;
        }

        if (userResponse.Equals("All", StringComparison.OrdinalIgnoreCase)) {
            Console.Write("Display all month: " + string.Join(", ", months));
            Console.WriteLine();
        }
        else {
            int.TryParse(userResponse, out int userInput);

            if (userInput >=1 && userInput <= 12) {
                Console.WriteLine($"{userInput} is {months[userInput - 1]}");
            }
            else {
                if(userInput is int && userInput != 0) {
                    Console.WriteLine($"{userInput} is not a valid input.");
                }
                else {
                    Console.WriteLine($"\"{userResponse}\" user input is not a valid input.");
                }
            }
        }
        Console.WriteLine();
    }
}