using System;

namespace LibreriaArray
{
    public class GestioneArray
    {
        public static void LeggiArray(int[] array)
        {
            for (int x = 0; x < array.Length; x++)
            {
                Console.WriteLine($"Inserire il numero {x}");
                int a = int.Parse(Console.ReadLine());
                array[x] = a;
            }
        }
        public static void StampaArray(int[] array)
        {
            Console.Write("Il contenuto dell'array è: ");
            for (int x = 0; x < array.Length; x++)
            {
                Console.Write(array[x] + " ");
            }
            Console.WriteLine();
        }
        public static int[] CopiaArray(int[] array)
        {
            int[] array2 = new int[array.Length];
            for (int x = 0; x < array.Length; x++)
            {
                array2[x] = array[x];
            }
            return array2;
        }
        public static void RiempiArray(int[] array)
        {
            Random random = new Random();
            for (int x = 0; x < array.Length; x++)
            {
                array[x] = random.Next();
            }
        }
        public static int[] Unisci(int[] array, int[] array2)
        {
            int[] Merge = new int[array.Length + array2.Length];
            for (int i = 0; i < array.Length; i++)
            {
                Merge[i] = array[i];
            }
            for (int i = array.Length + 1; i < Merge.Length; i++)
            {
                Merge[i] = array2[i - array.Length];
            }
            return Merge;
        }
    }
}
