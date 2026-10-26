using BankAccountApp;
using NUnit.Framework;

namespace BankAccountApp.Tests;

[TestFixture]
public class BankAccountTests
{
    private BankAccount _account = null!;

    [SetUp]
    public void SetUp() => _account = new BankAccount();

    [Test]
    public void NewAccount_StartsWithZeroBalance()
    {
        Assert.That(_account.GetBalance(), Is.EqualTo(0m));
    }

    [Test]
    public void Deposit_PositiveAmount_IncreasesBalance()
    {
        _account.Deposit(100m);
        Assert.That(_account.GetBalance(), Is.EqualTo(100m));
    }

    [Test]
    public void Deposit_NegativeAmount_ThrowsException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _account.Deposit(-10m));
    }

    [Test]
    public void Withdraw_ValidAmount_DecreasesBalance()
    {
        _account.Deposit(100m);
        _account.Withdraw(40m);
        Assert.That(_account.GetBalance(), Is.EqualTo(60m));
    }

    [Test]
    public void Withdraw_NegativeAmount_ThrowsException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _account.Withdraw(-10m));
    }

    [Test]
    public void Withdraw_MoreThanBalance_ThrowsException()
    {
        _account.Deposit(50m);
        Assert.Throws<InvalidOperationException>(() => _account.Withdraw(80m));
        Assert.That(_account.GetBalance(), Is.EqualTo(50m));
    }

    [Test]
    public void Withdraw_EntireBalance_LeavesZero()
    {
        _account.Deposit(75m);
        _account.Withdraw(75m);
        Assert.That(_account.GetBalance(), Is.EqualTo(0m));
    }

    [Test]
    public void MultipleDepositsAndWithdrawals_CalculateCorrectBalance()
    {
        _account.Deposit(100m);
        _account.Deposit(25m);
        _account.Withdraw(30m);
        Assert.That(_account.GetBalance(), Is.EqualTo(95m));
    }
}
