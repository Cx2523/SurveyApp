using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SurveyAppClassLibrary.Models;
using System.Diagnostics;

namespace SurveyAppClassLibrary.Data
{
    public class DevDatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        public void SeedDatabase(Context context)
        {
            SeedData.Seed1(context);
        }
    }
}
