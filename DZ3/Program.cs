using ClassLibraryDZ3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayOperations arr=new ArrayOperations();
            arr.FillArray(5, 5);
            arr.PrintArray();
            Console.WriteLine("Cумма между максимальным и минимальными элементами: "+arr.GetSumBetweenMinAndMax());
            Console.ReadKey();

            int[,] array1 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
            };

            int[,] array2 = {
            {3, 4, 5},
            {6, 7, 8},
            {9, 10, 11}
            };

            int[,] commonArray = arr.FindCommonElements(array1, array2);

            Console.WriteLine("Общие элементы массивов без повторений:");
            for (int i = 0; i < commonArray.GetLength(0); i++)
            {
                Console.Write(commonArray[i, 0]+" ");
            }
            Console.ReadKey();

            StringOperations _text= new StringOperations();
            StringOperations text2 = new StringOperations();

            Console.WriteLine("Введите текст: ");
            string text=Console.ReadLine();

            Console.WriteLine("Кол-во гласных букв в тексте: "+_text.findingVowels(text));
            Console.ReadKey();


            Console.WriteLine("Введите предложение:");
            string input = Console.ReadLine();
            string reversedSentence = text2.ReverseWords(input);
            Console.WriteLine("Результат: " + reversedSentence);

            Console.ReadKey();

            Console.WriteLine("Введите текст:");
            string input1 = Console.ReadLine();
            string capitalizedText = _text.CapitalizeSentences(input1);
            Console.WriteLine("Результат: " + capitalizedText);

            Console.ReadKey();

        }
    }
}
