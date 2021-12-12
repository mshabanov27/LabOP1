using System;

namespace Lab8
{
    class Lab8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the matrix: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();                        //Після запиту розмірності матриці відступаю рядок, щоб текст і матриця не зливалися

            int[,] matrix = new int[size, size];

            matrix = matrixGenerator(matrix);

            printMatrix(matrix);

            Console.WriteLine(isMagicalSquare(matrix));


            //Знизу закоментовано готовий приклад з магічним квадратом, щоб перевірити, чи повертає функція результат для магічного квадрата, бо через рандом треба робити занадто багато спроб
            /*int[,] testing = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            printMatrix(testing);
            Console.WriteLine(isMagicalSquare(testing));*/
        }

        static int[,] matrixGenerator (int[,] matrix)   //Заповнення матриці випадковими значеннями від 1 до 20
        {
            var rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(1, 21);
                }
            }
                return matrix;
        }

        static void printMatrix (int[,] matrix)         //Форматований вивід матриці
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine(); 
                Console.WriteLine();        //Роблю між рядками виступ у рядок для кращої читаємості
            }
        }

        static string isMagicalSquare (int[,] matrix)    //Перевірка на магічний квадрат
        {
            bool equalInRows = true;

            int sumInRows1 = 0;
            int sumInRows2 = 0;

            for (int i = 1; i < matrix.GetLength(0) & equalInRows; i++)         //Розраховую суму поточного рядка і попереднього, щоб порівнювати їх
            {
                /*Цикл працює так, щоб утворився ланцюжок рівностей, і ,якщо рівність порушується, 
                 булевій змінній присвоюється значення False і відбувається вихід з циклу*/
                sumInRows1 = 0;                                              
                sumInRows2 = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sumInRows1 += matrix[i - 1, j];
                }

                for (int f = 0; f < matrix.GetLength(1); f++)
                {
                    sumInRows2 += matrix[i, f];
                }

                if (sumInRows1 == sumInRows2)
                {
                    equalInRows = true;
                }

                else
                {
                    equalInRows = false;
                }
            }


            bool equalInColumns = true;                //Аналогічно для стовпців

            int sumInColumns1 = 0;
            int sumInColumns2 = 0;

            for (int j = 1; j < matrix.GetLength(1) & equalInColumns; j++)
            {
                sumInColumns1 = 0;
                sumInColumns2 = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sumInColumns1 += matrix[i, j - 1];
                }

                for (int f = 0; f < matrix.GetLength(0); f++)
                {
                    sumInColumns2 += matrix[f, j];
                }

                if (sumInColumns1 == sumInColumns2)
                {
                    equalInColumns = true;
                }

                else
                {
                    equalInColumns = false;
                }
            }

            bool equalDiagonals = true;                 //Аналогічно для діагоналей

            int sumInMainDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                sumInMainDiagonal += matrix[i, i];
            }

            int count = 0;
            int sumInSideDiagonal = 0;
            for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
            {
                sumInSideDiagonal += matrix[count, j];
                count++;
            }

            if (sumInMainDiagonal != sumInSideDiagonal)
            {
                equalDiagonals = false;
            }

            bool allIsEqual = equalInRows & equalInColumns & equalDiagonals & (sumInRows1 == sumInColumns1) & (sumInColumns1 == sumInMainDiagonal);
            /*Перевірка правильності тверджень для булевих змінних та рівності колонок до стовпців та до діагоналей*/

            if (allIsEqual)
                return "The matrix is a Magical Square!";
            else
                return "The matrix is not a Magical Square!";
        }
    }
}
