using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment6_Durham.Migrations
{
    /// <inheritdoc />
    public partial class UpdateYearValidation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Modify the 'Edited' column to allow NULL values
            migrationBuilder.AlterColumn<bool>(
                name: "Edited",
                table: "Forms",
                nullable: true,  // Allow NULL values
                oldClrType: typeof(bool),
                oldType: "INTEGER");
            
            // If you want to add any other changes, like validating the 'Year' column, 
            // you can add them here as well.
            // For example, you could modify the Year column type if needed:
            // migrationBuilder.AlterColumn<string>(
            //     name: "Year",
            //     table: "Forms",
            //     nullable: true,  // Allow NULL values for Year column
            //     oldClrType: typeof(string),
            //     oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Revert the 'Edited' column to its original non-nullable state
            migrationBuilder.AlterColumn<bool>(
                name: "Edited",
                table: "Forms",
                type: "INTEGER",  // Revert the type back to INTEGER
                nullable: false,  // Make it non-nullable again
                oldClrType: typeof(bool),
                oldNullable: true);
            
            // If you modified other columns in the Up() method, you can undo them in Down() here
            // Example:
            // migrationBuilder.AlterColumn<string>(
            //     name: "Year",
            //     table: "Forms",
            //     type: "TEXT",
            //     nullable: false,  // Make Year column non-nullable again
            //     oldClrType: typeof(string),
            //     oldNullable: true);
        }
    }
}
