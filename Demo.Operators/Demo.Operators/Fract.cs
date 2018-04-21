
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Demo.Operators
{
    class Fract
    {
        private int ch;
        private int zn;
        public int Chislitel
        {
            get { return ch; }
            set { ch = value; }
        }
        public int Znamenatel
        {
            get { return zn; }
            set
            {
                if (value == 0) throw new DivideByZeroException("Делить на 0 нельзя");
                else zn = value;
            }
        }
        public Fract(int ch = 0, int zn = 1)
        {
            Chislitel = ch;
            Znamenatel = zn;
        }
        public override string ToString()
        {
            return Chislitel > Znamenatel
                ? $"{Chislitel / Znamenatel} + {Chislitel % Znamenatel}/{Znamenatel}" : $"{Chislitel}/{Znamenatel}";
        }
        public static Fract operator+(Fract a, Fract b)
        {
            return new Fract(a.ch * b.zn + b.ch * a.zn, a.zn * b.zn);
        }
        public static Fract operator -(Fract a) //унарный, меняет знак на противоположный
        {
            return new Fract(-a.ch, a.zn);
        }
        public static bool operator > (Fract a, Fract b) //логические и операторы сравнения - только парно
        {
            return a.ch * b.zn < b.ch * a.zn;
        }
        public static bool operator <(Fract a, Fract b) //логические и операторы сравнения - только парно
        {
            return a.ch * b.zn > b.ch * a.zn;
        }
        public static explicit operator int(Fract a)
        {
            return a.ch / a.zn;
        }

        public static Fract operator *(Fract a, Fract b)
        {
            return new Fract(a.ch * b.ch, a.zn * b.zn);
        }

        public static Fract operator *(Fract a, int b)
        {
            return new Fract(a.ch * b, a.zn);
        }

        public static Fract operator *(int a, Fract b)
        {
            return new Fract(a * b.ch, b.zn);
        }

        public static Fract operator /(Fract a, Fract b)
        {
            return new Fract(a.ch * b.zn, a.zn * b.ch);
        }

        public static Fract operator /(Fract a, int b)
        {
            return new Fract(a.ch, a.zn * b);
        }

        public static Fract operator /(int a, Fract b)
        {
            return new Fract(b.ch, a * b.zn);
        }

    }
}