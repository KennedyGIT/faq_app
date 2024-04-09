using Microsoft.EntityFrameworkCore;

namespace faq_app.Models
{
    public class FaqDataContext : DbContext
    {
        public FaqDataContext(DbContextOptions<FaqDataContext> options): base(options) { }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicId = "A", TopicName = "C#" },
                new Topic { TopicId = "B", TopicName = "JavaScript" },
                new Topic { TopicId = "C", TopicName = "Bootstrap" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "A", CategoryName = "General" },
                new Category { CategoryId = "B", CategoryName = "History" }
            );

            modelBuilder.Entity<Faq>().HasData(
                new Faq
                {
                    Id = 1,
                    Question = "What is C#?",
                    Answer = "C# is a programming language developed by Microsoft. It is widely used for developing desktop, web, and mobile applications.",
                    TopicId = "A",
                    CategoryId = "A"
                },
                new Faq
                {
                    Id = 2,
                    Question = "What is JavaScript?",
                    Answer = "JavaScript is a programming language commonly used for web development. It allows for interactive elements and dynamic content on websites.",
                    TopicId = "B",
                    CategoryId = "A"
                },
                new Faq
                {
                    Id = 3,
                    Question = "What is Bootstrap?",
                    Answer = "Bootstrap is a popular front-end framework for building responsive and mobile-first websites. It provides pre-designed components and styles to streamline development.",
                    TopicId = "C",
                    CategoryId = "A"
                },
                new Faq
                {
                    Id = 4,
                    Question = "When was C# first released?",
                    Answer = "C# was first released in 2000 as part of the .NET Framework.",
                    TopicId = "A",
                    CategoryId = "B"
                },
                new Faq
                {
                    Id = 5,
                    Question = "What are the basic data types in JavaScript?",
                    Answer = "The basic data types in JavaScript are number, string, boolean, null, undefined, and symbol.",
                    TopicId = "B",
                    CategoryId = "A"
                },
                new Faq
                {
                    Id = 6,
                    Question = "What is the purpose of a container in Bootstrap?",
                    Answer = "In Bootstrap, containers are used to wrap and contain page content. They provide padding and ensure proper alignment of content within the viewport.",
                    TopicId = "C",
                    CategoryId = "A"
                },
                new Faq
                {
                    Id = 7,
                    Question = "What is a lambda expression in C#?",
                    Answer = "A lambda expression is an anonymous function that can contain expressions and statements. It is commonly used to create delegates or expression tree types.",
                    TopicId = "A",
                    CategoryId = "A"
                },
                new Faq
                {
                    Id = 8,
                    Question = "What is the difference between let and var in JavaScript?",
                    Answer = "The let keyword allows you to declare variables with block scope, while var declares variables with function scope.",
                    TopicId = "B",
                    CategoryId = "A"
                },
                new Faq
                {
                    Id = 9,
                    Question = "What is the grid system in Bootstrap?",
                    Answer = "The grid system in Bootstrap is a responsive layout system that allows you to create grid-based layouts for your web pages. It is based on a 12-column grid and supports multiple device sizes.",
                    TopicId = "C",
                    CategoryId = "A"
                },
                new Faq
                {
                    Id = 10,
                    Question = "What is an interface in C#?",
                    Answer = "An interface in C# defines a contract that specifies a set of members (methods, properties, events) that implementing classes must provide. It enables polymorphism and helps achieve loose coupling.",
                    TopicId = "A",
                    CategoryId = "A"
                }
            );
        }
    }
}
