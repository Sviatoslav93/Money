using Monetary;

var money1 = new Money(100, Currency.Eur);

var money2 = new Money(100, Currency.Eur);

var sum = money1 + money2;
Console.WriteLine($"Sum: {sum.Amount} {sum.Currency}");

var difference = money1 - money2;
Console.WriteLine($"Difference: {difference.Amount} {difference.Currency}");

var product = money1 * 2;
Console.WriteLine($"Product: {product.Amount} {product.Currency}");

var quotient = money1 / 2;
Console.WriteLine($"Quotient: {quotient.Amount} {quotient.Currency}");

var isEqual = money1 == money2;
Console.WriteLine($"Is Equal: {isEqual}");

var isNotEqual = money1 != money2;
Console.WriteLine($"Is Not Equal: {isNotEqual}");

var isGreater = money1 > money2;
Console.WriteLine($"Is Greater: {isGreater}");

var isLess = money1 < money2;
Console.WriteLine($"Is Less: {isLess}");    