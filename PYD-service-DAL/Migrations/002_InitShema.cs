using FluentMigrator;

namespace PYD_service_DAL.Migrations;

[Migration(002, TransactionBehavior.None)]
public class InitShema : Migration {
    public override void Up()
    {
        Create.Table("pyd")
            .WithColumn("id").AsInt32().PrimaryKey("pyd_pk").Identity()
            .WithColumn("name").AsString().NotNullable()
            .WithColumn("description").AsString().NotNullable()
            .WithColumn("user_id").AsInt64().NotNullable()
            .WithColumn("goal_points").AsInt64().NotNullable()
            .WithColumn("added_at").AsDateTimeOffset().NotNullable();

        Create.Table("pyd_task");

        Create.Table("pyd_event");
    }

    public override void Down()
    {
        Delete.Table("pyd");
        Delete.Table("pyd_task");
        Delete.Table("pyd_event");
    }
}