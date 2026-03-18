using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SYSTEMSALE.DAL.Repositorios.Contrato;
using SYSTEMSALE.DAL.DBContext;
using Microsoft.EntityFrameworkCore;

namespace SYSTEMSALE.DAL.Repositorios
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
    {
        private readonly DatabaseventaContext _dbContext;

        public GenericRepository(DatabaseventaContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
