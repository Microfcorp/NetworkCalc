using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkCalc
{
    public class NetworkStatic
    {

    }

    public static class ExternalVoids
    {
        public static Point MinimalPoint(this Control Start, Control End)
        {
            int X = int.MaxValue;
            for (int i = Start.Location.X; i < Start.Location.X + Start.Size.Width; i++) //начало
            {
                for (int a = End.Location.X; a < End.Location.X + End.Size.Width; a++) //конец
                {
                    if (Distantion(new Point(i, 1), new Point(a, 1)) < X)
                        X = a;
                }
            }

            int Y = int.MaxValue;
            for (int i = Start.Location.Y; i < Start.Location.Y + Start.Size.Height; i++) //начало
            {
                for (int a = End.Location.Y; a < End.Location.Y + End.Size.Height; a++) //конец
                {
                    if (Distantion(new Point(X, i), new Point(X, a)) < Y)
                        Y = a;
                }
            }

            return new Point(X, Y);
        }

        /// <summary>
        /// Расстояние между двумя точками по теореме Пифагора
        /// </summary>
        /// <param name="Start">Точка старта</param>
        /// <param name="End">Точка окончания</param>
        /// <param name="K">Коэффициент квантования</param>
        /// <returns></returns>
        public static int Distantion(this Point Start, Point End, int K = 1)
        {
            int x = Math.Abs(Start.X - End.X) / K; //Модуль разности координат X, деленое на размер клетки
            int y = Math.Abs(Start.Y - End.Y) / K; //Модуль разности координат Y, деленое на размер клетки
            return (int)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)); //Квадратный корень из суммы квадров координат
        }
    }

    /// <summary>
    /// Скорость интернет соединения
    /// </summary>
    public enum NetworkSpeed : int
    {
        /// <summary>
        /// 10
        /// </summary>
        Ethernet = 0,
        /// <summary>
        /// 100/10
        /// </summary>
        FastEthernet = 1,
        /// <summary>
        /// 1000/100/10
        /// </summary>
        GigabitEthernet = 2,
    }
}
