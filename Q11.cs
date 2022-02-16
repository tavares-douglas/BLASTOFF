using System;
namespace blastoff
{    public class Q11{
        public static int[] Intersection(int[] listA, int[] listB){
            List<int> intersectionValues = new List<int>();
            foreach(int valueA in listA){
                foreach(int valueB in listB){
                    if(valueA == valueB){
                        intersectionValues.Add(valueA);
                    }
                }
            }
            return intersectionValues.ToArray();
        }      
    }
}