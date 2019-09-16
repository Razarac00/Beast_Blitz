namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Location
    {
        // DATA
        public int LocationID { get; set; }
        // Properties
        public string Name { get; set; }

        // Constructor
        public Location(string name)
        {
          Name = name;
        }

        public Location()
        {
          Name = "defaultLocation";
        }
    }
}