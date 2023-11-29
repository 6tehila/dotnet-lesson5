using Hotel;
using Hotel.Entities;

namespace Solid.Data
{
    public class DataContext
    {
        public List<Persons> allPersons { get; set; }
        public List<Rooms> roomList { get; set; }
        public List<Dates> DateList { get; set; }

        public DataContext()
        {
            List<Persons> allPersons = new List<Persons>
            {
                new Persons(332225678, "yudit", "ashlag", 583261142, new Rooms(1, 6, false), new Dates(new DateTime(2023, 10, 2), new DateTime(2023, 12, 2))),
                new Persons(325746840, "tehila", "avishay", 556737926, new Rooms(2, 10, true), new Dates(new DateTime(2023, 10, 2), new DateTime(2023, 11, 2))),
                new Persons(223345675, "miri", "ashlag", 556781923, new Rooms(3, 4, true), new Dates(new DateTime(2023, 09, 2), new DateTime(2023, 12, 23))),
                new Persons(123412343, "ruthi", "winner", 527161569, new Rooms(4, 2, false), new Dates(new DateTime(2023, 10, 12), new DateTime(2023, 12,10)))
            };

            List<Rooms> roomList = new List<Rooms>
            {
                new Rooms(1, 15, true),
                new Rooms(2, 8, true),
                new Rooms(3, 12, false),
                new Rooms(4, 2, false),
                new Rooms(5, 7, true),
                new Rooms(6, 6, true),
                new Rooms(7, 2, false)
            };

            List<Dates> DateList = new List<Dates>
            {
                new Dates(new DateTime(2023, 8, 5), new DateTime(2023, 8, 9)),
                new Dates(new DateTime(2023, 9, 9), new DateTime(2023, 9, 13)),
                new Dates(new DateTime(2023, 10, 9), new DateTime(2023, 10, 13)),
                new Dates(new DateTime(2023, 11, 9), new DateTime(2023, 11, 13))
            };

        }
    }
}
