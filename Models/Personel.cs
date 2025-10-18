namespace mvc_postgresql.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public int Yas { get; set; }
        public int DepartmanId { get; set; }
        public Departman Departman { get; set; }
        
        }
}
