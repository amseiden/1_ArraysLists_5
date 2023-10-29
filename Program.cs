/*
 Write a program and ask the user to supply a list of comma separated numbers ( 5, 1, 9, 2, 10).
 If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
 otherwise, display the 3 smallest numbers in the list.
 */
 
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        bool ruleaza = true;

        while (ruleaza)
        {
            Console.WriteLine("\nEnter comma-separated numbers: ");
            string userInput = Console.ReadLine();
            if (userInput == "")
                ruleaza = false;
            else 
            {
                char delimiter = ',';

                string[] numberStrings = userInput.Split(delimiter);
                foreach (string number in numberStrings)
                {
                    int.TryParse(number, out int myNumber);
                    numbers.Add(myNumber);
                }

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List");
                }
                else
                {
                    numbers.Sort();
                    Console.WriteLine(numbers);
                    // Console.WriteLine(numbers.GetRange(0,3));
                    ruleaza = false;
                }
            }
        }
    }
}