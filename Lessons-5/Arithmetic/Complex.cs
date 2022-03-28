namespace Arithmetic;

internal class Complex : IEquatable<Complex>
{
    private int _actualPart;
    private int _imaginaryPart;
    private int _imaginaryUnit = 1;

    public int ActualPart
    {
        get { return _actualPart; }
        set { _actualPart = value; }
    }
    public int ImaginaryPart
    {
        get { return _imaginaryPart; }
        set { _imaginaryPart = value; }
    }

    public Complex(int actual, int imaginary)
    {
        _actualPart = actual;
        _imaginaryPart = imaginary;
    }

    public static Complex operator +(Complex operantA, Complex operantB)
    {
        return new Complex(operantA.ActualPart + operantB.ActualPart, operantA.ImaginaryPart + operantB.ImaginaryPart);
    }
    public static Complex operator -(Complex operantA, Complex operantB)
    {
        return new Complex(operantA.ActualPart - operantB.ActualPart, operantA.ImaginaryPart - operantB.ImaginaryPart);
    }
    // (a+bi)(c+di) = ac-bd + (ad+bc)i 
    public static Complex operator *(Complex operantA, Complex operantB)
    {
        return new Complex(operantA.ActualPart * operantB.ActualPart - operantA.ImaginaryPart * operantB.ImaginaryPart, 
            operantA.ActualPart * operantB.ImaginaryPart + operantA.ImaginaryPart * operantB.ActualPart);
    }
    public static bool operator ==(Complex operantA, Complex operantB)
    {
        return operantA.ActualPart == operantB.ActualPart & operantA.ImaginaryPart == operantB.ImaginaryPart;
    }
    public static bool operator !=(Complex operantA, Complex operantB)
    {
        return operantA.ActualPart != operantB.ActualPart | operantA.ImaginaryPart != operantB.ImaginaryPart;
    }


    public bool Equals(Complex? complex)
    {
        Complex a = this;
        Complex b = complex;
        if (a.ActualPart == b.ActualPart & a.ImaginaryPart == b.ImaginaryPart)
        {
            return true;
        }
        return false;
    }
    public override bool Equals(object? obj)
    {
        bool result = false;
        if (obj is Complex)
        {
            result = Equals((Complex)obj);
        }
        return result;
    }
    public override int GetHashCode()
    {
        return (_actualPart + _imaginaryPart + _imaginaryUnit).ToString().GetHashCode();
    }
    public override string ToString()
    {
        string sing = _imaginaryPart >= 0 ? "+" : "-";
        string viewImaginaryUnit = _imaginaryUnit > 0 ? "i" : "i2";
        return $"{_actualPart}{sing}{_imaginaryPart}{viewImaginaryUnit}";
    }
}
