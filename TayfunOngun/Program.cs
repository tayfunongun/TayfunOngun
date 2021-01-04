using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TayfunOngun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Seviye seçin \n \n 1 - Kolay \n 2 - Orta \n 3 - Zor \n \n");

            Console.Write("Seviye seçin:");

            string seviye = Console.ReadLine();

            switch (seviye)
            {
                case "1":
                    
                    
                    Random rnd = new Random();
                    int SeçilenSayı = rnd.Next(1, 10);
                    int Sayı = 0, TahminHakkı = 6;

                    while (TahminHakkı>0)
                    {
                        Console.WriteLine("1 ile 10 arasında bir sayı seçin");
                        Sayı = Convert.ToInt32(Console.ReadLine());
                        TahminHakkı--;

                        if(SeçilenSayı==Sayı)
                        {
                            Console.WriteLine("Tebrikler, doğru tahmin ettiniz :)", TahminHakkı);
                            break;
                                
                        }
                    else
                        {
                            if (SeçilenSayı>Sayı)
                            {
                                Console.WriteLine("Tahmininiz çok küçük, lütfen daha büyük bir sayı seçin.");
                            }
                            else if(SeçilenSayı<Sayı)
                            {
                                Console.WriteLine("Tahmininiz çok büyük, lütfen daha küçük bir sayı seçin.");

                            }


                        }
                        Console.WriteLine("Kalan Tahmin Hakkınız {0}",TahminHakkı);
                    }
                    Console.WriteLine("Tahmin Hakkınız Kalmadı :( Tutulan Sayı = {0}", SeçilenSayı);
                    Console.ReadLine();

                    

                    break;

                case "2":
                     Random Newrnd = new Random();
                    int SeçilenSayi = Newrnd.Next(1, 25);
                    int Sayi = 0, TahminHakki = 4;

                    while (TahminHakki>0)
                    {
                        Console.WriteLine("1 ile 25 arasında bir sayı seçin");
                        Sayı = Convert.ToInt32(Console.ReadLine());
                        TahminHakki--;

                        if(SeçilenSayi==Sayı)
                        {
                            Console.WriteLine("Tebrikler, doğru tahmin ettiniz :)", TahminHakki);
                            break;
                                
                        }
                    else
                        {
                            if (SeçilenSayi>Sayı)
                            {
                                Console.WriteLine("Tahmininiz çok küçük, lütfen daha büyük bir sayı seçin.");
                            }
                            else if(SeçilenSayi<Sayı)
                            {
                                Console.WriteLine("Tahmininiz çok büyük, lütfen daha küçük bir sayı seçin.");
                            }


                        }
                        Console.WriteLine("Kalan Tahmin Hakkınız {0}",TahminHakki);
                    }
                    Console.WriteLine("Tahmin Hakkınız Kalmadı :( Tutulan Sayı = {0}", SeçilenSayi);
                    Console.ReadLine();
                   
                    



                    break;




                case "3":
                   

                    Random Nwrnd = new Random();
                    int SeçılenSayi = Nwrnd.Next(1, 50);
                    int Rakam = 0, TahmınHakki = 2;

                    while (TahmınHakki > 0)
                    {
                        Console.WriteLine("1 ile 50 arasında bir sayı seçin");
                        Sayı = Convert.ToInt32(Console.ReadLine());
                        TahmınHakki--;

                        if (SeçılenSayi == Sayı)
                        {
                            Console.WriteLine("Tebrikler, doğru tahmin ettiniz :)", TahmınHakki);
                            break;

                        }
                        else
                        {
                            if (SeçılenSayi > Sayı)
                            {
                                Console.WriteLine("Tahmininiz çok küçük, lütfen daha büyük bir sayı seçin.");
                            }
                            else if (SeçılenSayi < Sayı)
                            {
                                Console.WriteLine("Tahmininiz çok büyük, lütfen daha küçük bir sayı seçin.");
                            }


                        }
                        Console.WriteLine("Kalan Tahmin Hakkınız {0}", TahmınHakki);
                    }
                    Console.WriteLine("Tahmin Hakkınız Kalmadı :( Tutulan Sayı = {0}", SeçılenSayi);
                    Console.ReadLine();

                    break;

            }

            











        }
    }
}
