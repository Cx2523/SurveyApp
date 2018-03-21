using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppClassLibrary.Data.Repositories
{
    public abstract class BaseRepository<TEntity>
    {
        protected Context Context { get; private set; }
        //base repository context constructor
        public BaseRepository(Context context)
        {
            Context = context;
        }
        //get all in DB set
        public abstract TEntity GetList(int id);
        //Get(id) in DB set
        public abstract IList<TEntity> Get();
        //INsert(entity)

        //Delete(id)

        //Update(entity)
    }
}
