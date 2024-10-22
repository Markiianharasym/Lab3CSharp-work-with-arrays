namespace Lab3CSharp_work_with_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n count:");

            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the element of array {i + 1}:");
                array[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(array);

            double arrayMin = array[0];
            double arrayMax = array[array.Length - 1];
            int k = 0;
            Console.WriteLine("\n");
            foreach (double element in array)
            {
                Console.WriteLine($"Element number {k + 1} of array is:" + element);
                k++;
            }

            double elementsSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                elementsSum += array[i];
              
            }
            elementsSum = elementsSum - arrayMin - arrayMax;
            Console.WriteLine("\n Sums of array without min and max value =" + elementsSum);
            Console.ReadKey();

        }
    }
}
