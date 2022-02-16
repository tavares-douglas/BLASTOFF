namespace blastoff
{
    public class Q08{
        public static Boolean cousinNumber(){
            Console.Write("Entre com o numero a ser verificado:");
            int value = int.Parse(Console.ReadLine());
            Boolean cousin = true;
            for (int i = 2; i < value; i++){
                if(value % 2 == 0){
                    cousin = false;
                    break;
                }
            }
            return cousin;

        }      
    }
}