﻿using System;
using System.Collections.Generic;

namespace Contains_Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arrs = new int[][] { 
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15, 
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687, 
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4 
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                },
                new int[] {
                    1, 5, 3, 4, 8, 9, 6, 10, 11, 2, 13, 14, 15,
                    16, 82, 54, 68, 413, 446, 4567, 46576478, 4687,
                    45867, 487, 4874578,7878, 4847, 874, 8, 4, 4
                }
            };

            for (int i = 0; i < arrs.Length; i++)
            {
                var arr = arrs[i];

                DateTime s = DateTime.Now;
                bool sort = ContainsBySort(arr);
                DateTime e = DateTime.Now;
                Console.Write(sort + " => Sort Performance: " + (e - s).TotalMilliseconds + "ms\n");
            
                s = DateTime.Now;
                bool hashSet = ContainsByHashSet(arr);
                e = DateTime.Now;

                Console.WriteLine(hashSet + " => Hashset Performance: " + (e - s).TotalMilliseconds + "ms\n");
                //Console.Write("\nNext?");
                //Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static bool ContainsByHashSet(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (set.Contains(arr[i])) return true;
                set.Add(arr[i]);
            }

            return false;
        }

        public static bool ContainsBySort(int[] arr)
        {
            Array.Sort(arr);

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i + 1]) return true;
            }

            return false;
        }
    }
}
