using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace visual_math
{
    internal class Class1
    {
        public double convertc(double f)
        {
            double c = 0.0;
            c = ((f - 32.0) * 5.0) / 9.0;
            return c;
        }

        public int kup(int x)
        {
            return x * x * x;
        }
        public double topkup(int n)
        {
            double sum = 0.0;
            for(int i=0;i<n;i++)
            {
                sum+=kup(i);
            }
            return sum;
        }
        public double fak(double n)
        {
            double sum = 1;
            for(int i = 1; i <= n; i++)
            {
                sum = sum * i;
            }
            return sum;
        }
        public double binom(double n,double k)
        {
            return fak(n) / (fak(k) * fak(n - k));
        }
        public double formula(double number)
        {
            double result = 0.0;
            for(int k = 0; k <=number; k++)
            {
                result += Math.Pow(binom(number, k), 2);
            }
            return result;
        }
        public double formula2(double x,double n)
        {
            return (Math.Pow(x,n)/fak(n));
        }

        public string removePanc(string str)
        {
            return str.Replace(".", "").Replace(";", "").Replace(",", "").Replace(":", "").Replace("!", "").Replace("?", "");
        }

    }
}
