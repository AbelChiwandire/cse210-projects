using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int top)
    {
        _numerator = top;
        _denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public int GetTop()
    {
        return _numerator;
    }

    public void SetTop(int top)
    {
        _numerator = top;
    }

    public int GetTBottom()
    {
        return _denominator;
    }

    public void SetBottom(int bottom)
    {
        _denominator = bottom;
    }

    public string GetFractionString()
    {
        string stringTop = _numerator.ToString();
        string stringBottom = _denominator.ToString();

        return stringTop + "/" + stringBottom;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }  
    
}