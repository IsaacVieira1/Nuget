﻿namespace MoneyExtension.Tests;

[TestClass]
public sealed class MoneyExtensionsTests
{
    [TestMethod]
    public void ShouldConvertDecimaltoInt()
    {
        decimal valor = 279.98M;
        var cents = valor.ToCents();

        Assert.AreEqual(27998, cents);
    }
}
