using Microsoft.EntityFrameworkCore;
using Rutro.Application.Interfaces;
using System.Linq.Expressions;

namespace Rutro.Infrastructure.Implementation;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;
    public Repository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    // NON-Asynchronous Add method
    public void Add(T entity)
    {
        _dbSet.Add(entity);
    }

    public void DeleteNormal(T entity)
    {
        _dbSet.Remove(entity);

    }

    public void DeleteRange(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange(entities);
    }


    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public T Get(int id)
    {
        return _dbSet.Find(id);
    }

    public T Get(Expression<Func<T, bool>> filter, string? includeProps = null)
    {
        IQueryable<T> query = _dbSet;
        if (string.IsNullOrEmpty(includeProps))
        {
            foreach (var includeProp in includeProps.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp);
            }
        }

        return query.SingleOrDefault(filter);
    }


    public IEnumerable<T> GetAll(string? includeProps = null)
    {
        IQueryable<T> query = _dbSet;


        if (!string.IsNullOrEmpty(includeProps))
        {
            foreach (var includeProp in includeProps.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProps);
            }
        }

        return query.ToList();
    }


   

}
