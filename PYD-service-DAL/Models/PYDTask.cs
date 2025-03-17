using LinqToDB.Mapping;

namespace PYD_service_DAL.Models
{
    [Table("pyd_task")]
    public class PYDTask
    {
        [PrimaryKey]
        [Identity]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("pyd_id")]
        [NotNull]
        public long PYDId { get; set; }
        
        [Column("name")]
        [NotNull]
        public string Name { get; set; } = null!;

        [Column("description")]
        [NotNull]
        public string Description { get; set; } = null!;

        [Column("points")]
        [NotNull]
        public long Points { get; set; }
        
        [Column("added_at")]
        [NotNull]
        public DateTime AddedAt { get; set; }
        
        [Column("updated_at")]
        [Nullable]
        public DateTime? UpdatedAt { get; set; }
    }
}