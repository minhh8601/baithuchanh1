using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5
{
    class MaTran
    {
        private int sh, sc;
        private int[,] a;
        public void Nhap()
        {
            Console.Write("Nhap so hang sh:"); sh = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot sc:"); sc = int.Parse(Console.ReadLine());
            a = new int[sh, sc];
            Console.WriteLine("Nhap thong tin cho cac phan tu cua ma tran");
            for (int i = 0; i < sh; ++i)
                for (int j = 0; j < sc; ++j)
                {
                    Console.Write("a[{0},{1}]=", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }
        public void Hien()
        {
            Console.WriteLine("Cac phan tu cua ma tran la");
            for (int i = 0; i < sh; ++i)
            {
                for (int j = 0; j < sc; ++j)
                    Console.Write("{0}\t", a[i, j]);
                Console.WriteLine();
            }
        }
        public MaTran Tong(MaTran t2)
        {
            if (this.sh == t2.sh && this.sc == t2.sc)
            {
                MaTran t = new MaTran();
                t.sh = this.sh;
                t.sc = this.sc;
                t.a = new int[this.sh, this.sc];

                for (int i = 0; i < t.sh; ++i)
                    for (int j = 0; j < t.sc; ++j)
                        t.a[i, j] = this.a[i, j] + t2.a[i, j];
                return t;
            }
            else return null;
        }
    }

}
