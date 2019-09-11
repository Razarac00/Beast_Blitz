namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Location
    {
        // Properties
        public string Name { get; set; }

        // Constructor
        public Location(string name)
        {
          Name = name;
        }
    }
}