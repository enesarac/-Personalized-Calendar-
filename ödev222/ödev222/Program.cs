using System;

namespace Ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim, soyisim, num, cin;
            Console.WriteLine("         -- KİŞİSELLEŞTİRİLMİŞ TAKVİME HOŞGELDİNİZ --");
            Console.Write("İsminiz: ");
            isim = Console.ReadLine();
            Console.Write("Soyisminiz: ");
            soyisim = Console.ReadLine();
            Console.Write("Cinsiyetiniz (Kadın ya da Erkek olarak girin): ");
            cin = Console.ReadLine();
            Console.Write("Cep Numaranız (İletişim için): ");//gerçekçilik artsın diye ekstra bilgi aldım.
            num = Console.ReadLine();

            Console.Write("Lütfen doğum tarihini giriniz (GG.AA.YYYY): ");
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

            Console.Write("Lütfen güncel tarihi giriniz (GG.AA.YYYY): "); // özellikle güncel tarih almasını istedim gerçekçi olsun diye.
            DateTime currentDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
            // yaş bulma kod bloğu//
            int ageInDays = (currentDate - birthDate).Days;
            int dogumgunu = (currentDate - birthDate).Days;
            int age;
            age = dogumgunu / 365;
           



            if (ageInDays > 7300)// 7300 gün = 20 yıl
            {
                /*ay 48 gün*/

                if (cin.ToLower() == "erkek")// tolower kullandım büyük, küçük harfe duyarlı olsun diye//

                { // 7300 gün = 20 yıl  //21 yaşından gün alanlar ve erkekler

                    Console.Write("Kaç gün sonra işiniz var? ");
                    int days = int.Parse(Console.ReadLine());

                    while (days > 0)
                    {
                        int daysInMonth = 48;
                        int daysLeftInMonth = daysInMonth - currentDate.Day;

                        if (days <= daysLeftInMonth)
                        {
                            currentDate = currentDate.AddDays(days);
                            days = 0;
                        }
                        else
                        {
                            currentDate = currentDate.AddDays(daysLeftInMonth).AddMonths(1);
                            currentDate = new DateTime(currentDate.Year, currentDate.Month, 1);
                            days -= daysLeftInMonth;
                        }
                    }

                   
                    Console.Write("Sayın {0} {1} {2} {3} yaşındasınız  ", isim, soyisim, cin, age);  
                    Console.WriteLine("İşiniz " + currentDate.ToString("dd.MM.yyyy") + " tarihinde.");
                    Console.ReadKey();
                }
                else if (cin.ToLower() == "kadın")
                {
                    /*ay 36 gün*/

                    if (ageInDays > 7300)
                    { // 7300 gün = 20 yıl // 21 yaşından gün alanlar ve kadın olanlar 
                        Console.Write("Kaç gün sonra işiniz var? ");
                        int days = int.Parse(Console.ReadLine());

                        int totalDays = 0;

                        while (days > 0)
                        {
                            int daysInMonth = 36;
                            int remainingDays = daysInMonth - currentDate.Day;

                            if (remainingDays <= days)
                            {
                                days -= remainingDays;
                                currentDate = currentDate.AddDays(remainingDays).AddMonths(1);
                                currentDate = new DateTime(currentDate.Year, currentDate.Month, 1);
                            }
                            else
                            {
                                currentDate = currentDate.AddDays(days);
                                days = 0;
                            }

                            totalDays++;
                        }

                        Console.Write("Sayın {0} {1} {2} {3} yaşındasınız  ", isim, soyisim, cin, age);
                        Console.WriteLine("İşiniz " + currentDate.ToString("dd.MM.yyyy") + " tarihinde.");
                        Console.ReadKey();
                    }

                }

            }


            else
            {
                if (cin.ToLower() == "erkek")
                {
                    /*ay 40 gün*/ //21 yaşından gün almayıp erkek olanlar .


                    Console.Write("Kaç gün sonra işiniz var? ");
                    int days = int.Parse(Console.ReadLine());

                    int totalDays = 0;

                    while (days > 0)
                    {
                        int daysInMonth = 40;
                        int remainingDays = daysInMonth - currentDate.Day;

                        if (remainingDays <= days)
                        {
                            days -= remainingDays;
                            currentDate = currentDate.AddDays(remainingDays).AddMonths(1);
                            if (currentDate.Month == 1 || currentDate.Month == 13) // 40 günlük takvim sistemi kontrolü
                            {
                                currentDate = currentDate.AddDays(10); // 10 günlük farkı düzelt
                            }
                            currentDate = new DateTime(currentDate.Year, currentDate.Month, 1);
                        }
                        else
                        {
                            currentDate = currentDate.AddDays(days);
                            if (currentDate.Month == 1 || currentDate.Month == 13) // 40 günlük takvim sistemi kontrolü
                            {
                                currentDate = currentDate.AddDays(10); // 10 günlük farkı düzelt
                            }
                            days = 0;
                        }

                        totalDays++;
                    }

                    Console.Write("Sayın {0} {1} {2} {3} yaşındasınız  ", isim, soyisim, cin, age);
                    Console.WriteLine("İşiniz " + currentDate.ToString("dd.MM.yyyy") + " tarihinde.");
                    Console.ReadKey();
                }

                else if (cin.ToLower() == "kadın")
                {
                    /*ay 30 gün */ //21 yaşından gün almayanlar ve kadın olanlar.

                    Console.Write("Kaç gün sonra işiniz var? ");
                    int days = int.Parse(Console.ReadLine());

                    int totalDays = 0;

                    while (days > 0)
                    {
                        int daysInMonth = 30;
                        int remainingDays = daysInMonth - currentDate.Day;

                        if (remainingDays <= days)
                        {
                            days -= remainingDays;
                            currentDate = currentDate.AddDays(remainingDays).AddMonths(1);
                            currentDate = new DateTime(currentDate.Year, currentDate.Month, 1);
                        }
                        else
                        {
                            currentDate = currentDate.AddDays(days);
                            days = 0;
                        }

                        totalDays++;
                    }

                    Console.Write("Sayın {0} {1} {2} {3} yaşındasınız  ", isim, soyisim, cin, age);
                    Console.WriteLine("İşiniz " + currentDate.ToString("dd.MM.yyyy") + " tarihinde.");
                    Console.ReadKey();
                }
            }

                Console.ReadKey();

            }
        }
    }


                           