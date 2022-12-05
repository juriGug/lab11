using System;
namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        // TODO: fill this class\

        public double Real { get; set;}
        public double Imaginary { get; set;}

        public Complex(double real, double imm)
        {
            this.Real = real;
            this.Imaginary = imm;
        }

        public Complex Complement()
        {
            return new Complex(this.Real, -(this.Imaginary) );
        }

        public Complex Plus(Complex i)
        {
            return new Complex(Real + i.Real, Imaginary + i.Imaginary);
        }

        public override string ToString()
        {
            return Real + "+ (i" + Imaginary +")";
        }

        public double Modulus => Math.Sqrt(Real * Real + Imaginary * Imaginary);

        public double Phase => Math.Atan2(Imaginary, Real);

        public Complex Minus(Complex m)
        {
            return new Complex(Real - m.Real, Imaginary - m.Imaginary);
        }
        public bool Equals(Complex c)
        {
            return (Real == c.Real && Imaginary == c.Imaginary);
        }

    }
}