namespace OperatorenÜberschreiben
{
    class Complex
    {
        public int real;
        public int imaginär;
        // real + i * imaginär

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.real + b.real, a.imaginär + b.imaginär);
        }
    }
}