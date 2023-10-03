using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkeloefening.Modellen
{
    internal class Product
    {
        public int Id { get; set; }

        [StringLength (maximumLength: 50)]
        public string Name { get; set; }

        [StringLength (maximumLength: 500)]
        public string Description { get; set; }

        [ForeignKey("Categorieen")]
        public int CategorieId { get; set; }

        public Categorie? Categorie { get; set; }

    }
}
