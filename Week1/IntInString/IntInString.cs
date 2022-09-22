namespace InInString{
    public class StringInt{


        public int GetSumInString(string str){
            int count = 0;
            int digit;
            foreach (char s in str)
            {
                if(Int32.TryParse(s.ToString(), out digit)){
                    count += digit;
                }
            }
            return count;
        }
    }
}