namespace BankAccountApp;

public class BankAccount
{
    private decimal _balance;

    public void Deposit(decimal amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Deposit cannot be negative.");

        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal cannot be negative.");

        if (amount > _balance)
            throw new InvalidOperationException("Insufficient funds.");

        _balance -= amount;
    }

    public decimal GetBalance() => _balance;
}
