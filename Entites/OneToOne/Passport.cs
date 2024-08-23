using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Entites.OneToOne
{
    public class Passport
    {
        public int Id { get; set; }
        public string Issuer {  get; set; }
        public DateTime IssuerDate { get; set; }

        //relations
        public int CitizenId {  get; set; }
        public Citizen Citizen { get; set; }
    }
}


