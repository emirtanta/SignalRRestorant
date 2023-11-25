using System.ComponentModel.DataAnnotations;

namespace SignalR.Api.DAL.Entities
{
    public class Feature
    {
        [Key]
        public int FeatureId { get; set; }

        [StringLength(50)]
        public string Title1 { get; set; }

        [StringLength(1000)]
        public string? Description1 { get; set; }

        [StringLength(50)]
        public string? Title2 { get; set; }

        [StringLength(1000)]
        public string? Description2 { get; set; }

        [StringLength(50)]
        public string? Title3 { get; set; }

        [StringLength(1000)]
        public string? Description3 { get; set; }
    }
}
