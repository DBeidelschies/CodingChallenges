namespace MaximumSecond{
    public class MaxSecond{

        public int FindSecond(int x,int y, int z){
            List<int> list = new List<int>{x,y,z};
            list.Sort();
            return list[1];
        }
    }
}
