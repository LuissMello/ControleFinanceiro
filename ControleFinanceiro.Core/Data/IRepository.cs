using ControleFinanciero.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Core.Data
{
    public interface IRepository<TEntity> where TEntity : Subcategoria
    {
        ValueTask<bool> DeleteAsync(TEntity model);
        ValueTask<bool> UpdateAsync(TEntity model);
        ValueTask<TEntity> FindByIdAsync(Guid id);
        IQueryable<TEntity> QueryAsync();
        ValueTask<TEntity> InsertAsync(TEntity model);
    }
}
