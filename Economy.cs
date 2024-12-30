public class Economy
{
    public int PlayerMoney { get; private set; } = 100;

    public void SpendMoney(int amount)
    {
        if (amount > PlayerMoney)
        {
            throw new InvalidOperationException("Not enough money to complete the transaction.");
        }
        PlayerMoney -= amount;
    }
}
