using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class Quiz2
    {
        //soal nomor 1
        public static void DisplayArrayInt2(int[] arr)
        {
            Console.Write($"After random : ");

            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }

        public static int[] RandomPosition(int[] n)
        {
            int[] arr = n;
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                int tmp = arr[i];
                int j = random.Next(0, arr.Length);
                arr[i] = arr[j];
                arr[j] = tmp;

            }
            return arr;

        }

        //soal 2
        public static void DisplayArrayInt3(int[] n)
        {
            Console.WriteLine("After tukar: ");
            foreach (int num in n)
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();
        }
        public static int[] GeserElement(int[] arr2)
        {
            int[] nilai = arr2;
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($" {arr2[i]} ");


            }

            int temp = arr2[0];
            for (int j = 0; j < arr2.Length; j++)
            {
                if (j < arr2.Length - 1)
                {
                    arr2[j] = nilai[j + 1];
                }
                else
                {
                    arr2[j] = temp;
                }

            }

            return nilai;
        }
        //soal3
        public static void DisplayRotasi(int[] n)
        {
            foreach (int num in n)
            {
                Console.Write(num + " ");
            }
        }
        public static int[] Rotasi(int[] arr2)
        {
            int[] bef = arr2;
                        
          
            for (int i = 1; i < 4; i++)
            {
                var putar = arr2[0];
                Console.WriteLine();
                Console.Write($"rotasi ke {i} :");            
           
                for (int j = 1; j < arr2.Length; j++)
                {
                    arr2[j - 1] = arr2[j];
                }
                arr2[arr2.Length - 1] = putar;
                DisplayRotasi(bef);
                arr2 = bef;
            }

            return bef;
        }

        //soal4
        public static int[] RotasiKanan(int[] arr2)
        {
            int[] temp = arr2;


            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine();
                Console.Write($"rotasi ke {i} :");
                int putar = arr2[arr2.Length - 1];

                for (int j = arr2.Length - 1; j > 0; j--)
                {
                    temp[j] = arr2[j - 1];
                }
                temp[0] = putar;
                DisplayRotasi(temp);
                arr2 = temp;
            }

           return temp;
        }

        //Soal 5
        public static int[] HitungDuplikat(int[] arr2)
        {
            int[] frek = arr2.Distinct().ToArray(); 

            for (int i = 0; i < arr2.Length; i++)
            {
                //int frek = arr2[0];
                int count = 0;
                for (int j = 0; j <= arr2.Length - 1; j++)
                {

                    if (arr2[j] == arr2[i])
                    {
                       count++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($" element: {frek[i]} memiliki : {count} kali");
            }
            return arr2;
        }
        //soal6

        //soal 7

        //soal8

        //soal9
        public static int[,] soal9(int baris, int kolom)
        {
            Random random = new Random();
            int[,] matrix = new int[baris, kolom];
            int counter = 5;

            // fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // isi diagonal
                    if (i == j)
                    {
                        matrix[i, j] = counter--;
                 
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 10;
                    }
                    else 
                    {
                        matrix[i, j] = 20;
                    }
                }
            }
            return matrix;
        }

        //soal 10

        public static int[,] soal10(int baris, int kolom)
        {
            Random random = new Random();
            int[,] matrix = new int[baris, kolom];
            int counter = 0;
            int hasil = 0;
            // fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // isi diagonal
                    if (i == j)
                    {
                        matrix[i, j] = random.Next(10);
                        hasil = hasil + matrix[i, j];
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 10;
                    }
                    else if(i < j)
                    {
                        matrix[i, j] = 20;
                    }
                }
            }
            Console.WriteLine($"penjumlah dari matrix random : {hasil}");
            return matrix;
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) // looping baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//loop kolom
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        //soal 11
        public static int[,] soal11(int baris, int kolom)
        {
            int[,] matrix = new int[7, 7];
            /*int counter = 0;*/
            int count = 1;
            /* int bar = matrix.GetLength(0);
             int kol = matrix.GetLength(1);*/
            int hasil = 0;
            // fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i + j;
                    // isi diagonal
                    if (i != 0 && j != 0)
                    {
                        if (i != baris - 1 && j != baris - 1)
                        {
                            matrix[i, j] = 0;
                        }
                    }

                }
            }
            //Console.WriteLine(hasil);
            return matrix;
        }

        //soal12
        public static int[,] soal12(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int sum = 0;
            int sum2 = 0;
            int n = baris - 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i != n && j != n)
                    {
                        matrix[i, j] = i + j;
                        if (j <= n)
                        {
                            sum += matrix[i, j];
                            matrix[n, i] = matrix[i, n] = sum;

                            if (i == j)
                            {
                                sum2 += matrix[i, j];
                                matrix[n, n] = sum2;
                            }

                            if (j == n - 1)
                            {
                                sum = 0;
                            }
                        }
                    }
                }
            }

            return matrix;
        }



    }
}

