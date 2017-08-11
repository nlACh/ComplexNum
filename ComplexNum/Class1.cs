using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNum
{
    public class Class1
    {
        public struct Complex
        {
            public Int32 re;
            public Int32 im;
        }
        //method to add complex numbers
        public Complex Add(Complex c1, Complex c2)
        {
            Complex c;
            c.re = c1.re + c2.re;
            c.im = c1.im + c2.im;
            return c;
        }
        //method to subtract complex numbers
        public Complex Sub(Complex c1, Complex c2)
        {
            Complex c;
            c.re = c1.re - c2.re;
            c.im = c1.im - c2.im;
            return c;
        }
        //method to multiply complex numbers
        public Complex Mul(Complex c1, Complex c2)
        {
            Complex c;
            c.re = c1.re * c2.re - c1.im * c2.im;
            c.im = c1.re * c2.im + c1.im + c2.re;
            return c;
        }
        //method to "divide" complex numbers
        public Complex Div(Complex c1, Complex c2)
        {
            Complex c;
            //basically divison works by multiplying with conjugate...
            c2.im = -c2.im;
            c = Mul(c1, c2);
            //so divide both components with c2.re^2+c2.im^2
            c.re = c.re / (c2.re ^ 2 + c2.im ^ 2);
            c.im = c.im / (c2.re ^ 2 + c2.im ^ 2);
            return c;
        }
        public float Mod(Complex c)
        {
            return (c.re ^ 2 + c.im ^ 2);
        }
    }
}
