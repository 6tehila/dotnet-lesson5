using Hotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IDatesRepository
    {
        List<Dates>GetDates();
        
        Dates GetByStart(DateTime start);


        Dates AddDate(Dates date);

        Dates UpdateDate(DateTime start, Dates date);

        void DeleteDate(Dates date);
    }
}
