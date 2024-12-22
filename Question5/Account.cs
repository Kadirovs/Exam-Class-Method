public class Account
{
	public string ownerName;
	public int balance;

	public void deposit(int amount)
    {
        if (amount > 0)
        {
            balance +=amount;
            Console.WriteLine($"{amount} somoni added to your Bank account, your new Balance: {balance}");
        }
        else
        {
            Console.WriteLine("entering should be positive.");
        }
    }
	 public void Withdraw(int amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"{amount} somoni left your Bank account, your new Balance: {balance}");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Error.");
        }
        else
        {
            Console.WriteLine("It should be positive.");
        }
    }

	
}