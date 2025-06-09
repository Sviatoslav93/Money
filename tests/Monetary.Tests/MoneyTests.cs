namespace Monetary.Tests;

public class MoneyTests
{
    [Fact]
    public void Addition_SameCurrency_Works()
    {
        var m1 = new Money(10m, Currency.Usd);
        var m2 = new Money(5m, Currency.Usd);
        var result = m1 + m2;
        Assert.Equal(new Money(15m, Currency.Usd), result);
    }

    [Fact]
    public void Addition_DifferentCurrency_Throws()
    {
        var m1 = new Money(10m, Currency.Usd);
        var m2 = new Money(5m, Currency.Eur);
        Assert.Throws<InvalidOperationException>(() => { var _ = m1 + m2; });
    }

    [Fact]
    public void Subtraction_SameCurrency_Works()
    {
        var m1 = new Money(10m, Currency.Usd);
        var m2 = new Money(3m, Currency.Usd);
        var result = m1 - m2;
        Assert.Equal(new Money(7m, Currency.Usd), result);
    }

    [Fact]
    public void Subtraction_DifferentCurrency_Throws()
    {
        var m1 = new Money(10m, Currency.Usd);
        var m2 = new Money(3m, Currency.Eur);
        Assert.Throws<InvalidOperationException>(() => { var _ = m1 - m2; });
    }

    [Fact]
    public void Multiplication_Works()
    {
        var m = new Money(10m, Currency.Usd);
        var result = m * 2;
        Assert.Equal(new Money(20m, Currency.Usd), result);
    }

    [Fact]
    public void Division_Works()
    {
        var m = new Money(10m, Currency.Usd);
        var result = m / 2;
        Assert.Equal(new Money(5m, Currency.Usd), result);
    }

    [Fact]
    public void Equality_Works()
    {
        var m1 = new Money(10m, Currency.Usd);
        var m2 = new Money(10m, Currency.Usd);
        Assert.True(m1 == m2);
        Assert.False(m1 != m2);
    }

    [Fact]
    public void Inequality_Works()
    {
        var m1 = new Money(10m, Currency.Usd);
        var m2 = new Money(5m, Currency.Usd);
        Assert.True(m1 != m2);
        Assert.False(m1 == m2);
    }
}