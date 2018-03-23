using SurveyAppClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppClassLibrary.Data.Repositories
{
    public class QuestionRepository : BaseRepository<Question>
    {
        public QuestionRepository(Context context) : base(context) {}

        public override IList<Question> GetList()
        {
            return Context.Questions
                .ToList();
        }
        public override Question Get(int id)
        {
            return Context.Questions.Where(q => q.Id == id).SingleOrDefault();
        }

        // Insert, Delete, and Update derived from base class.
    }
}
