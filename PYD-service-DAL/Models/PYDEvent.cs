using LinqToDB.Mapping;

namespace PYD_service_DAL.Models;

[Table("pyd")]
public class PYDEvent
{
    [PrimaryKey]
    [Identity]
    [Column("id")]
    public long Id { get; set; }

    [Column("task_id")]
    [NotNull]
    public long TaskId { get; set; }

    [Column("day_number")]
    [NotNull]
    public long DayNumber { get; set; }
}