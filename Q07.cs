namespace blastoff
{    public class Q07{
        public static int[] evensList(int[] numbersList){
            List<int> evensNumbersList = new List<int>();
            foreach(var number in numbersList){
                if (number % 2 == 0){
                    evensNumbersList.Add(number);
                }
            }
            return evensNumbersList.ToArray();
        }       
    }
}