using Microsoft.EntityFrameworkCore.Migrations;

namespace faq_app.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<string>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    TopicId = table.Column<string>(nullable: false),
                    TopicName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.TopicId);
                });

            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    TopicId = table.Column<string>(nullable: true),
                    CategoryId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faqs_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Faqs_Topic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topic",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "A", "General" },
                    { "B", "History" }
                });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "TopicId", "TopicName" },
                values: new object[,]
                {
                    { "A", "C#" },
                    { "B", "JavaScript" },
                    { "C", "Bootstrap" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CategoryId", "Question", "TopicId" },
                values: new object[,]
                {
                    { 1L, "C# is a programming language developed by Microsoft. It is widely used for developing desktop, web, and mobile applications.", "A", "What is C#?", "A" },
                    { 4L, "C# was first released in 2000 as part of the .NET Framework.", "B", "When was C# first released?", "A" },
                    { 7L, "A lambda expression is an anonymous function that can contain expressions and statements. It is commonly used to create delegates or expression tree types.", "A", "What is a lambda expression in C#?", "A" },
                    { 10L, "An interface in C# defines a contract that specifies a set of members (methods, properties, events) that implementing classes must provide. It enables polymorphism and helps achieve loose coupling.", "A", "What is an interface in C#?", "A" },
                    { 2L, "JavaScript is a programming language commonly used for web development. It allows for interactive elements and dynamic content on websites.", "A", "What is JavaScript?", "B" },
                    { 5L, "The basic data types in JavaScript are number, string, boolean, null, undefined, and symbol.", "A", "What are the basic data types in JavaScript?", "B" },
                    { 8L, "The let keyword allows you to declare variables with block scope, while var declares variables with function scope.", "A", "What is the difference between let and var in JavaScript?", "B" },
                    { 3L, "Bootstrap is a popular front-end framework for building responsive and mobile-first websites. It provides pre-designed components and styles to streamline development.", "A", "What is Bootstrap?", "C" },
                    { 6L, "In Bootstrap, containers are used to wrap and contain page content. They provide padding and ensure proper alignment of content within the viewport.", "A", "What is the purpose of a container in Bootstrap?", "C" },
                    { 9L, "The grid system in Bootstrap is a responsive layout system that allows you to create grid-based layouts for your web pages. It is based on a 12-column grid and supports multiple device sizes.", "A", "What is the grid system in Bootstrap?", "C" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faqs_CategoryId",
                table: "Faqs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Faqs_TopicId",
                table: "Faqs",
                column: "TopicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Topic");
        }
    }
}
