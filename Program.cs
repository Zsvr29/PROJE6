using System;

namespace PROJEM6
{
    class Program
    {
        static void Main(string[] args)
        {
            // atm otomasyonu 

            int   yatırılanpara,eft,cekılenpara,kalanpara,hesapnumarası,islem;
            string TC;
            int para = 3500;
                
            Console.WriteLine("Lutfen TC kımlık numaranızı  gırınız:");
            TC = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hesap numaranızı gırınız:");
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlem Basarılı...");
            Console.WriteLine("Lutfen Yapmak ıstedıgınız ıslemı secınız.");

            Console.WriteLine(" 1-Bakiye Sorgulama ");
            Console.WriteLine(" 2- Para Cekme ");
            Console.WriteLine(" 3-Para Yatırma ");
            Console.WriteLine(" 4-EFT ");
          
            islem = Convert.ToInt32(Console.ReadLine());
            switch (islem)
            {
                case 1:
                    Console.WriteLine("Bakiye Sorgulama"); 
                    Console.WriteLine("Bakiyeniz:");
                    Console.WriteLine(para);

                    break;
                case 2:
                    Console.WriteLine("Para Cekme:");
                    Console.WriteLine("Bakiyeniz:");
                    Console.WriteLine(para);
                    Console.WriteLine(" Cekılecek bakiyeyi Gırınız:");
                    cekılenpara = Convert.ToInt32(Console.ReadLine());
                   
                    if (cekılenpara>para)
                    {
                        Console.WriteLine("Gecersız ıslem yaptınız.Bakıyenızı tekrar kontrol edınız");  
                    }

                    else
                    {
                        Console.WriteLine("İşlem Başarılı...");
                        Console.WriteLine("Karttakı kalan bakıyenız:");
                        kalanpara = para - cekılenpara;
                        Console.WriteLine(kalanpara);
                    }
                    break;

                case 3:
                    Console.WriteLine(" Karta  Para Yatırma:");
                    Console.WriteLine(" Toplam bakiyeniz:");
                    Console.WriteLine(para);
                    Console.WriteLine("Eklenecek bakıyeyı  gırınız:");
                    yatırılanpara = Convert.ToInt32(Console.ReadLine());
                    if (yatırılanpara < 0)
                    {
                        Console.WriteLine("Gecersiz işlem yaptıgınız.Lutfen bakıyenızı kontrol edınız:");
                    }
                    else
                    {
                        Console.WriteLine(" Toplam bakıyenız:");
                        para = para + yatırılanpara;
                        Console.WriteLine(para);

                    }

                    break;
                case 4:
                    Console.WriteLine("EFT yapacagınız kartın hesap numarasını gırınız:");
                    hesapnumarası = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("EFT yapacagınız bakıyeyı  gırınız:");
                    eft = Convert.ToInt32(Console.ReadLine());
                   
                    if (eft>para)
                    {
                        Console.WriteLine("Gecersız ıslem yaptınız.Bakıyenızı tekrar kontrol edınız...");
                    }
                      else
                    {
                        Console.WriteLine("İşlem Basarılı....");
                        Console.WriteLine("Kalan bakıyenız:");
                        para = para - eft;
                        Console.WriteLine(para);
                       
                    }
                    break;
                default:
                    Console.WriteLine("Gecersız islem yaptınız....");
                    break;
            }





        }
    }
}






