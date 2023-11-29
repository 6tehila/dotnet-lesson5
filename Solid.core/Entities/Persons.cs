namespace Hotel.Entities
{
    public class Persons
    {
        public int idPerson { get; set; }
        public string name { get; set; }
        public string fName { get; set; }
        public int numPhone { get; set; }
        public Rooms idroom { get; set; }
        //List<Persons> allPersons = new List<Persons>();
        public Dates time { get; set; }



        public Persons(int id, string name, string fName, int numPhone, Rooms idroom,Dates time)
        {
            this.idPerson = id;
            this.name = name;
            this.fName = fName;
            this.numPhone = numPhone;
            
            this.idroom = idroom;
            this.time = time;
        }
    }
}

