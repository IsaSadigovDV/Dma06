namespace Relations.Entites.ManyToMany
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Author> Author { get; set; }

    }
}
