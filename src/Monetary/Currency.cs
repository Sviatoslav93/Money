namespace Monetary;

public readonly record struct Currency(string Code)
{
    public string Code { get; } = Code;

    public override string ToString() => Code;

    public static implicit operator Currency(string code) => new Currency(code);
}