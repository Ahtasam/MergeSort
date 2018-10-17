using System;

namespace MergeSort
{
    class MergeSort
    {
        public static void Merge(int[] A, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1+1];
            int[] R = new int[n2+1];
            int i, j;
            for (i = 0; i < n1; i++)
            {
                L[i] = A[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = A[q + 1 + j];
            }
            L[n1] = int.MaxValue;
            R[n2] = int.MaxValue;
            i = 0;
            j = 0;

            int k ;
            for (k=p;k<=r;k++)
             {
                 if (L[i] <= R[j])
                 { 
                     A[k] = L[i];
                     i = i + 1;
                 }
                 else
                 {
                     A[k] = R[j];
                     j = j + 1;
                 }
             }
        }
       public static void Msort(int[] A,int p,int r)
        {
            if(p<r)
            {
                int  q = (p + r) / 2;
                Msort(A, p, q);
                Msort(A, q + 1, r);
                Merge(A, p, q, r);
            }
        }
       
       public static void Main(string[] args)
        {
            int[] A = { 12, 11, 13, 5, 6, 7 ,9,23,25};

            Msort(A, 0, A.Length - 1);
            for (int i = 0; i <A.Length; i++)
              {
                 Console.WriteLine(A[i]);
              }
            Console.ReadLine();
        }
    }
}
