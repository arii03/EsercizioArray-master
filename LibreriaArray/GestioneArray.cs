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
        public static void RiempiArray()
        {
            Random random = new Random();
        }
        public static int[] Unisci()
        {

        }
    }
}
