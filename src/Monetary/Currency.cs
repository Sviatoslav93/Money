namespace Monetary;

public readonly record struct Currency
{
    public string Code { get; init; }
    public static Currency Eur => new() { Code = "EUR" };
    public static Currency Usd => new() { Code = "USD" };
}