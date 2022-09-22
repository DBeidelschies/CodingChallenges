using InInString;

class Program{
    static void Main(string[] args){
        StringInt digit = new StringInt();
        Menu(digit);
    }

    public static void Menu(StringInt number){
        bool test =true;
        while(test){
            Console.WriteLine("Would you like to use this program.[y/n]");
            string answer = Console.ReadLine();
            if(answer == "y"){
                Console.WriteLine("Enter a string with some digits in between");
                string input = Console.ReadLine();
                Console.WriteLine(number.GetSumInString(input));
            }
            else if(answer == "n"){
                test = false;
            }
            else{
                Console.WriteLine("Please enter a valid answer.");
            }
        }
        
    }
}

