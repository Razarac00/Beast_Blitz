namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Location
    {
        // Properties
        string Name { get; set; }

        // Constructor
        public Location(string n)
        {
          Name = n;
        }
    }
}