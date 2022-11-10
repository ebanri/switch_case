using System;

namespace switch_case{

    class Program{
        static void Main(string[] args){

            int ay = DateTime.Now.Month; //sistemdeki anlık saati int değerine atadık.

            switch(ay){ // int değeri kaçsa, yani hangi aydaysak o case çalışır ve çıktı alınır.
                case 1:
                Console.WriteLine("Ocak Ayındayız!");
                break;
                case 2:
                Console.WriteLine("Şubat Ayındayız!");
                break;
                case 3:
                Console.WriteLine("Mart Ayındayız!");
                break;
                case 4:
                Console.WriteLine("Nisan Ayındayız!");
                break;
                case 5:
                Console.WriteLine("Mayıs Ayındayız!");
                break;
                case 6:
                Console.WriteLine("Haziran Ayındayız!");
                break;
                case 7:
                Console.WriteLine("Temmuz Ayındayız!");
                break;
                case 8:
                Console.WriteLine("Ağustos Ayındayız!");
                break;
                case 9:
                Console.WriteLine("Eylül Ayındayız!");
                break;
                case 10:
                Console.WriteLine("Ekim Ayındayız!");
                break;
                case 11:
                Console.WriteLine("Kasım Ayındayız!");
                break;
                case 12:
                Console.WriteLine("Aralık Ayındayız!");
                break;
                
                default:
                Console.WriteLine("Ay değeri doğru alınamadığından çıktısı yazdırılamadı!");
                break;
            }

            Console.WriteLine("*******************");

            switch(ay){ //hangi mevsimdeysek o case çalışıyor ve çıktısı ekrana geliyor.
                case 12:
                case 1:
                case 2:
                Console.WriteLine("Kış ayındayız!");
                break;

                case 3:
                case 4:
                case 5:
                Console.WriteLine("İlkbahar ayındayız!");
                break;

                case 6:
                case 7:
                case 8:
                Console.WriteLine("Yaz ayındayız!");
                break;

                case 9:
                case 10:
                case 11:
                Console.WriteLine("Sonbahar Ayındayız!");
                break;

                default:
                Console.WriteLine("Ay değeri doğru alınamadığından çıktısı yazdırılamadı!");
                break;
            }
        }
    }
}
