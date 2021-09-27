namespace RefitProject.Models
{
    public class University
    {
        public string Country { get; set; }

        public string Name { get; set; }

        public string AlphaTwoCode { get; set; }

        public object StateProvince { get; set; }

        public string[] Domains { get; set; }

        public string[] WebPages { get; set; }
    }
}
