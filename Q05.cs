namespace blastoff
{    public class Q05{
        public static Boolean multipleValues(double a, double b){
            double higherValue = a;
            double lowerValue = b;
            if (b > a){
                higherValue = b;
                lowerValue = a;
            }

            if (higherValue % lowerValue == 0){
                return true;
            }
            else{
                return false;
            }

        }       
    }
}