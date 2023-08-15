using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Baslatmak istediginiz proqramin numarasini giriniz\n#1-SinavNotu\n#2-" +
                "ATM\n#3-FOR\n#4-WHILE\n#5-VurmaCedveli\n#6-Login\n#7-Array\n#8-Metodlar" );
            string secim = Console.ReadLine();
            switch (secim)
            {
                //case 1 start
                case "1":
                    Console.WriteLine("Lütfen 1. notunuzu giriniz"); int birinci_not = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lütfen 2. notunuzu giriniz"); int ikinci_not = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lütfen 3. notunuzu giriniz"); int ucuncu_not = Convert.ToInt32(Console.ReadLine());
                    int sonuc = (birinci_not + ikinci_not + ucuncu_not) / 3;
                    if (sonuc > 80 && sonuc < 100)
                    {
                        Console.WriteLine("Not Değeriniz : A+");
                        Console.WriteLine("Not değeriniz B+");
                    }
                    else if (sonuc > 60 && sonuc < 80)
                    {
                        Console.WriteLine("Not değeriniz :A");
                    }
                    else if (sonuc > 40 && sonuc < 60)
                    {
                        Console.WriteLine("Not degeriniz B+");
                    }
                    else
                    {
                        Console.WriteLine("Not degeriniz Fdir");

                    }
                    break;
                //case 1 end
                //case 2 start

                case "2":
                    int bakiye = 1000;
                    Console.WriteLine("Lütfen bir işlem seçiniz");
                    Console.WriteLine("1- Bakiye Görüntüle"); Console.WriteLine("2- Para Çek");
                    Console.WriteLine("3- Çıkış yap");
                    string secim2 = Console.ReadLine();
                    switch (secim2)
                    {

                        case "1":
                            Console.WriteLine("Bakiyeniz :" + bakiye);
                            break;
                        case "2":
                            Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                            int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                            if (cekilecek_tutar <= bakiye)
                            {
                                Console.WriteLine("Hesabinizda kalan para:"+(bakiye-cekilecek_tutar));
                            }
                            else
                            {
                              Console.WriteLine("Bakiyenizden fazla para cekemezsiniz");
                            }
                            break;
                        case "3":
                            Console.WriteLine("Cikis yapildi");
                            break;
                        default:
                            Console.WriteLine("End");
                            break;
                    }
                    break;
                //case 2 end
                //case 3 start
                case "3":
                    for (int i= 1; i <= 10; i++) 
{
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(j);
                        }
                        
                        Console.WriteLine("");
                    }
                    break;
                //case 3 end
                //case 4 start
                case "4":
                    int a = 1;
                    while (a <= 10)
                    {
                        Console.WriteLine(a);
                        a++;
                    }
                    Console.ReadLine();
                    break;
                //case 4 end
                //case 5 start
                case "5":
                    for (int i = 1; i <= 10; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.WriteLine(i + "x" + j + "=" + (i * j));
                        }
                        
                    }
                        break;
                //case 5 end
                //case 6 start
                case "6":
                    int hak_sayisi = 3;
                    while (true)
                    {
                        Console.WriteLine("Kullanıcı adınızı giriniz"); string kullaniciAdi = Console.ReadLine();
                        Console.WriteLine("Şifrenizi giriniz"); string sifre = Console.ReadLine();
                        if (kullaniciAdi == "enes" && sifre == "123")
                        {
                            Console.WriteLine("Tebrikler başarılı bir şekilde giriş yaptınız :)");
                            break;
                        }
                        
                        else
                        {
                            Console.WriteLine("Kullanıcı adınız veya şifreniz yanlış !");
                            if (hak_sayisi > 0)
                            {
                                hak_sayisi -= 1;
                            }
                            
                            if (hak_sayisi == 0)
                            {
                                Console.WriteLine("Hakkınız dolmuştur daha giriş yapamazsınız");
                                break;
                            }
                        }
                    }
                                break;
                //case 6 end
                //case 7 start
                case "7":
                    int[] sayilar = new int[4];

                    sayilar[0] = 10;
                    sayilar[1] = 20;
                    sayilar[2] = 30;
                    sayilar[3] = 40;

                    for(int i =0; i<sayilar.Length; i++)
                    {
                        Console.WriteLine(sayilar[i]);
                    }
                    break;
                //case 7 end
                //case 8 start
                case "8":
                    Salamver();
                    break;
                //case 8 end
                default:
                    break;

            }


            Console.WriteLine("Proqramdan cixmaq ucun 'y' yazib 'ENTER' basin");
            Console.WriteLine("Davam etmek ucun sadece 'ENTER' basin");
            string s = Convert.ToString(Console.ReadLine());
            if (s.Equals("y") || s.Equals("yes") || s.Equals("Y") || s.Equals("YES"))
            {
                Console.WriteLine("GoodBye!!!");
            }
            else
            {
                Main(args);
            }
        }

        static void Salamver()
        {
            Console.WriteLine("Salamlar :)");
        }
    }
}
