namespace LG{
    public class LargestGap{

        public int FindGap(int[] intlist){
            Array.Sort(intlist);
            int lg = 0;
            for(int i = 1; i < intlist.Length; i++){
                if (intlist[i] - intlist[i - 1] > lg)
                {
                    lg = intlist[i] - intlist[i - 1];
                }
            }
            return lg;
        }
    }
}