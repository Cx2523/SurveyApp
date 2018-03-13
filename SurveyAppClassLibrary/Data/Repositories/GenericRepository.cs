using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppClassLibrary.Data.Repositories
{
    class GenericRepository<TEntity> where TEntity : class
    {
        internal Context _context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(Context context)
        {
            this._context = context;
            this.dbSet = context.Set<TEntity>();
        }
    }
}
