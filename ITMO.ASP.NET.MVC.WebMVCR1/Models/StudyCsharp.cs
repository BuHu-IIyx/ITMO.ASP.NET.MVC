﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace ITMO.ASP.NET.MVC.WebMVCR1.Models
{
    public enum AccountType
    {
        Checking,
        Deposit
    }
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
        public override string ToString()
        {
            string res = $"Номер счета {accNo}, баланс {accBal}, тип {accType}";
            return res;
        }
    }
    public class StudyCsharp
    {
        public static string SetStatus(int age)
        {
            string status = "junior developer";
            if ((age > 2) && (age < 7)) status = "middle developer";
            else if ((age >= 7) && (age < 15)) status = "senior developer";
            else if ((age >= 15)) status = "sensei";
            return status;
        }
        public static string GetFunction(double x1, double x2)
        {
            StringBuilder str = new StringBuilder();
            double x = x1;
            do
            {
                str.AppendFormat("x = {0:0.##} : y = {1:0.##}; <br>", x, Math.Pow(x, 3)); x = x + 0.5;
            }
            while (x <= x2);
            return str.ToString();
        }
        public static bool Factorial(int n, out int answer)
        {
            int k;
            int f = 1;
            bool ok = true;
            try
            {
                checked
                {
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                f = 0;
                ok = false;
            }
            answer = f;
            return ok;
        }
    }
    public class Triangle : Shape, IComparable<Triangle>
    {        
        public double Stb { get; set; }
        public double Stc { get; set; }
        override public string Name => $"\"Треугольник со сторонами {St},{Stb} и {Stc}\"";
        public double Perimeter => Math.Round(St + Stb + Stc);
        public double Area
        {
            get
            {
                double sq = Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - St) * (Perimeter / 2 - Stb) * (Perimeter / 2 - Stc));
                return sq;
            }
        }
        public Triangle(double a, double b, double c)
        {
            St = a;
            Stb = b;
            Stc = c;
        }

        public int CompareTo(Triangle other)
        {
            if (this.Perimeter == other.Perimeter)
                return 0;
            else if (this.Perimeter > other.Perimeter)
                return 1;
            else 
                return -1;
        }
    }
    public class Circle : Shape, IComparable<Circle>
    {        
        override public string Name
        {
            get { return String.Format("\"Окружность с радиусом {0}\"", St); }
        }
        public Circle(double a)
        {
            St = a; 
        }
        public double Dlina
        {
            get
            { 
                double p = 2 * Math.PI * St;
                return p; 
            } 
        }
        public double Area
        {
            get
            {
                double sq = Math.PI * St * St;
                return sq;
            }
        }

        public int CompareTo(Circle other)
        {
            if (this.Area == other.Area) 
                return 0; 
            else if (this.Area > other.Area) 
                return 1; 
            else 
                return -1;
        }
    }
    public class Shape
    {
        public double St { get; set; }
        virtual public string Name
        {
            get { return String.Format("\"Фигура\""); }
        }
    }
}