// ////   6 - Topshiriq 15-misol
//
// //Console.Write("O'nlik sanoq sistemasidagi sonni kiriting: ");
// //int p = int.Parse(Console.ReadLine());
// //Console.WriteLine("Nechalik sanoq sistemaga o'tmoqchisiz");
// //int n = int.Parse(Console.ReadLine());
// //int qoldiq = 0;
// //int nat = 0;
// //int a = 1;
//
// //while (p > 0)
// //{
// //    qoldiq = p % n;
// //    p /= n;
// //    if (qoldiq < 10)
// //    {
// //        nat += qoldiq * a;
// //    }
// //    else if (qoldiq > 9)
// //    {
// //        switch (qoldiq)
// //        {
// //            case 10: Console.Write('A'); break;
// //            case 11: Console.Write('B'); break;
// //            case 12: Console.Write('C'); break;
// //            case 13: Console.Write('D'); break;
// //            case 14: Console.Write('E'); break;
// //            case 15: Console.Write('F'); break;
// //        }
// //    }
// //    a *= 10;
// //}
// //if (qoldiq < 10)
// //{
// //    Console.Write(nat);
// //}
//
//
// //// 5 - Topshiriq 30-misol
//
// //Console.Write("O'nlik sanoq sistemasidagi sonni kiriting: ");
// //int onlik = int.Parse(Console.ReadLine());
// //int qoldiq = 0;
// //int on_olti = 0;
// //int p = 1;
//
// //while (onlik > 0)
// //{
// //    qoldiq = onlik % 16;
// //    onlik /= 16;
// //    if (qoldiq < 10)
// //    {
// //        on_olti += qoldiq * p;
//
// //    }
// //    else if (qoldiq > 9)
// //    {
// //        switch (qoldiq)
// //        {
// //            case 10: Console.Write('A'); break;
// //            case 11: Console.Write('B'); break;
// //            case 12: Console.Write('C'); break;
// //            case 13: Console.Write('D'); break;
// //            case 14: Console.Write('E'); break;
// //            case 15: Console.Write('F'); break;
// //        }
// //    }
// //    p *= 10;
// //}
// //if (qoldiq < 10)
// //{
// //    Console.Write(on_olti);
// //}
//
// // 8 - Topshiriq
//
// // int[,] kun = new int[12, 31];
// // int[] oy = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
// // int k = 1;
// // for (int i = 0; i < 12; i++)
// // {
// //     for (int j = 0; j < oy[i]; j++)
// //     {
// //         int hafta;
// //         if (k % 7 == 0)
// //         {
// //             hafta = 7;
// //         }
// //         else
// //         {
// //             hafta = (k % 7);
// //         }
// //         kun[i, j] = hafta;
// //         k++;
// //     }
// // }
// //
// // for (int i = 0; i < 12; i++)
// // {
// //     for (int j = 0; j < 31; j++)
// //     {
// //         Console.Write(kun[i, j]);
// //         Console.Write(' ');
// //     }
// //     Console.WriteLine();
// // }
//
//
// // 11-Topshiriq
//
// namespace Dasturlash_topshiriq;
//
// class Program
// {
//     public static void task_1()
//     {
//         Console.WriteLine("Matnni kiriting:");
//         string matn = Convert.ToString(Console.ReadLine());
//         Satr s = new Satr(matn);
//         foreach (var soz in s.bir_marta())
//         {
//             Console.WriteLine(soz);
//         }
//
//         Console.WriteLine("______________________________");
//     }
//
//     public static void task_2()
//     {
//         Console.WriteLine("Matnni kiriting:");
//         string matn = Convert.ToString(Console.ReadLine());
//         Satr s = new Satr(matn);
//         foreach (var nat in s.bir_necha())
//         {
//             Console.WriteLine(nat);
//         }
//
//         Console.WriteLine("________________________________");
//     }
//
//     public static void task_3()
//     {
//         Console.WriteLine("Matnni kiriting:");
//         string matn = Convert.ToString(Console.ReadLine());
//         Satr s = new Satr(matn);
//         foreach (var soz in s.alfabit())
//         {
//             Console.WriteLine(soz);
//         }
//     }
//
//
//     static void Main(string[] args)
//     {
//         task_1();
//     }
// }
//
// public class Satr
// {
//     public string gap;
//     public string[] sozlar;
//
//     public Satr(string gap)
//     {
//         this.gap = gap;
//         this.ajratish();
//     }
//
//     private void ajratish()
//     {
//         gap = gap.Replace(',', ' ');
//         sozlar = gap.Split(' ');
//     }
//
//     public string[] bir_marta()
//     {
//         string[] nat = new string[sozlar.Length];
//         int q = 0;
//         foreach (var soz in sozlar)
//         {
//             int c = this.sanash(soz);
//             if (c == 1)
//             {
//                 nat[q] = soz;
//                 q++;
//             }
//         }
//
//         return nat;
//     }
//
//     public string[] bir_necha()
//     {
//         string[] nat = new string[sozlar.Length];
//         int q = 0;
//         foreach (var soz in sozlar)
//         {
//             int c = this.sanash(soz);
//             if (c > 1 && !nat.Contains(soz))
//             {
//                 nat[q] = soz;
//                 q++;
//             }
//         }
//
//         return nat;
//     }
//
//     public string[] alfabit()
//     {
//         string[] alfa = new string[sozlar.Length];
//         gap = gap.Replace(',', ' ');
//         string[] massiv = gap.Split(' ');
//         foreach (var nat in sozlar)
//         {
//             Array.Sort(sozlar);
//         }
//
//         return sozlar;
//     }
//
//     private int sanash(string soz)
//     {
//         int c = 0;
//         for (int i = 0; i < sozlar.Length; i++)
//         {
//             if (soz == sozlar[i])
//             {
//                 c++;
//             }
//         }
//
//         return c;
//     }
//
//     public override string ToString()
//     {
//         return this.gap;
//     }
// }