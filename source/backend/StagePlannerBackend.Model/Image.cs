using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StagePlannerBackend.Model
{
    public class Image
    {
        public int Id { get; set; }

        public string FilePath { get; set; } // Path of the image file

        [StringLength(500)]
        public string Description { get; set; } // Optional description of the image

        public int ShowId { get; set; } // Foreign key for Show

        [ForeignKey("ShowId")]
        public Show Show { get; set; } // Navigation property
    }
}
