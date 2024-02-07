using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StagePlannerBackend.Model
{
    public class Performance
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public int DurationMinutes { get; set; }

        // External Key
        public int ShowId { get; set; }

        // Navigation Property
        [ForeignKey("ShowId")]
        public Show Show { get; set; }
    }
}
