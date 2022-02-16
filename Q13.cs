namespace blastoff
{
    public class Q13{
        public static void printMatrix(int[,] matrix){
            int linesAmount = matrix.GetLength(0);
            int columnsAmount = matrix.GetLength(1);
            for (int i = 0; i < linesAmount; i++)
            {
                for (int z = 0; z < columnsAmount; z++)
                {
                    Console.Write(matrix[i, z] + " ");
                }
                Console.WriteLine("");
            }

        }      
    }
}