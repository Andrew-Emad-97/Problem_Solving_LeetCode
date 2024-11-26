namespace LeetCode
{
    internal class VariableAfterOperations
    {
        public static void Run()
        {
            string[] operations = ["--X", "X++", "X++"];
            int result = FinalValueAfterOperations(operations);
            Console.WriteLine(result);
        }

        public static int FinalValueAfterOperations(string[] operations)
        {

            int sum= 0;

            foreach (string op in operations) 
            {
                if (op == "++X" || op == "X++")
                {
                    sum += 1;
                }
                else if (op == "X--" || op == "--X")
                {
                    sum -= 1;

                }
            }
            return sum;
        }
    }
}
