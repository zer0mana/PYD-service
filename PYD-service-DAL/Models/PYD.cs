using System;
using LinqToDB.Mapping;

namespace PYD_service_DAL.Models
{
    [Table("pyd")]
    public class PYD
    {
        [PrimaryKey]
        [Identity]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("author_id")]
        [NotNull]
        public long AuthorId { get; set; }
        
        [Column("name")]
        [NotNull]
        public string Name { get; set; } = null!;
        
        [Column("description")]
        [NotNull]
        public string Description { get; set; } = null!;
        
        [Column("goal_points")]
        [NotNull]
        public long GoalPoints { get; set; }
        
        [Column("is_public")]
        [NotNull]
        public bool IsPublic { get; set; }
        
        [Column("added_at")]
        [NotNull]
        public DateTime AddedAt { get; set; }
        
        [Column("updated_at")]
        [Nullable]
        public DateTime? UpdatedAt { get; set; }
    }
}
