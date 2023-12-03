using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDZ3
{
    public class ArrayOperations
    {
        private int[,] arr;

        /// <summary>
        /// Заполняет массив случайными числами от -100 до 100
        /// </summary>
        /// <param name="rows">строки</param>
        /// <param name="columns">столбцы</param>
        public void FillArray(int rows, int columns)
        {
            arr = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = random.Next(-100, 100);
                }
            }
        }

        /// <summary>
        /// Выводит массив в конслоль
        /// </summary>
        public void PrintArray()
        {
            if (arr == null)
            {
                Console.WriteLine("Массив не был заполнен.");
                return;
            }

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Находит сумму между максимальными и минимальными элементами в двухмерном массиве
        /// </summary>
        /// <returns>Сумму элементов</returns>
        public int GetSumBetweenMinAndMax()
        {
            if (arr == null)
            {
                Console.WriteLine("Массив не был заполнен.");
                return 0;
            }

            int min = arr[0, 0];
            int max = arr[0, 0];
            int minRowIndex = 0;
            int minColIndex = 0;
            int maxRowIndex = 0;
            int maxColIndex = 0;

            // Поиск минимального и максимального элементов
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minRowIndex = i;
                        minColIndex = j;
                    }
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxRowIndex = i;
                        maxColIndex = j;
                    }
                }
            }

            int sum = 0;
            int startRow, endRow, startCol, endCol;

            // Определение границ для суммирования элементов
            if (minRowIndex < maxRowIndex)
            {
                startRow = minRowIndex;
                endRow = maxRowIndex;
            }
            else
            {
                startRow = maxRowIndex;
                endRow = minRowIndex;
            }

            if (minColIndex < maxColIndex)
            {
                startCol = minColIndex;
                endCol = maxColIndex;
            }
            else
            {
                startCol = maxColIndex;
                endCol = minColIndex;
            }

            // Суммирование элементов
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    sum += arr[i, j];
                }
            }

            return sum;
        }

        public int[,] FindCommonElements(int[,] array1, int[,] array2)
        {
            List<int> commonElements = new List<int>();

            int rows1 = array1.GetLength(0);
            int cols1 = array1.GetLength(1);
            int rows2 = array2.GetLength(0);
            int cols2 = array2.GetLength(1);

            // Проходим по всем элементам первого массива
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    int element = array1[i, j];

                    // Проверяем, содержится ли элемент во втором массиве
                    bool found = false;
                    for (int x = 0; x < rows2; x++)
                    {
                        for (int y = 0; y < cols2; y++)
                        {
                            if (array2[x, y] == element)
                            {
                                found = true;
                                break;
                            }
                        }
                        if (found) break;
                    }

                    // Добавляем элемент в результат, если он общий для обоих массивов
                    if (found && !commonElements.Contains(element))
                    {
                        commonElements.Add(element);
                    }
                }
            }

            // Создаем третий массив для хранения общих элементов
            int[,] commonArray = new int[commonElements.Count, 1];
            int index = 0;

            // Заполняем третий массив общими элементами
            foreach (int element in commonElements)
            {
                commonArray[index, 0] = element;
                index++;
            }

            return commonArray;
        }
    }

}

