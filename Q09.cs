using System;
namespace blastoff
{    public class Q09{
        public static Boolean numberTable(){
            Console.Write("Entre com o numero:");
            int value = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++){
                Console.WriteLine(value * i);
            }
            return true;
        }      
    }
}