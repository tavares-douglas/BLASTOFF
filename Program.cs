using System;

namespace blastoff
{
    class Program{      
        
        static void Main(string[] args)
        {
            Q01 question1 = new Q01();
            float average = blastoff.Q01.averageCalculate(1, 2, 3, 4, 5);

            Q02 question2 = new Q02();
            string consumption = blastoff.Q02.consumptionCalculate(50,4);

            Q03 question3 = new Q03();
            int menorValor = blastoff.Q03.lowestValue(new int[]{5,10,15});

            Q04 question4 = new Q04();
            double farenheitTemperature = blastoff.Q04.celsiusToFarenheit(35);

            Q05 question5 = new Q05();
            Boolean isMultiple = blastoff.Q05.multipleValues(10,2);

            Q06 question6 = new Q06();
            string matchDuration = blastoff.Q06.matchDuration("21:10", "01:05");

            Q07 question7 = new Q07();
            int[] wholeList = new int[8]{1, 2, 3, 5, 6, 12, 10,15};
            // int[] evensList = blastoff.Q07.evensList(wholeList);
            // foreach(int value in evensList){
            //     Console.Write(value + "");
            // }
            // Console.WriteLine("");
            
            
            Q08 question8 = new Q08();
            // Boolean cousin = blastoff.Q08.cousinNumber();

            Q09 question9 = new Q09();
            // Boolean numbersTable = blastoff.Q09.numberTable();


            Q10 question10 = new Q10();
            // int fatorialValue = blastoff.Q10.Fatorial();
            // Console.WriteLine(fatorialValue);

            Q11 question11 = new Q11();
            int[] listA = new int[4]{1,2,3,4};
            int[] listB = new int[4]{1,2,5,8};
            int[] intersection = blastoff.Q11.Intersection(listA, listB);
            foreach(int value in intersection){
                    Console.Write(value + " ");
            }
            Console.WriteLine();

            Q12 question12 = new Q12();
            int[] listC = new int[4]{1,2,3,4};
            int[] listD = new int[4]{1,2,5,8};
            // int[] concatanation = blastoff.Q12.Concatanate(listC, listD);
            // foreach(int value in concatanation){
            //     Console.Write(value + " ");
            // }
            // Console.WriteLine();

            Q13 question13 = new Q13();
            int[,] matrix = new int[2, 3] { { 1, 1, 1}, {2, 2, 2} };
            // blastoff.Q13.printMatrix(matrix);   

            Q14 question14 = new Q14();
            // Boolean palindromo = blastoff.Q14.palindromo("osso");
            // Console.Write(palindromo);
            
        }
    }
}
// See https://aka.ms/new-console-template for more information

