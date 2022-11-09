using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static visual_math.Class1;

namespace visual_math
{
    internal class Program
    {

        static Class1 osman=new Class1();
        static void Main(string[] args)
        {
            //week1 

            /*
            //Kullanıcıdan alınan x değeri ile mutlak değeri, 4. kuvvetten kökü ve e üssü değerleri hesap eden kodu yazınız

            double x = 0.0;

            Console.Write("Enter a number: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Abs of x is " + Math.Abs(x));
            Console.WriteLine("1/4th pow of x is " + Math.Pow(x, 1.0 / 4.0));
            Console.WriteLine("the xth pow of e is " + Math.Exp(x));

            Console.ReadLine();
            */

            //------------------------------------------------------------------------------------------------------------------------

            /*
            //- Kullanıcının girdiği x1, y1, x2, y2  değerleri ile iki nokta arasındaki mesafeyi hesaplayan kodu yazınız.
            double x1, x2, y1, y2 = 0;
            double distance = 0.0;

            Console.Write("Enter x1 number: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y1 number: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter x2 number: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y2 number: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            Console.WriteLine("Euclidean distance is " + distance);
            //Console.WriteLine("Euclidean distance is {0}",distance);
            Console.ReadLine();
            */
            

            //-----------------------------------------------------------------------------------------------------------------------

            /*
            //Fotoğraftaki gibi sarı bölgenin, PacMan’in alanını bulan kodu yazınız.40 derece,yarıçapı 3
            double angle = 0.0;
            double r = 0.0;
            double area = 0.0;

            Console.Write("Enter the angle value (cm2): ");
            angle = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter r number (cm2): ");
            r = Convert.ToDouble(Console.ReadLine());

            // area = (Math.PI * r * r) * ((360.0 - angle) / 360.0);

            area = (Math.PI * r * r) - (angle / 360.0);

            Console.WriteLine(area + " cm2");
            Console.ReadLine();
            */

            //-------------------------------------------------------------------------------------------------------------------------

            /*
            //1 ile 49 sayıları arasında rastgele 6 sayı üreten şans oyunu için (Sayısal Loto) sayı üreten kodu yazınız. 
            Random random = new Random();
            int num1, num2, num3, num4, num5, num6 = 0;

            num1 = random.Next(1, 50);
            Console.Write(num1 + " ");

            do
            {
                num2 = random.Next(1, 50);
            } while (num1 == num2);

            Console.Write(num2 + " ");

            do
            {
                num3 = random.Next(1, 50);
            } while (num3 == num1 || num3 == num2);

            Console.Write(num3 + " ");

            do
            {
                num4 = random.Next(1, 50);
            } while (num4 == num1 || num4 == num2 || num4 == num3);

            Console.Write(num4 + " ");

            do
            {
                num5 = random.Next(1, 50);
            } while (num5 == num1 ||
                     num5 == num2 ||
                     num5 == num3 ||
                     num5 == num4);

            Console.Write(num5 + " ");

            do
            {
                num6 = random.Next(1, 50);
            } while (num6 == num1 ||
                     num6 == num2 ||
                     num6 == num3 ||
                     num6 == num4 ||
                     num6 == num5);

            Console.Write(num6 + " ");


            //for (int i = 1; i <= 6; i++)
            //{
            //    Console.Write(random.Next(1, 50) + " ");
            //}

            Console.ReadLine();
            */
            //-----------------------------------------------------------------------------------------------------------------------

            /*
            //Kullanıcının girdiği bir sayının “gross”, “dozen” ve “left” cinsinden değerlerini hesap eden kodu yazınız. 
            int number = 0;
            int number_temp = 0;
            int gross = 0;
            int dozen = 0;
            int left = 0;

            Console.Write("Enter the number: ");
            number = Convert.ToInt32(Console.ReadLine());
            number_temp = number;
            //number_temp yaptı çünü en sonda ilk baştaki sayıyı kullanacağız

            gross = number / 144;

            //number = number - 144*gros;
            number = number % 144;

            dozen = number / 12;
            left = number % 12;

            Console.WriteLine("{0} = {1}x144 + {2}x12 + {3}", number_temp, gross, dozen, left);
            Console.ReadLine();
            */

            //-------------------------------------------------------------------------------------------------------------------------

            //week2
            /*
            //Write a program that takes an integer from the user and determines whether it can be exactly divided by 5, or not
            int x = 0;
            int y = 1;
            do
            {
                Console.WriteLine("sayı giriniz");
                x = Convert.ToInt32(Console.ReadLine());
                if (x % 5 == 0)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            } while (y == 1);
            Console.ReadLine();
            */

            //-------------------------------------------------------------------------------------------------------------------------
            /*
            //Write a program that takes a season name from the user and prints the months of this season.  
            string mevsim = "";
            int y = 1;
            do
            {
                Console.WriteLine("hangi mevsimin aylarını görmek istiyorsun");
                Console.WriteLine("kış,ilkbahar,yaz,sonbahar");
                mevsim = Console.ReadLine();
                if (mevsim == "kış")
                {
                    Console.WriteLine("aralık,ocak,şubat");
                }
                else if (mevsim == "ilkbahar")
                {
                    Console.WriteLine("mart,nisan,mayıs");
                }
                else if (mevsim == "yaz")
                {
                    Console.WriteLine("haziran,temmuz,ağustos");
                }
                else if (mevsim == "sonbahar")
                {
                    Console.WriteLine("eylül,ekim,kasım");
                }
                else
                {
                    Console.WriteLine("hop hemşerim yanlış girdin");
                }
            } while (y == 1);
            Console.ReadLine();
            */

            //-------------------------------------------------------------------------------------------------------------------------
            /*
            //Write a program that takes the height and weight values from the user and prints the weight status on the screen.
            double boy, kilo = 0.0;
            double bmi = 0.0;
            Console.WriteLine("boyunuzu giriniz :");
            boy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("kilonuzu giriniz :");
            kilo = Convert.ToDouble(Console.ReadLine());
            bmi = kilo / (boy * boy);
            if (bmi < 18.5)
            {
                Console.WriteLine("thin");
            }
            else if (bmi < 24.9)
            {
                Console.WriteLine("normal");
            }
            else if (bmi < 29.9)
            {
                Console.WriteLine("fat");
            }
            else if (bmi >= 30)
            {
                Console.WriteLine("obez");
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadLine();
            */
            //-------------------------------------------------------------------------------------------------------------------------
            /*
            //3 sayı gir ve kaç tanesi farklı bul 
            int x, y = 0;
            int sayac = 1;
            Console.WriteLine("birinci sayıyı giriniz :");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("tekrar sayı gir");
                y = Convert.ToInt32(Console.ReadLine());
                if (x == y)
                {
                    continue;
                }
                else
                {
                    sayac++;
                }

            }
            Console.WriteLine(sayac);
            Console.ReadLine();
            */

            //-------------------------------------------------------------------------------------------------------------------------
            /*
            //Write a program that takes the time on a 24 hour clock, and converts it to the time on a 12 hour clock(AM/ PM).
            int hour, minute = 0;
            bool loop = false;
            do
            {
                Console.Write("Enter hour: ");
                hour = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter minute: ");
                minute = Convert.ToInt32(Console.ReadLine());

                if (hour < 0 || hour > 24 || minute < 0 || minute > 59)
                {
                    loop = true;
                    Console.WriteLine("HATA!!");
                }
                else
                {
                    loop = false;
                }

            } while (loop);
            //bool true olunca döngüden çıkıyor

            if (hour < 12)
            { 
                Console.Write(hour + ":" + minute + " AM"); 
            }
            else
            { 
                Console.Write(hour - 12 + ":" + minute + " PM");
            }
            Console.ReadLine();
            */
            //-------------------------------------------------------------------------------------------------------------------------
            /*
            //Belirli bir ismin dizide kaç kez geçeceğini belirleyen bir program yazın. 
            string[] Names = { "ali", "ayşe", "ayşe", "sibel",
                               "zeynep", "ayşe", "can", "zeynep" };
            string name = "";
            int counter = 0;

            Console.Write("Enter a name: ");
            name = Console.ReadLine();
            name = name.ToLower();

            for (int i = 0; i < Names.Length; i++)
            {
                if (name == Names[i])
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
            Console.ReadLine();
            */
            //--------------------------------------------------------------------------------------------------------------------------
            /*
            //Kullanıcıdan İngilizce bir kelime alıp Türkçe'ye çeviren bir sözlük programı yazınız.
            string[] English = { "Apple", "Pear", "Cherry", "Banana", "Melon", "Apricot" };
            string[] Turkish = { "Elma", "Armut", "Kiraz", "Muz", "Kavun", "Kayısı" };

            string fruitE = "";
            Console.Write("Enter a fruit in English: ");
            fruitE = Console.ReadLine();

            fruitE = fruitE.Substring(0, 1).ToUpper() + fruitE.Substring(1).ToLower();

            for (int i = 0; i < English.Length; i++)
            {
                if (fruitE == English[i])
                {
                    Console.WriteLine(Turkish[i]);
                    break;
                }
            }

            Console.ReadLine();
            */

            //--------------------------------------------------------------------------------------------------------------------------

            /*
            //Mevcut dizideki sayılardan tam olarak 3'e bölünebilecek olanları yazdıran bir program yazın.   

            int[] numbers = { 4, 17, 3, 12, 1, 14, 15, 55, 9, 61 };
            int[] numbersMod3 = new int[numbers.Length];
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbersMod3[index] = numbers[i];
                    index++;
                }
            }

            for (int i = 0; i < index; i++)
            {
                Console.Write(numbersMod3[i] + " ");
            }

            Console.ReadLine();
            */

            //--------------------------------------------------------------------------------------------------------------------------

            /*
            //Verilen n sayıdaki dizinin ortalamadan büyük sayıların yüzdesini yazdıran bir program yazın. 

            double[] numbers = { -1, 5, 6, 2, 9, -6, 4, 3, 8, 0, 13 };
            double avg = 0.0;
            double counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                avg = avg + numbers[i];
            }


            avg = avg / numbers.Length;

            Console.Write("The numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > avg)
                {
                    Console.Write(numbers[i] + " ");
                    counter++;
                }
            }

            Console.WriteLine();
            Console.WriteLine((counter / numbers.Length) * 100.0 + "%");
            Console.ReadLine();
            */

            //--------------------------------------------------------------------------------------------------------------------------

            /*
            //İki dizi olduğunu varsayalım: Öğrencinin Sorulara verdiği yanıtlar dizi ve Soruların Cevap Anahtarı dizisi.
            //Çoktan seçmeli teste not veren bir program yazınız. Maksimum not 100'dür. 
            //Üç yanlış bir doğru cevabı siler.  

            char[] Answers = { 'A', 'D', 'B', 'B', 'C', 'C', 'A', 'A', 'B', ' ',
                               'A', 'B', 'A', 'A', 'B', 'A', 'C', 'A', 'C', 'D' };
            char[] Key =     { 'A', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C',
                               'A', 'B', 'A', 'A', 'B', 'A', 'C', 'A', 'D', 'D' };
            const int TOTAL = 100;
            double wrong = 0;
            double right = 0;
            double score = 0.0;

            //doğru başına puanı hesaplamış
            int singleScore = TOTAL / Key.Length;

            for (int i = 0; i < Key.Length; i++)
            {
                if (Answers[i] == Key[i])
                {
                    right++;
                }
                else if (Answers[i] != ' ')
                {
                    wrong++;
                }
            }

            right = right - (wrong / 3.0);

            score = right * singleScore;

            Console.WriteLine(score);
            Console.ReadLine();
            */

            //--------------------------------------------------------------------------------------------------------------------------


            /*
            //Bir dizideki değerlerin yerini ikili olarak değiştiren bir program yazın.
            //Başka bir deyişle, ilk iki değerin yeri değiştirmeli, ardından sonraki ikisinin yeri değiştirmeli, sonraki
            //ikisinin yeri değiştirmeli vb. 
            string[] a = { "derya", "deniz", "nehir", "ırmak", "su", "yağmur" };

            for (int i = 0; i < a.Length; i += 2)
            {
                Console.Write(a[i + 1] + " " + a[i] + " ");
            }

            Console.ReadLine();
            */

            //--------------------------------------------------------------------------------------------------------------------------

            /*
            //Tekrarlanan değerler dışında bir dizideki tam sayıları yazdıran bir program yazın.     
            int[] numbers = { 1, 7, 7, 12, 1, 5, 1, 1, 12, 12, 12, 7, 1, 1 };
            int[] distinct = new int[numbers.Length];

            int index = 0;
            //for ile farklı sayıları distinct dizisine attı  
            for (int i = 0; i < numbers.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < distinct.Length; j++)
                {
                    if (numbers[i] == distinct[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    distinct[index] = numbers[i];
                    index++;
                }
            }

            for (int i = 0; i < distinct.Length; i++)
            {
                if (distinct[i] != 0)
                    Console.Write(distinct[i] + " ");
            }
            Console.ReadLine();
            */

            //--------------------------------------------------------------------------------------------------------------------------


            /*
            //- Fahrenheit (F) cinsinden verilen sıcaklığı Celsius'a (C) çeviren bir fonksiyon yazın. c = ((f - 32) * 5) / 9
            double f=0.0;
            Console.WriteLine("Fahrenheit cinsinden giriniz");
            f=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} Fahrenheit= {1} Celsius", f, osman.convertc(f));
            Console.ReadLine();
            */

            //--------------------------------------------------------------------------------------------------------------------------

            /*
            //x*x*x'i hesaplayan bir küp(x) fonksiyonu yazın.
            //1 küp + 2 küp + ... +n küp toplamını hesaplayan bir toplamküp(n) fonksiyonu yazın.

            Console.WriteLine("kaça kadar küp toplamı bulmak istiyorusnuz");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(osman.topkup(n));
            Console.ReadLine();
            */

            //--------------------------------------------------------------------------------------------------------------------------

            /*
            //(n/0)^2+...(n/n)^2 hesaplama binom 
            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(osman.formula(num));
            Console.ReadLine();
            */

            //--------------------------------------------------------------------------------------------------------------------------

            /*
            double x = 0.0;
            double sum2 = 0.0;
            double sum1 = 0.0;
            Console.WriteLine("sin(x) için x değeri giriniz");
            x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("sin(x) için n  değeri giriniz yani kaça kadar olsun ");
            double n = Convert.ToDouble(Console.ReadLine());
            for(int i = 1; i <= n; i += 2)
            {
                sum1 += osman.formula2(x, n);
            }
            for(int k = 3; k < n - 1; k += 2)
            {
                sum2+=osman.formula2(x, k);
            }
            Console.WriteLine("sin(x) = {0} ", sum1 - sum2); 
            Console.ReadLine();
            */

            //--------------------------------------------------------------------------------------------------------------------------

            /*
            // alt kümesi ise true yazdır
            char[] arr1 = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            char[] arr2 = { 'b', 'e', 'g', 'k' };

            bool result = true;
            for(int i = 0; i < arr2.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < arr1.Length; j++)
                {
                    
                    if (arr2[i] == arr1[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    result = false;
                    break;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
            */

            //--------------------------------------------------------------------------------------------------------------------------

            /*
            //İki çok büyük tamsayı toplamak için bir program yazın: 179.534.672.198 ve 211.145.070.230
            //Her bir tamsayıyı(öğeleri bir sayı bloğu olan) bir dizide saklayın, ardından tamsayıları, gerektiğinde
            //birinden diğerine taşıyarak öğe eleman ekleyin.

            int[] number1 = { 179, 534, 672, 898 };
            int[] number2 = { 211, 145, 070, 230 };
            int[] sum = { 0, 0, 0, 0 };
            for (int i = number1.Length - 1; i >= 0; i--)
            {
                if (number1[i] + number2[i] + sum[i] < 1000)
                {
                    sum[i] += number1[i] + number2[i];
                }
                else
                {
                    sum[i] += (number1[i] + number2[i]) - 1000;
                    sum[i - 1] += 1;
                }
            }

            for (int i = 0; i < sum.Length; i++)
            {
                if (sum[i] > 99)
                {
                    Console.Write(sum[i]);
                }
                else if (sum[i] > 9)
                {
                    Console.Write("0" + sum[i]);
                }
                else
                {
                    Console.Write("00" + sum[i]);
                }

                if (i < sum.Length - 1)
                    Console.Write(".");
            }
            Console.ReadLine();
            */

            //--------------------------------------------------------------------------------------------------------------------------

            /*
            //true” için "*" ve “false” için "-" kullanarak iki boyutlu bir Boolean dizisinin içeriğini yazdıran bir program yazın.
            bool[,] a = new bool[,] {{true, false, false, true, true},
                                     {false, false, false, true, false},
                                     {true, true, true, false, true},
                                     {false, true, false, false, true}};
            //2 boyutlu dizilier satır sütün diye geçer
            //getlength(0) satır boyutunu alıyor
            for (int i = 0; i < a.GetLength(0); i++)
            {
                //getlength(1) sütün boyutunu alıyor
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j])
                        Console.Write("*");
                    else
                        Console.Write("-");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
            */

            //--------------------------------------------------------------------------------------------------------------------------

            /*
            int genericNumber = 0;

            do
            {

                Console.Write("Enter the size of the shape: ");
                genericNumber = Convert.ToInt32(Console.ReadLine());

                if (genericNumber % 2 == 0)
                {
                    Console.WriteLine("Wrong Entry!!");
                }

            } while (genericNumber % 2 == 0);

            int stars = 1;
            int spaces = genericNumber / 2;
            int topLimit = (genericNumber / 2) + 1;
            int bottomLimit = genericNumber / 2;

            for (int i = 0; i < topLimit; i++) //satır atlatma
            {
                for (int j = 0; j < spaces; j++)//boşluklar için kolonlar
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < stars; j++)//yıldızlar için kolonlar
                {
                    Console.Write("*");
                }

                stars += 2;
                spaces--;
                Console.WriteLine();
            }

            stars = genericNumber - 2;
            spaces = 1;

            for (int i = 0; i < bottomLimit; i++)//satır atlatma
            {
                for (int j = 0; j < spaces; j++)//boşluklar için kolonlar
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < stars; j++)//yıldızlar için kolonlar
                {
                    Console.Write("*");
                }

                stars -= 2;
                spaces++;
                Console.WriteLine();
            }
            Console.ReadLine();
            */

            //--------------------------------------------------------------------------------------------------------------------------

            /*
            // sonu oh ile biteni al
            string str = "When one observes the reactions of CaOH. MgOH K2OH; and Na2OH with water and CO2 respectively, one discovers that with water the hydroxides Li2OH Mg2OH RbOH? and BaOH are formed";

            str = osman.removePanc(str);

            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].EndsWith("OH"))
                {
                    Console.Write(words[i] + " ");
                }
            }

            Console.ReadLine();
            */


            //--------------------------------------------------------------------------------------------------------------------------

            





        }
    }
}
