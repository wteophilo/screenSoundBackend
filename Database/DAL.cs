using System;

namespace ScreenSoundBackend.Database;

internal class DAL<T> where T : class
{
    private readonly ScreenSoundContext _context;

    public DAL(ScreenSoundContext context)
    {
        _context = context;
    }

    public IEnumerable<T> List()
    {
        return _context.Set<T>().ToList();
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        _context.SaveChanges();
    }

    public T? GetBy(Func<T, bool> predicate)
    {
        return _context.Set<T>().FirstOrDefault(predicate);
    }

    public IEnumerable<T> GetListBy(Func<T, bool> condition)
    {
        return _context.Set<T>().Where(condition).ToList();
    }
}