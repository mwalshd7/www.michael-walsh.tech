namespace myApp2.Models
{
    public class EmailAddress
    {
        //private fields
        private string _name;
        private string _address;

        //public properties
        public string Name { get => _name; set => _name = value; }
        public string Address { get => _address; set => _address = value; }

    }
}