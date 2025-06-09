using Monetary;

var money = new Money(100, Currency.Eur);

var money2 = new Money(100, Currency.Eur);

var sum = money + money2;
Console.WriteLine($"Sum: {sum.Amount} {sum.Currency}");

var difference = money - money2;
Console.WriteLine($"Difference: {difference.Amount} {difference.Currency}");

var product = money * 2;
Console.WriteLine($"Product: {product.Amount} {product.Currency}");

var quotient = money / 2;
Console.WriteLine($"Quotient: {quotient.Amount} {quotient.Currency}");

var isEqual = money == money2;
Console.WriteLine($"Is Equal: {isEqual}");

var isNotEqual = money != money2;
Console.WriteLine($"Is Not Equal: {isNotEqual}");

var isGreater = money > money2;
Console.WriteLine($"Is Greater: {isGreater}");

var isLess = money < money2;
Console.WriteLine($"Is Less: {isLess}");    