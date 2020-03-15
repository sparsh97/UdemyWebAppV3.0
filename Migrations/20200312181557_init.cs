using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UdemyWeb.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseName = table.Column<string>(nullable: true),
                    CourseDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    CourseOfTheWeek = table.Column<bool>(nullable: false),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    PieId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    CourseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CourseId", "Description" },
                values: new object[] { 1, "WebDevlopment", 0, null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CourseId", "Description" },
                values: new object[] { 2, "Bussiness", 0, null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CourseId", "Description" },
                values: new object[] { 3, "Game Design", 0, null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CategoryId", "CourseDescription", "CourseName", "CourseOfTheWeek", "ImageThumbnailUrl", "ImageUrl", "Price" },
                values: new object[,]
                {
                    { 1, 1, "A Complete HTML5 Programming Course for Beginners", "Learn HTML5 Programming From Scratch", false, "https://www.redbridgenet.com/wp-content/uploads/html5.png", "https://www.redbridgenet.com/wp-content/uploads/html5.png", 15.95m },
                    { 2, 1, "Learn CSS for the first time or brush up your CSS skills and dive in even deeper. EVERY web developer has to know CSS. CSS - short for Cascading Style Sheets - is a programming language you use to turn your raw HTML pages into real beautiful websites.", "CSS - The Complete Guide 2020 (incl. Flexbox, Grid & Sass)", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", 19.95m },
                    { 3, 1, "Create awesome JavaScript driven web apps with modern JavaScript from the very beginning right through to ninja-level. In this course I'll be teaching you my absolute favourite language (JavaScript!) from the very beginning, right through to creating fully-fledged, dynamic & interactive web experiences.", "Modern JavaScript (from Novice to Ninja)", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", 18.95m },
                    { 4, 2, "You'll learn how to read and write complex queries to a database using one of the most in demand skills - PostgreSQL. These skills are also applicable to any other major SQL database, such as MySQL, Microsoft SQL Server, Amazon Redshift, Oracle, and much more.", "The Complete SQL Bootcamp", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", 18.95m },
                    { 5, 2, "Learn To Trade The Stock Market by A Trading Firm CEO. Inc: Technical Analysis, Candlesticks, Stocks, Day Trading +++. This course not only includes the material that is required to be successful in Trading but also the way that we interpret the different types of information in real time to make the best Trading decisions possible.", "The Complete Foundation Stock Trading Course", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", 18.95m },
                    { 6, 2, "In this course you will learn why Power BI offers you a comprehensive set of Business Intelligence tools for your data analysis goals and how to use these tools to fulfill all of the above tasks - and more. Imagine to quickly structure your data, to easily add calculations to it and to create and publish nice-looking charts in just a few minutes.", "Microsoft Power BI - A Complete Introduction", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", 18.95m },
                    { 7, 3, "In this course I will be taking you through the process of creating AAA quality environments inside of Unity.As game graphics are becoming more impressive,it is necessary as a game designer to update your skills and techniques in order to compete with the ever growing game design industry.You don't need any previous experience in Unity as I will be explaining how to do everything in detail.", "Unity Environment Design", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", 18.95m },
                    { 8, 3, "The focus of this course is to show you how to make realistic models, to a real-world scale. Enroll in this Blender 2.8 course and experience over 20 hours of content, full of learning opportunities to take your 3D modeling, animation and simulations skills to the next level. By completing this course, you will walk away with a comprehensive view of how to model from the ground up, with a super-fast industry-standard workflow.  All this exclusively in Blender 2.8.", "Blender 2.8 Beginners Guide To 3D Modeling A Sci-fi Scene", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", 18.95m },
                    { 9, 3, "Begin your game development career with the most up-to-date game dev course on Udemy - Unreal Engine 4: The Complete Beginner's Course. Every lecture in this course is compatible with version 4.24 of the Engine.", "Unreal Engine 4: The Complete Beginner's Course", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", 18.95m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CourseId",
                table: "OrderDetails",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
