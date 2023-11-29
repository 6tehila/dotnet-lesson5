using Hotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IDatesService
    {
        List<Dates> GetDates();
        Dates GetByStart(DateTime start);
        Dates AddDates(Dates date);
        Dates UpdateDates(Dates date,DateTime start);
        void DeleteDates(Dates date);

        
    }
}
