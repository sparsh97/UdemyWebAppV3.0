using Microsoft.EntityFrameworkCore.Migrations;

namespace UdemyWeb.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CategoryId", "CourseDescription", "CourseName", "CourseOfTheWeek", "ImageThumbnailUrl", "ImageUrl", "Price" },
                values: new object[,]
                {
                    { 4, 2, "You'll learn how to read and write complex queries to a database using one of the most in demand skills - PostgreSQL. These skills are also applicable to any other major SQL database, such as MySQL, Microsoft SQL Server, Amazon Redshift, Oracle, and much more.", "The Complete SQL Bootcamp", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", 18.95m },
                    { 5, 2, "Learn To Trade The Stock Market by A Trading Firm CEO. Inc: Technical Analysis, Candlesticks, Stocks, Day Trading +++. This course not only includes the material that is required to be successful in Trading but also the way that we interpret the different types of information in real time to make the best Trading decisions possible.", "The Complete Foundation Stock Trading Course", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", 18.95m },
                    { 6, 2, "In this course you will learn why Power BI offers you a comprehensive set of Business Intelligence tools for your data analysis goals and how to use these tools to fulfill all of the above tasks - and more. Imagine to quickly structure your data, to easily add calculations to it and to create and publish nice-looking charts in just a few minutes.", "Microsoft Power BI - A Complete Introduction", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", 18.95m },
                    { 7, 3, "In this course I will be taking you through the process of creating AAA quality environments inside of Unity.As game graphics are becoming more impressive,it is necessary as a game designer to update your skills and techniques in order to compete with the ever growing game design industry.You don't need any previous experience in Unity as I will be explaining how to do everything in detail.", "Unity Environment Design", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", 18.95m },
                    { 8, 3, "The focus of this course is to show you how to make realistic models, to a real-world scale. Enroll in this Blender 2.8 course and experience over 20 hours of content, full of learning opportunities to take your 3D modeling, animation and simulations skills to the next level. By completing this course, you will walk away with a comprehensive view of how to model from the ground up, with a super-fast industry-standard workflow.  All this exclusively in Blender 2.8.", "Blender 2.8 Beginners Guide To 3D Modeling A Sci-fi Scene", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", 18.95m },
                    { 9, 3, "Begin your game development career with the most up-to-date game dev course on Udemy - Unreal Engine 4: The Complete Beginner's Course. Every lecture in this course is compatible with version 4.24 of the Engine.", "Unreal Engine 4: The Complete Beginner's Course", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", 18.95m }
                });
        }
    }
}
