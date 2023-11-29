using Hotel.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class DatesService : IDatesService
    {
        private readonly IDatesRepository _datesService;
        public DatesService (IDatesRepository datesService)
        {
            _datesService = datesService;
        }

        public Dates AddDates(Dates date)
        {
           return _datesService.AddDate(date); 
        }

        public void DeleteDates(Dates date)
        {
            _datesService.DeleteDate(date);
        }

        public Dates GetByStart(DateTime start)
        {
            return _datesService.GetByStart(start); 
        }

        public List<Dates> GetDates()
        {
            return _datesService.GetDates();
        }

        public Dates UpdateDates(Dates date, DateTime start)
        {
            return _datesService.UpdateDate(start, date);
        }
    }
}
