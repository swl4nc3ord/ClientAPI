namespace ClienteAPI.Entity
{
    public class User
    {
        public long UserId { get; set; }
        public string TaxNumber { get; set; }
        public string  FullName { get; set; }
        public decimal IncomeValue { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeletionDate { get; set; }

    }
}
