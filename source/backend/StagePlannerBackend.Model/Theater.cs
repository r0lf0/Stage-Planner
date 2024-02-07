using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StagePlannerBackend.Model
{
    public class Theater
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } 

        [StringLength(500)]
        public string Address { get; set; } 

        public ICollection<Show> Shows { get; set; }

        public Theater()
        {
            Shows = new HashSet<Show>(); // Initialize the collection of shows
        }
    }
}
