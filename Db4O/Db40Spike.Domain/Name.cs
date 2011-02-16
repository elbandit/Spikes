namespace Db40Spike.Domain
{
    public class Name
    {        
        public Name(string first_name, string last_name)
        {
            this.first_name = first_name;
            this.last_name = last_name;
        }

        public string first_name { get; private set; }
        public string last_name { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", first_name, last_name);
        }
    }
}