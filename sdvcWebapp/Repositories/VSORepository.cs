using System;
using System.Collections.Generic;
using sdvcWebapp.Models;
using System.Linq;
using sdvcWebapp.Infrastructure;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace sdvcWebapp.Repository
{
public class VSORepository : IVSORepository
{
        private SDVCContext _context;
        public VSORepository(SDVCContext context)
        {
            _context = context;
        }

        public IList<VSO> GetAll()
        {

                return _context.VSOs.ToList();

        }

        public VSO FindById(int id)
        {
            return _context.VSOs.SingleOrDefault(v => v.id == id);
        }

        public void Add(VSO vso)
        {
        _context.VSOs.Add(vso);
        }

        public IList<VSO> FindAny(Expression<Func<VSO, bool>> predicate)
        {
            return _context.VSOs.Where(predicate).ToList(); //TODO: Include endorsements??
        }

        public VSO SingleOrDefault(Expression<Func<VSO, bool>> predicate)
        {
            return _context.VSOs.SingleOrDefault(predicate);
        }

        public void AddRange(IEnumerable<VSO> vsos)
        {
            _context.VSOs.AddRange(vsos);
        }

        public void Remove(VSO vso)
        {
            _context.VSOs.Remove(vso);
        }

        public void RemoveRange(IEnumerable<VSO> vsos)
        {
            _context.VSOs.RemoveRange(vsos);
        }
        public IEnumerable<VSO> GetVSOsByKeyword(string keyword)
        {
            _context.VSOs.Include(e => e.)
        }
        public void PersistChanges()
        {
            _context.SaveChanges();
        }
    }
}