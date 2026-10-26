# BankAccount — TDD with NUnit

Individual Activity.

## Requirements
- .NET 8 SDK
- Internet access for the first NuGet package restore

## Run the tests
Open a terminal in the `BankAccountTDD` folder and run:

```powershell
dotnet test BankAccount.Tests/BankAccount.Tests.csproj
```

The test project contains 8 NUnit tests.

## Red–Green–Refactor (TDD)
1. **Red:** Write a test for a requirement before writing the method. It initially fails.
2. **Green:** Implement the simplest logic to make the test pass.
3. **Refactor:** Clean up the implementation without changing the tested behavior, then rerun the tests.

The completed project contains the final code and tests; it does not include a recorded sequence of earlier failing runs.

## Design decisions
- Accounts start with a balance of zero.
- Negative deposits and withdrawals throw `ArgumentOutOfRangeException`.
- Withdrawing more than the current balance throws `InvalidOperationException`.
- Zero amounts are allowed because the activity only prohibits negative amounts.
- `decimal` is used for monetary amounts.
