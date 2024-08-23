using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Entites.OneToOne
{
    public class Citizen
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public string Surname {  get; set; }

        //relations
        public Passport Passport { get; set; }
    }
}
