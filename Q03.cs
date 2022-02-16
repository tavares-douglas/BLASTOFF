namespace blastoff
{    public class Q03{
        public static int lowestValue(int[] values){
            int lowestValue = 999999999;
            
            foreach(var value in values){
                if (value < lowestValue){
                    lowestValue = value;
                }
            }

            return lowestValue;
        }       
    }
}