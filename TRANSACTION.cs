namespace BANK_PROJECT
{
    public class TRANSACTION //For transaction
    {
        public string Type { get; } //Type of transaction
        public decimal Amount { get; } //Amount of transaction
        public DateTime Date { get; } //Date of transaction

        public TRANSACTION(string type, decimal amount) // Constructor
        {
            Type = type; //Set type
            Amount = amount; //Set amount
            Date = DateTime.Now; //Set date
        }

        public override string ToString() //Format transaction for display
        {
            return $"{Date:G}: {Type} of ${Amount:F2}"; //Amount F2 two decimal and data
        }
    }
}
