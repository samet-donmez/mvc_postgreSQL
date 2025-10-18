namespace mvc_postgresql.Models
{
    public class Departman
    {
        public int Id { get; set; }
        public string DepartmanAd { get; set; }
        public List<Personel> Personeller { get; set; }

    }
}
