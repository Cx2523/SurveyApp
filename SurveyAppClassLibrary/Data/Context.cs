using SurveyAppClassLibrary.Models;
using System.Data.Entity;

namespace SurveyAppClassLibrary.Data
{
    public class Context : DbContext
    {

        public Context()
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Survey> Surveys { get; set; }
    }
}
