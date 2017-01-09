using System;
using System.Collections.Generic;
using sdvcWebapp.Models;
using System.Linq;
using sdvcWebapp.Infrastructure;
using System.Linq.Expressions;

namespace sdvcWebapp.Repository
{
public class EndorsementRepository : IEndorsementRepository
{
        private SDVCContext _context;
        public EndorsementRepository(SDVCContext context)
        {
            _context = context;
        }

        public IList<Endorsement> GetAll()
        {
                return _context.Endorsements.ToList();
        }

        public Endorsement FindById(int id)
        {
            return _context.Endorsements.SingleOrDefault(e => e.Endorsementid == id);
        }

        public void Add(Endorsement endorsement)
        {
        _context.Endorsements.Add(endorsement);
        }

        public IList<Endorsement> FindAny(Expression<Func<Endorsement, bool>> predicate)
        {
            return _context.Endorsements.Where(predicate).ToList();
        }

        public Endorsement SingleOrDefault(Expression<Func<Endorsement, bool>> predicate)
        {
            return _context.Endorsements.SingleOrDefault(predicate);
        }

        public void AddRange(IEnumerable<Endorsement> endorsements)
        {
            _context.Endorsements.AddRange(endorsements);
        }

        public void Remove(Endorsement endorsement)
        {
            _context.Endorsements.Remove(endorsement);
        }

        public void RemoveRange(IEnumerable<Endorsement> endorsements)
        {
            _context.Endorsements.RemoveRange(endorsements);
        }

        public void PersistChanges()
        {
            _context.SaveChanges();
        }
    }
}