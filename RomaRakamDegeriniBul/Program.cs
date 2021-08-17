using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomaRakamDegeriniBul
{
    public class Program
    {
        public static void Main(string[] args)
        {          
            Console.WriteLine("MERHABA :) ");
      bas:  Console.WriteLine("Lütfen Roma Rakamı ile gösterimini merak ettiğiniz 1 ile 100 arasında bir değer giriniz");
          
            try
            {
                int onlar, birler;
                string sonuc = "";
                int sayi = Convert.ToInt32(Console.ReadLine());
                onlar = sayi / 10;
                birler = sayi - (onlar * 10);
                if (9 < sayi && sayi < 100)
                {

                    if (onlar > 0)
                    {
                        switch (onlar)
                        {
                            case 1:
                                sonuc = "X";
                                break;

                            case 2:
                                sonuc = "XX";
                                break;

                            case 3:
                                sonuc = "XXX";
                                break;

                            case 4:
                                sonuc = "XL";
                                break;

                            case 5:
                                sonuc = "L";
                                break;

                            case 6:
                                sonuc = "LX";
                                break;

                            case 7:
                                sonuc = "LXX";
                                break;

                            case 8:
                                sonuc = "LXXX";
                                break;

                            case 9:
                                sonuc = "XC";
                                break;
                        }

                        if (birler > 0)
                        {
                            switch (birler)
                            {
                                case 1:
                                    sonuc = sonuc + "I";
                                    break;

                                case 2:
                                    sonuc = sonuc + "II";
                                    break;

                                case 3:
                                    sonuc = sonuc + "III";
                                    break;

                                case 4:
                                    sonuc = sonuc + "IV";
                                    break;

                                case 5:
                                    sonuc = sonuc + "V";
                                    break;

                                case 6:
                                    sonuc = sonuc + "VI";
                                    break;

                                case 7:
                                    sonuc = sonuc + "VII";
                                    break;

                                case 8:
                                    sonuc = sonuc + "VIII";
                                    break;

                                case 9:
                                    sonuc = sonuc + "IX";
                                    break;
                            }
                        }

                        Console.WriteLine("Girdiğiniz sayının Roma Rakamı ile gösterimi: " + sonuc.ToString());

                    }


                }
                else if (sayi == 100)
                {
                    Console.WriteLine("Girdiğiniz sayının Roma Rakamı ile gösterimi: C ");
                }
                else if (0 < sayi && sayi < 10)
                {
                    if (birler > 0)
                    {
                        switch (birler)
                        {
                            case 1:
                                sonuc = sonuc + "I";
                                break;

                            case 2:
                                sonuc = sonuc + "II";
                                break;

                            case 3:
                                sonuc = sonuc + "III";
                                break;

                            case 4:
                                sonuc = sonuc + "IV";
                                break;

                            case 5:
                                sonuc = sonuc + "V";
                                break;

                            case 6:
                                sonuc = sonuc + "VI";
                                break;

                            case 7:
                                sonuc = sonuc + "VII";
                                break;

                            case 8:
                                sonuc = sonuc + "VIII";
                                break;

                            case 9:
                                sonuc = sonuc + "IX";
                                break;
                        }
                    }

                    Console.WriteLine("Girdiğiniz sayının Roma Rakamı ile gösterimi: " + sonuc.ToString());

                }
                else
                {
                    Console.WriteLine("1 ile 100 arası bir sayı girmeniz gerekiyor...");
                    goto bas;
                }

            }
           

            
           catch (Exception)
            {

                Console.WriteLine("1 ile 100 arası bir sayı girmeniz gerekiyor...");
                goto bas;
            }         

            Console.ReadLine();
        }

       
        
    }


}
