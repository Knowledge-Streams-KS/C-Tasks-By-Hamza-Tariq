namespace Helper
{
    public class Helper
    {

        public static void Age() {
            Console.WriteLine("Enter your age in years : ");
            int age = Convert.ToInt32(Console.ReadLine());
            var x = age * 365;
            Console.WriteLine("Your age in days is : " + x);
        }


        public static void Sumarry()
        {
            int[] arr = { 1, 2, 3, 4, 5, 7 };
            int sum = arr.Sum();
            Console.WriteLine("Sum of Array : " + sum);

        }
        public static void Frequency()
        {
            int[] array = { 1, 2, 3, 4, 3, 4, 3, 2, 1, 5, 6, 7, 5, 6 };
            int n = array.Length;
            for (int i = 0; i < n; i++) {
                int C = 1;
                for (int j = 0; j < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        C++;
                        Console.WriteLine(array[i] + " " + C);
                    }
                }


}

        }
        
            


        
    public static void Reverse()
    {
            char[] Ks = { 'k', 'n', 'o', 'w', 'l', 'e', 'd', 'g', 'e', 's', 't', 'r', 'e', 'm' };

            char[] reverse = Ks.Reverse().ToArray();

            foreach (char chr in reverse)
            {
                Console.Write(chr + " ");
            }

        }


        public static void checkValus()
        {
            List<int> num = new List<int>() { 1, 2, 2, 2, 2, 2 };

            bool num2 = num.Distinct().Count() == 1;


            {

                Console.WriteLine(num2);
            }
        }    
        public static void Remove()
        {
            var list = new List<string> { "abc", "def", "ghj", "kli", "adkja" };
            int indextoremove = 1;
            list.RemoveAt(indextoremove);
            Console.Write(list);



        }
    }  
}