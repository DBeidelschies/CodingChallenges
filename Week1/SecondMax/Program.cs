using MaximumSecond;

class Program{
    static void Main(string[] args){
        MaxSecond sec = new MaxSecond();
        Menu(sec);
    }
    public static void Menu(MaxSecond number){
        bool test =true;
        while(test){
            Console.WriteLine("Would you like to use this program.[y/n]");
            string answer = Console.ReadLine();
            if(answer == "y"){
                Console.WriteLine("Enter three numbers of different values");
                string input = Console.ReadLine();
                string[] str = input.Split();
                if(str.Length == 3){
                    List<int> i = new List<int>();
                    int digit;
                    foreach(string s in str){
                        if(Int32.TryParse(s, out digit)){
                            i.Add(digit);
                        }
                        else{
                            Console.WriteLine("Please enter three Numbers of different values");
                            break;
                        }
                    }
                    Console.WriteLine(number.FindSecond(i[0],i[1],i[2]));
                }
                else{
                    Console.WriteLine("Please enter Three numbers of different values");
                }
                
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
