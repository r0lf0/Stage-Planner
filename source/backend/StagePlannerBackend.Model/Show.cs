using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StagePlannerBackend.Model
{
    public class Show
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public ICollection<Performance> Performances { get; set; }

        public ICollection<Image> Images { get; set; }

        public ICollection<TechnicalSheet> TechnicalSheets { get; set; }

        // Foreign key to Theater
        public int TheaterId { get; set; }

        [ForeignKey("TheaterId")]
        public Theater Theater { get; set; } // Navigation property back to Theater

        public Show()
        {
            Performances = new HashSet<Performance>();
            Images = new HashSet<Image>();
            TechnicalSheets = new HashSet<TechnicalSheet>();
        }
    }
}
