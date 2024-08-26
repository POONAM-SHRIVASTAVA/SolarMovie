using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieStoreMvc.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUserIdFromReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop the UserId column from Reviews table
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reviews");
        }

       
    
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");
        }
    }

}
   
