using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngülerle_Pratik_Uygulamalar__Yıldızlarla_Şekil_Çizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız olusturma
            //for(int i = 0; i <=10; i++) 
            // {
            //   Console.WriteLine("*");

            // }
            #endregion
            #region yan yana 10 tane yıldız olusturma
            //for(int i = 0; i <=10; i++) 
            // {
            //   Console.Write("*");

            // }
            #endregion
            #region Alt alta yıldız olusturma her satırda 10 tane yıldız olsun
            // for(int i = 0; i <10; i++)
            // {
            //    Console.WriteLine(**********);
            // }
            #endregion
            #region Dik üçgen
            // for(int i = 1; i <=5; i++)
            // {
            //  for(int j = 1; j <= i; j++) 
            // {
            //     Console.Write("*");
            //  }
            // Console.WriteLine();
            //  }
            #endregion
            #region  Ters Dik üçgen
            // for (int i = 5; i >= 1; i--)
            // {
            //  for (int j = 1; j <= i; j++)
            // {
            //   Console.Write("*");
            //  }
            //  Console.WriteLine();
            // }
            #endregion
            #region  Ters Dik üçgen
            // for (int i = 1; i <= 5; i++)
            // {
            //    for (int j = 1; j <= i; j++)
            //  {
            //    Console.Write("*");
            //   }
            //    Console.WriteLine();
            //  }
            //  for (int k= 4; k >= 1; k--)
            // {
            //  for (int m = 1; m <= k; m++)
            // {
            //   Console.Write("*");
            //  }
            //  Console.WriteLine();
            //  }



            #endregion
            #region Baklava Dilimi
            /*   int n = 5; // Üçgenin yüksekliği

               // Üçgen kısmı
               for (int i = 1; i <= n; i++) // Satır döngüsü
               {
                   // Boşluklar
                   for (int j = n - i; j > 0; j--)
                   {
                       Console.Write(" "); // Boşluk yaz
                   }

                   // Yıldızlar
                   for (int k = 1; k <= 2 * i - 1; k++)
                   {
                       Console.Write("*"); // Yıldız yaz
                   }

                   Console.WriteLine(); // Her satırdan sonra yeni bir satıra geç
               }

               // Ters üçgen kısmı
               for (int i = n - 1; i >= 1; i--) // Satır döngüsü
               {
                   // Boşluklar
                   for (int j = n - i; j > 0; j--)
                   {
                       Console.Write(" "); // Boşluk yaz
                   }

                   // Yıldızlar
                   for (int k = 1; k <= 2 * i - 1; k++)
                   {
                       Console.Write("*"); // Yıldız yaz
                   }

                   Console.WriteLine(); // Her satırdan sonra yeni bir satıra geç
               }
            */
            #endregion
            #region Piramit 
            /* int n = 5; // Üçgenin yüksekliği

              for (int i = 1; i <= n; i++) // Satır döngüsü
              {
                  // Boşluklar
                  for (int j = n - i; j > 0; j--)
                  {
                      Console.Write(" "); // Boşluk yaz
                  }

                  // Yıldızlar
                  for (int k = 1; k <= 2 * i - 1; k++)
                  {
                      Console.Write("*"); // Yıldız yaz
                  }

                  Console.WriteLine(); // Her satırdan sonra yeni bir satıra geç
              }  
            */
            #endregion
            #region ters piramit
         /*   int n = 5; // Üçgenin yüksekliği

            for (int i = n; i >= 1; i--) // Satır döngüsü
            {
                // Boşluklar
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" "); // Boşluk yaz
                }

                // Yıldızlar
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*"); // Yıldız yaz
                }

                Console.WriteLine(); // Her satırdan sonra yeni bir satıra geç
            }
         */

            #endregion





            Console.ReadLine(); 
        }
    }
}


