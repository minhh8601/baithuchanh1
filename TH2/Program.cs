using System;
namespace TH2
{
    class Diem
    {
        private double x;
        private double y;
        public Diem(double ox, double oy)
        {
            x = ox;
            y = oy;
        }
        public Diem()
        {
            x = y = 0;
        }
        public void Nhap()
        {
            Console.Write("Nhap toa do cua x=");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do cua y=");
            y = double.Parse(Console.ReadLine());
        }
        public void HienThi()
        {
            Console.WriteLine("Toa do la: {0},{1}", x, y);
        }
        public double KhoangcCach(Diem d1, Diem d2)
        {
            double kc = Math.Sqrt((d1.x - d2.x) * (d1.x - d2.x) + (d1.y - d2.y) * (d1.y - d2.y));
            return kc;
        }
        static void Main(string[] args)
        {
            Diem t = new Diem();
            t.Nhap();
            t.HienThi();
            Console.ReadKey();
        }
    }
}
