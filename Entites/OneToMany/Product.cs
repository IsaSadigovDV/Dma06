using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Entites.OneToMany
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //relations
        public int CategoryId {  get; set; }
        public Category Category { get; set; }
    }
}
