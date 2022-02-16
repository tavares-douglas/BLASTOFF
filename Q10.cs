using System;
namespace blastoff
{    public class Q10{
        public static int Fatorial(){
            Console.Write("Entre com o numero:");
            int value = int.Parse(Console.ReadLine());
            for (int i = value - 1; i > 1; i--){
                value = value * i;
            }
            return value;
        }      
    }
}