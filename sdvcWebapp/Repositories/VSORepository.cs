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
            return _context.VSOs.Include(v => v.attributes)
                                    .ThenInclude(a => a.Keyword)
                                .Include(v => v.attributes)
                                    .ThenInclude(a => a.Endorsements)
                                        .ThenInclude(e => e.Vet)
                                    .ToList();
        }

        public VSO FindById(int id)
        {
            return _context.VSOs.SingleOrDefault(v => v.Vsoid == id);
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
        public IList<VSO> GetVSOsByKeyword(string keyword)
        {
            IList<VSO> results = new List<VSO>();
            IEnumerable<KWAttribute> attributes = _context.KWAttributes.Where(a => a.Keyword.kw == keyword);
            foreach(KWAttribute a in attributes)
            {
                results.Add(a.VSO);
            }
            return results;
        }
        public void PersistChanges()
        {
            _context.SaveChanges();
        }

        List<VSO> IVSORepository.GetVSOsByKeyword(string keyword)
        {
            throw new NotImplementedException();
        }

        IList<VSO> IBaseRepository<VSO>.GetAll()
        {
            throw new NotImplementedException();
        }

        VSO IBaseRepository<VSO>.FindById(int id)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<VSO>.Add(VSO entity)
        {
            throw new NotImplementedException();
        }

        VSO IBaseRepository<VSO>.Update(VSO entity)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<VSO>.RemoveById(int id)
        {
            throw new NotImplementedException();
        }

        IList<VSO> IBaseRepository<VSO>.FindAny(Expression<Func<VSO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        VSO IBaseRepository<VSO>.SingleOrDefault(Expression<Func<VSO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<VSO>.AddRange(IEnumerable<VSO> entities)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<VSO>.Remove(VSO entity)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<VSO>.RemoveRange(IEnumerable<VSO> entities)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<VSO>.PersistChanges()
        {
            throw new NotImplementedException();
        }
    }
}