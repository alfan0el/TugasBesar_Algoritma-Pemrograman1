using System;

namespace tugasbesarAlgoKalkulus
{
    class programhitungkalkulus
    {
        public static void Main (string[] args)
        {
            Console.Clear();
            up: ;
            //Pilih Perhitungan
            Console.WriteLine("+================================================+");
            Console.WriteLine("|---|APLIKASI PERHITUNGAN SEDERHANA KALKULUS|----|");
            Console.WriteLine("+===+=======================================+====+");
            Console.WriteLine("|---|Pilih Perhitungan? --------------------|----|");
            Console.WriteLine("|---|1.Turunan Sederhana -------------------|----|");
            Console.WriteLine("|---|2.Integral Sederhana ------------------|----|");
            Console.WriteLine("+================================================+");

            int plhHitungan;
            
            
            //input pilihan
            Console.Write("|+++|Masukan Pilihan : ");
            plhHitungan = int.Parse(Console.ReadLine());

            //percabangan pertama
            if (plhHitungan == 1)
            {
                //opening & input jumlah var
                int[] nilaiN = new int[100];
                int[] nilaiP = new int[100];

                Console.WriteLine("+===+=======================================+====+");
                Console.WriteLine("|---|---- PERHITUNGAN TURUNAN SEDERHANA ----|----|");
                Console.WriteLine("+===+=======================================+====+");

                int i, n = 0;
                
                Console.Write("|+++|Masukan banyak variabel X : ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("==================================================");

                //cetak var yang diminta
                Console.Write("|===|Y = ");
                for (i = 0; i < n; i++)
                {
                    Console.Write("n.X^p ");
                    if (n-i!=1){
                    Console.Write("+ ");
                    }
                    else {
                    Console.WriteLine("\t");
                    }
                }
                
                //input nilai var
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine("+===+=============================================");
                    Console.Write($"|+++|Masukan Nilai n ke-{i+1} : ");
                    nilaiN[i] = int.Parse(Console.ReadLine());
                    Console.Write($"|+++|Masukan Nilai p ke-{i+1} : ");
                    nilaiP[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("+===+=============================================");
                }
                
                //cetak var dan nilai (soal yang akan diturunkan)
                Console.Write("|===|nY = ");
                for (i = 0; i < n; i++)
                {
                    Console.Write(nilaiN[i] + ".X^" + nilaiP[i]);
                    if (n-i!=1){
                    Console.Write(" + ");
                    }
                    else {
                    Console.WriteLine("\t ");
                    }
                }

                //proses penurunan
                for (i = 0; i < n; i++)
                {
                    nilaiN[i] = nilaiN[i] * nilaiP[i];
                    nilaiP[i] = nilaiP[i] - 1;
                }

                //cetak hasil penurunan
                Console.Write("|===|nY' = ");
                for (i = 0; i < n; i++)
                {
                    Console.Write(nilaiN[i] + ".X^" + nilaiP[i]);
                    if (n-i!=1)
                    {
                        Console.Write(" + ");
                    }
                    else
                    {
                        Console.WriteLine("\t ");
                    }
                }
                Console.WriteLine("+===+=============================================");
            }

            //percabangan kedua
            else if (plhHitungan == 2)
            {
                //opening & input jumlah var
                int[] nilaiN = new int[100];
                int[] nilaiP = new int[100];

                Console.WriteLine("+========+==============================+========+");
                Console.WriteLine("|--------|PERHITUNGAN INTEGRAL SEDERHANA|--------|");
                Console.WriteLine("+================================================+");
                Console.WriteLine("|--------|Integral ......... + k dx = --|--------|");
                Console.WriteLine("+========+==============================+========+");

                int i, n = 0;
                int k;
                
                Console.Write("|+++|Masukan jumlah variabel : ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("+===+=============================================");

                //cetak var
                Console.Write("|===|");
                for (i = 0; i < n; i++)
                {
                    Console.Write("n.X^p ");
                    if (n-i!=1)
                    {
                        Console.Write("+ ");
                    }
                }
                Console.WriteLine("+ k dx = ");

                //input nilai var
                for (i = 0; i < n; i++) 
                {
                    Console.WriteLine("+===+=============================================");
                    Console.Write($"|+++|Masukan Nilai n ke-{i+1} : ");
                    nilaiN[i] = int.Parse(Console.ReadLine());
                    Console.Write($"|+++|Masukan Nilai p ke-{i+1} : ");
                    nilaiP[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("+===+=============================================");
                }
                Console.Write($"|+++|Masukan Nilai K      : ");
                k = int.Parse(Console.ReadLine());
                Console.WriteLine("+===+=============================================");

                //cetak var dan nilai (soal yang akan diIntegralkan)
                Console.Write("|===|Intergral ");
                for (i = 0; i < n; i++)
                {
                    Console.Write(nilaiN[i] + ".X^" + nilaiP[i]);
                    if (n-i!=1){
                    Console.Write(" + ");
                    }
                }
                Console.WriteLine($" + {k} dx = ..... ");
                Console.WriteLine("+===+=============================================");

                //langkah pertama pengintergralan
                Console.Write("|===|");
                for (i = 0; i < n; i++) 
                {
                    Console.Write(nilaiN[i] + "/" + "(" + nilaiP[i] + "+1)");
                    Console.Write(".X^" + "(" + nilaiP[i] + "+1)");
                    if (n-i!=1)
                    {
                        Console.Write(" + ");
                    }
                }
                Console.WriteLine($" + {k}x + C");
                Console.WriteLine("+===+=============================================");

                //langkat terakhir pengintegralan
                Console.Write("|===|");
                for (i = 0; i < n; i++)
                {
                    int x = nilaiP[i] + 1;
                    Console.Write(nilaiN[i] + "/" + x + ".X^" + x);
                    if (n-i!=1)
                    {
                        Console.Write(" + ");
                    }
                }
                Console.WriteLine($" + {k}x + C");
                Console.WriteLine("+===+=============================================");

            }
            else 
            {
                Console.WriteLine("Pilihan anda tidak ditemukan!!");
            }

            Console.Write("Lanjut? [Y/N] : ");
            string plhMenu = Console.ReadLine();
            if (plhMenu == "Y" || plhMenu == "y")
            {
                Console.Clear();
                goto up;
            }
            else if (plhMenu == "N" || plhMenu == "n")
            {
                goto end;
            }
            else
            {
                Console.WriteLine("Pilihan tidak ada.........");
            }

            Console.ReadLine();
            end: ;
        }
    }
}