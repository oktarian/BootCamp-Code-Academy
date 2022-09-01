namespace Test
{
    class finalTest
    {
        //SOAL1

        //SOAL 2
        public static int FaktorialSoal2(int n)
        {
               
                int hasil = n;
                int angka = 1;

                for (int i = 1; i <= n; i++)
                {
                    angka *= i;

                }
                Console.WriteLine($"{n}! = {angka}");

                return hasil;
            
        }

        //SOAL 3
        public static int SumSoal3(int n)
        {

            int hasil = n;
            int angka = 0;

            for (int i = 0; i <= n; i++)
            {
                angka += i;

            }
            Console.WriteLine($"{n} = {angka}");

            return hasil;

        }

        //SOAL4
        public static int FiboSoal4(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;
        
            for (int i = 1; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            Console.Write($" Fibonanci ke {n} : {c} ");

            return c;
        }

        //SOAL 5
        public static int ShowFiboSoal5(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write("{1} ", a,b);

            for (int i = 1; i < n; i++)
            {
                c = a + b;
                Console.Write("{0} ", c);
                a = b;
                b = c;
            }

            return c;
        }

        //SOAL 7
       /* public static bool isAnagram(string s1, string s2)
        {
            
            if (s1.Length != s2.Length)
            {
                return false;
            }
              
            char[] s1CharsArray = s1.ToLower().ToCharArray();
            char[] s2CharsArray = s2.ToLower().ToCharArray();
            //Sort array  
            Array.Sort(s1CharsArray);
            Array.Sort(s2CharsArray);

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                    return false;
            }
          
            return true;
        }*/
   

        //SOAL 8
       /* public static void MatrixSoal8()
        {
            int[,] matrix = new int[5, 5];
            int counter = 1;
            int sum = 0;

            // init diagonal matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = counter++;
                    }
                    else if(i > j)
                    {
                        matrix[i, j] = 10;
                    }
                   *//* else if (i > j)
                    {
                        matrix[i, j] = 0;
                    }*//*
                }
            }

            DisplayMatrix(matrix);

        }*/
    /*    public static void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }
        }*/
    }
}