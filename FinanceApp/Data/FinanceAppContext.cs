using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace FinanceApp.Data
{
    public class FinanceAppContext: DbContext
    {
        //Промежуточный класс между БД и данными в приложении
        // Добавлены Nuget MicrosoftEntityFrameworkCore, MicrosoftEntityFrameworkCoreSqlServer, MicrosoftEntityFrameworkCoreTools
        // Нужно для миграции бд
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options):base(options){ }
        public DbSet<Expense> Expenses { get; set; }



    }
}
