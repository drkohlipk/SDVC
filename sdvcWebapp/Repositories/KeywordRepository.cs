using System;
using System.Collections.Generic;
using sdvcWebapp.Models;
using Dapper;
using System.Linq;
using MySql.Data.MySqlClient;
using sdvcWebapp.Infrastructure;
using System.Linq.Expressions;

namespace sdvcWebapp.Repository
{
public class KeywordRepository : IKeywordRepository
{
    private SDVCContext _context;
    public KeywordRepository(SDVCContext context)
    {
        _context = context;
    }
    private System.Data.IDbConnection _db;

    public IList<Keyword> GetAll()
    {

            return _context.Keywords.ToList();

    }

    public Keyword FindById(int id)
    {
        return _context.Keywords.SingleOrDefault(k => k.id == id);
    }
//TODO: Fix This
    public void Add(Keyword keyword)
    {
       _context.Keywords.Add(keyword);
    }





        public IList<Keyword> FindAny(Expression<Func<Keyword, bool>> predicate)
        {
            return _context.Keywords.Where(predicate).ToList();
        }

        public Keyword SingleOrDefault(Expression<Func<Keyword, bool>> predicate)
        {
            return _context.Keywords.SingleOrDefault(predicate);
        }

        public void AddRange(IEnumerable<Keyword> entities)
        {
            _context.Keywords.AddRange(entities);
        }

        public void Remove(Keyword entity)
        {
            _context.Keywords.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Keyword> entities)
        {
            _context.Keywords.RemoveRange(entities);
        }

        public void PersistChanges()
        {
            _context.SaveChanges();
        }
    }
}