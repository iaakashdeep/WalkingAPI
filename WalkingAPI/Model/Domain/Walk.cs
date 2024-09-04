using System.ComponentModel.DataAnnotations.Schema;

namespace WalkingAPI.Model.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthinKM {  get; set; }
        public string? WalkImageUrl {  get; set; }

        public Guid DifficultyId { get; set; }
        [ForeignKey(nameof(DifficultyId))]
        public Difficulty Difficulty { get; set; }

        public Guid RegionId { get; set; }
        [ForeignKey(nameof (RegionId))]
        public Region Region { get; set; }
    }
}
