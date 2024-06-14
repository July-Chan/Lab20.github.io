using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Метод для розподілу комплексних чисел
        public ComplexNumber Divide(ComplexNumber other)
        {
            double real = (Real * other.Real + Imaginary * other.Imaginary) / (other.Real * other.Real + other.Imaginary * other.Imaginary);
            double imaginary = (Imaginary * other.Real - Real * other.Imaginary) / (other.Real * other.Real + other.Imaginary * other.Imaginary);
            return new ComplexNumber(real, imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
