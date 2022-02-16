namespace blastoff
{
    public class Q14{
        public static Boolean palindromo(string word){
            string firstHalf = word.Substring(0, word.Length / 2);
            char[] wordArray = word.ToCharArray();

            Array.Reverse(wordArray);

            string temporaryArray = new string(wordArray);
            string secondHalf = temporaryArray.Substring(0, temporaryArray.Length / 2);

            return firstHalf.Equals(secondHalf);

        }      
    }
}