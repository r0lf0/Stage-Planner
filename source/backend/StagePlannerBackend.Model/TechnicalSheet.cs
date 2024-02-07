using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StagePlannerBackend.Model
{
    public class TechnicalSheet
    {
        public int Id { get; set; }

        [Required]
        public string FilePath { get; set; } // Path to the technical sheet file

        public string Description { get; set; } // Optional description of the technical sheet

        public int ShowId { get; set; } // Foreign key to Show

        [ForeignKey("ShowId")]
        public Show Show { get; set; } // Navigation property back to Show
    }
}
