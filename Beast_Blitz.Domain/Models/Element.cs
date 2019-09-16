namespace Beast_Blitz.Domain.Models
{
    public class Element
    {
        // DATA
        public int ElementID { get; set; }
        // Properties
        public string Name { get; set; }

        // Constructors
        public Element(string name)
        {
          Name = name;
        }

        public Element()
        {
          Name = "defaultElement";
        }
    }
}