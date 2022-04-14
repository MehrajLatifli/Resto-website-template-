using Resto.Entities;
using System.Collections.Generic;

namespace Resto.Data
{
    public class GeneralModel
    {
        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<Menu> Menues { get; set; }
    }
}
