using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppClassLibrary.Data
{
    public class Repository
    {
        public Context GetContext()
        {
            Context context = new Context();
            context.Database.Log = (message) => Debug.WriteLine(message);
            return context;
        }
    }
}
