using Hotel.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class DatesRepository : IDatesRepository
    {
        private readonly DataContext _context;

        public DatesRepository(DataContext context)
        {
            _context = context;
        }
        public Dates AddDate(Dates date)
        {
            _context.DateList.Add(date);
            return date;
        }

        public void DeleteDate(Dates date)
        {
            _context.DateList.Remove(_context.DateList.Find(d => d.start ==date.start));               
        }

        public Dates GetByStart(DateTime start)
        {
            return _context.DateList.Find(d => d.start== start);
        }

        public List<Dates> GetDates()
        {
            return _context.DateList;
        }

        public Dates UpdateDate(DateTime start, Dates date)
        {
            var updateDate = _context.DateList.Find(d => d.start == start);
            if (updateDate != null/*&&updateDate.IsCatch==false*/)
            {
                updateDate.start = date.start;
                updateDate.end = date.end;
                updateDate.count=date.count;
                updateDate.IsCatch=date.IsCatch;
                return updateDate;
            }
            return null;
        }
    }
}
