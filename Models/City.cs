namespace Models
{
    public class City
    {
        public readonly static string INSERT = "INSERT INTO City (Description)" + "VALUES (@Description)";

        public readonly static string GETALL = "SELECT Id, Description FROM City";
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Registration_Date { get; set; }
    }
}