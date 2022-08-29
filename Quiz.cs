namespace Quiz1
{
    class QuizFirst
    {
        public static void soal1()
        {
            Console.WriteLine("masukan angkanya ?");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {
                sum += (number % 10);
                number /= 10;

            }

            Console.WriteLine(sum);
            /*for (int i = 0; i < n; i++)
            {
                
            }*/

        }
        public static void soal2()
        {
            int count =0;
            Console.WriteLine("masukan angkanya ?");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {
                sum += (number % 10);
                number /= 10;
                count++;    
            }

            Console.WriteLine(count);

        }

        public static void Dibalik()
        {

            Console.Write("masukan angka bestiii: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            int sisa = angka;
            int hasil = 0;
            while (sisa > 0)
            {
                sisa = angka % 10;
                hasil = sisa / 10;
                Console.Write($"{hasil}");
            }
        }
        public static void soal4()
        {
            Console.Write("masukan angka terbesar:");
            int number = Convert.ToInt32(Console.ReadLine());
            int kedua= 0;
            for (int i = 1; i < number; i++)
            {
                kedua++;
            }

            Console.WriteLine($"nilai terbesar ke-2 : {kedua}");    
        }
        public static void soal5()
        {
            Console.WriteLine("hayo tebak angka dari  0-20");
            Random random = new Random();
            int number = random.Next(0, 20);

            int guess = -1;
            while (guess != number)
            {
                Console.WriteLine("masukan tebakan mu ? ");
                var input = Console.ReadLine();
                int.TryParse(input, out guess);

                //cek kondisi 1
                if (guess == number)
                {
                    Console.WriteLine($"Bestie menebak dengan tepat: {guess}");
                    Console.WriteLine($"Apakah anda mau menebak kembali ? {guess}");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Y)
                    {
                        soal5();
                    }
                    else if(key.Key == ConsoleKey.X)
                    {
                        Console.WriteLine("keluar!!");
                    }
                }
                else if (guess > number)
                {
                    Console.WriteLine($"Tebakan bestie terlalu besar. Try Again!");
                }
                else
                {
                    Console.WriteLine($"Tebakan bestie terlalu kecil. Try Again!");
                }


            }
        }
        public static void soal6()
        { 
            int max = int.MinValue;
            int n = 0;
        
            for (int i = 1; i > n; i++)
            { 
             Console.Write("masukan angkanya [ketikan 0 untuk keluar] :");
             int angka = Convert.ToInt32(Console.ReadLine());
                if (angka > max)
                {
                    max = angka;
                }
                else if (angka == 0)
                {
                    Console.Write($"bestiee..angka terbesarnya itu : {max}");
                    break;
                }
            }
            Console.ReadLine();
        }
        public static void soal7()
        {


            int number;
            Console.Write("masukan angka : ");
            number = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < number; i++)
            {
                if (number % i == 0 )
                {
                    Console.Write($"{i}");
                }

            }
            Console.ReadLine();
        }
        public static void soal8()
        {
            Console.Write("Masukkan batas angka : ");
           int bilangan = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            Console.WriteLine();
            Console.WriteLine("Bilangan prima dari 1 sampai {0} adalah ", bilangan);

            for (int i = 1; i <= bilangan; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        temp = temp +1;
                    }
                }
                if (temp == 2)
                {
                    Console.Write(i + " ");
                }
                temp = 0;
            }
        }
       
       
        public static void soal9()
        {
            string s, revs = "";
            Console.Write(" masukan kalimat : ");
            s = Console.ReadLine();
           string lower =  s.ToLower();
            for (int i = lower.Length - 1; i >= 0; i--) //String Reverse
            {
               /* Console.WriteLine(i);*/
                revs += lower[i].ToString();
            }
            if (revs == lower) // Checking whether string is palindrome or not
            {
                Console.WriteLine("ini Palindrome");
            }
            else
            {
                Console.WriteLine("ini bukan Palindrome");
            }
            Console.ReadKey();
        }
      
        public static void soal10()
        {
            string kalimat;
            int vokal = 0, konsonan = 0;
            string kal = "aieuoAIEUO";
            Console.Write("Enter Strings : ");
            kalimat = Console.ReadLine();
            for (int i = 0; i < kalimat.Length; i++)
            {
                if (char.IsLetter(kalimat[i]))
                {
                    if (kal.Contains(kalimat[i]))
                    {
                        vokal ++;
                    }
                    else
                    {
                        konsonan ++;
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine("Total Vokal    ={0}", vokal);
            Console.WriteLine("Total konsonan ={0}", konsonan);
        }

    
        public static void soal11()
        {
           string kal;
           int tot= 0;
            Console.WriteLine("Masukan katanya :");
            kal = Console.ReadLine();



        }
        public static void soal12()
        {

        }
        public static void soal13()
        {

            DateTime now = DateTime.Now;
          
            DayOfWeek dayOfWeek = now.DayOfWeek;
            DayOfWeek sabtu = DayOfWeek.Saturday;
            int daysRemaining = sabtu - dayOfWeek;


            Console.WriteLine($" {now.AddDays(daysRemaining)} {daysRemaining} hari lagi");
        }
        public static void soal14()
        {
            Console.Write("masukan string :");
            string kata = Console.ReadLine();
            Console.WriteLine("temukan pola nak :");
            string pola = Console.ReadLine();

            int a = 0;
            int count = 0;

            while ((a = kata.IndexOf(pola, a)) != -1)
            {
                a = a + pola.Length;
                count++;
            }
            Console.WriteLine($"pola-nya {pola} dari kata {count}");
            Console.ReadLine();
        }
        public static void soal15()
        {
           
                int max = int.MinValue;
                int max2 = int.MaxValue;

                for (int i = 1; i <= 5; i++)
                {
                    Console.Write($"masukan angka ke {i} : ");

                     
                int angka = Convert.ToInt32(Console.ReadLine());
                    if (angka > max)
                    {

                        max2 = max;
                        max = angka;
                    }

                }
                Console.Write($"angka terbesar ke 2: {max2}");
                Console.ReadLine();
        }

    }
}