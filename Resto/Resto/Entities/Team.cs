using System.ComponentModel.DataAnnotations;

namespace Resto.Entities
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Team_image { get; set; }

        public Team()
        {

        }

    }
}
