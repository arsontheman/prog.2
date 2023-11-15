using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog._2
{
    internal class TwoDimensionalArraySolver
    {
        private int[,] array;

        public int Rows
        {
            get { return array.GetLength(0); }
        }

        public int Columns
        {
            get { return array.GetLength(1); }
        }

        // Конструктор без параметрів
        public TwoDimensionalArraySolver()
        {
            // Задаємо розміри масиву за замовчуванням
            array = new int[10, 7];
            InitializeArray();
        }

        // Конструктор з параметрами
        public TwoDimensionalArraySolver(int rows, int columns)
        {
            // Задаємо розміри масиву
            array = new int[rows, columns];
            InitializeArray();
        }

        // Ініціалізація масиву довільними значеннями
        private void InitializeArray()
        {
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 100); // Заповнюємо елементи випадковими значеннями
                }
            }
        }

        // Індексатор для доступу до елементу масиву з контролем виходу за межі масиву
        public int this[int i, int j]
        {
            get
            {
                if (i >= 0 && i < array.GetLength(0) && j >= 0 && j < array.GetLength(1))
                {
                    return array[i, j];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
            }
            set
            {
                if (i >= 0 && i < array.GetLength(0) && j >= 0 && j < array.GetLength(1))
                {
                    array[i, j] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
            }
        }

        // Метод для знаходження суми елементів з обидва непарними індексами
        public int SumOfElementsWithOddIndices()
        {
            int sum = 0;

            for (int i = 1; i < array.GetLength(0); i += 2)
            {
                for (int j = 1; j < array.GetLength(1); j += 2)
                {
                    sum += array[i, j];
                }
            }

            return sum;
        }
    }

}