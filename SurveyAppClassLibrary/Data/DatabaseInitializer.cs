using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SurveyAppClassLibrary.Models;

namespace SurveyAppClassLibrary.Data
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        public DatabaseInitializer()
        {
            SeedData.Seed1(new Context());
        }
    }
}
