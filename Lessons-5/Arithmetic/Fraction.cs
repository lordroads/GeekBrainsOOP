using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic;

internal class Fraction
{
    private int _numerator;
    private int _denominator;

    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }
    public int Denominator
    {
        get { return _denominator; }
        set { _denominator = value; }
    }

    public Fraction(int numerator) : this(numerator, 1) { }
    public Fraction(int numerator, int denomirator)
    {
        _numerator = numerator;
        _denominator = denomirator;
    }

    #region Сравнение на равенство
    public static bool operator ==(Fraction? operantA, Fraction? operantB)
    {
        if (operantA?.Numerator == operantB?.Numerator & operantA?.Denominator == operantB?.Denominator)
        {
            return true;
        }
        return false;
    }
    public static bool operator !=(Fraction? operantA, Fraction? operantB)
    {
        if (operantA?.Numerator != operantB?.Numerator | operantA?.Denominator != operantB?.Denominator)
        {
            return true;
        }
        return false;
    }
    #endregion

    #region Сравнение на больше\меньше
    public static bool operator >(Fraction operantA, Fraction operantB)
    {
        if (operantA.Denominator == operantB.Denominator)
        {
            return operantA.Numerator > operantB.Numerator;
        }
        return operantA.Denominator > operantB.Denominator;
    }
    public static bool operator <(Fraction operantA, Fraction operantB)
    {
        if (operantA.Denominator == operantB.Denominator)
        {
            return operantA.Numerator < operantB.Numerator;
        }
        return operantA.Denominator < operantB.Denominator;
    }
    #endregion

    #region Сравнение на больше\меньше равно
    public static bool operator >=(Fraction operantA, Fraction operantB)
    {
        if (operantA.Denominator == operantB.Denominator)
        {
            return operantA.Numerator >= operantB.Numerator;
        }
        return operantA.Denominator >= operantB.Denominator;
    }
    public static bool operator <=(Fraction operantA, Fraction operantB)
    {
        if (operantA.Denominator == operantB.Denominator)
        {
            return operantA.Numerator <= operantB.Numerator;
        }
        return operantA.Denominator <= operantB.Denominator;
    }
    #endregion

    #region Арифметика
    public static Fraction operator +(Fraction operantA, Fraction operantB)
    {
        if (operantA.Denominator == operantB.Denominator)
        {
            return new Fraction(operantA.Numerator + operantB.Numerator, operantA.Denominator);
        }
        else
        {
            int commonDenominator = operantA.Denominator * operantB.Denominator / GetGreatestCommonDivisor(operantA.Denominator, operantB.Denominator);
            int multiplierA = commonDenominator / operantA.Denominator;
            int multiplierB = commonDenominator / operantB.Denominator;
            int numerator = operantA.Numerator * multiplierA + operantB.Numerator * multiplierB;
            return new Fraction(numerator, commonDenominator);
        }
    }
    public static Fraction operator -(Fraction operantA, Fraction operantB)
    {
        if (operantA.Denominator == operantB.Denominator)
        {
            return new Fraction(operantA.Numerator - operantB.Numerator, operantA.Denominator);
        }
        else
        {
            int commonDenominator = operantA.Denominator * operantB.Denominator / GetGreatestCommonDivisor(operantA.Denominator, operantB.Denominator);
            int multiplierA = commonDenominator / operantA.Denominator;
            int multiplierB = commonDenominator / operantB.Denominator;
            int numerator = operantA.Numerator * multiplierA - operantB.Numerator * multiplierB;
            return new Fraction(numerator, commonDenominator);
        }
    }
    public static Fraction operator ++(Fraction fraction)
    {
        return fraction + new Fraction(1);
    }
    public static Fraction operator --(Fraction fraction)
    {
        return fraction - new Fraction(1);
    }
    public static Fraction operator *(Fraction operantA, Fraction operantB)
    {
        int numerator = operantA.Numerator * operantB.Numerator;
        int denominator = operantA.Denominator * operantB.Denominator;
        return new Fraction(numerator, denominator);
    }
    public static Fraction operator /(Fraction operantA, Fraction operantB)
    {
        Fraction fractionReverse = operantB.GetReverse();
        int numerator = operantA.Numerator * fractionReverse.Numerator;
        int denominator = operantA.Denominator * fractionReverse.Denominator;
        return new Fraction(numerator, denominator);
    }
    #endregion

    #region Преобразование
    public static implicit operator float(Fraction fraction)
    {
        float result = (float)Math.Round((double)fraction.Numerator / fraction.Denominator, 2);
        return result;
    }
    public static explicit operator int(Fraction fraction)
    {
        return Convert.ToInt32(fraction.Numerator / fraction.Denominator);
    }
    #endregion

    #region Переопределение
    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }
    public override bool Equals(object? obj)
    {
        bool result = false;
        if (obj is Fraction)
        {
            result = Equals((Fraction)obj);
        }
        return result;
    }
    public bool Equals(Fraction fraction)
    {
        Fraction a = this;
        Fraction b = fraction;
        if (a.Numerator == b.Numerator & a.Denominator == b.Denominator)
        {
            return true;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return (_numerator + _denominator).ToString().GetHashCode();
    }
    #endregion

    // Возвращает наименьший общий делитель (Алгоритм Евклида)
    private static int GetGreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    private Fraction GetReverse()
    {
        return new Fraction(_denominator, _numerator);
    }
}
