namespace ClienteAPI.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? DeletionDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
