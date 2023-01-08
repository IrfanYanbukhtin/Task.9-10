namespace Task._9_10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 9.
            //Console.WriteLine("The lengh of massive");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int max = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"arr[{i}] =");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if  (arr[i] > arr[max])
            //            max =i;
            //}
            //Console.WriteLine(max);
            #endregion
            #region Task 10.
            Console.WriteLine("The lengh of massive");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] =");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= arr[min])
                    min = i;
            }
            Console.WriteLine(min);
            #endregion
        }
    }
}