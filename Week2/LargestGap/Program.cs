using LG;

class Program{
    static void Main(string[] args){
        LargestGap lg = new LargestGap();
        int[] testarray = {9,4,26,0,0,5,20,6,25,5};
        Console.WriteLine(lg.FindGap(testarray));
    }
}

