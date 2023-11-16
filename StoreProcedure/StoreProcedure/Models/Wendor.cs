using System.ComponentModel.DataAnnotations;

namespace StoreProcedure.Models
{
    public class Wendor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
        public int pincode { get; set; }

    }
}
