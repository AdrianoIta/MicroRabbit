namespace MicroRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {
        public TransferLog()
        {

        }

        public int Id { get; set; }
        public string FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
