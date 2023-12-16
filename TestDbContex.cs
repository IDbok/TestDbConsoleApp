﻿using Microsoft.EntityFrameworkCore;
using TeleBot.Models;

namespace TeleBot.DbCommunication
{
    public class MyBotDbContext : DbContext
    {
        public static void SetDbPasswod(string password)
        {
            DbPass = password;
        }
        private static string DbPass;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<TextMessage> Messages { get; set; } = null!;

        //public DbSet<Expense> Expenses { get; set; } = null!;
        public DbSet<PersonalExpense> PersonalExpenses { get; set; } = null!;
        public DbSet<BusinessExpense> BusinessExpenses { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Currency> Currencies { get; set; } = null!;

        public MyBotDbContext()
        {
            Database.EnsureCreated();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql($"server=localhost;user=root;password={DbPass};database=telebot_db_v3;",
                new MySqlServerVersion(new Version(8, 0, 35)),//8,0,35//5,7,24
                mySqlOptions =>
                {
                    mySqlOptions.EnableRetryOnFailure();
                });
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>().UseTpcMappingStrategy();
        }

    }

}


