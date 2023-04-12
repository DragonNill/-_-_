using System;
using System.Collections.Generic;

namespace ООО__Посуда_.Model.Enity
{
    public partial class City
    {
        public City()
        {
            Pickpoints = new HashSet<Pickpoint>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; } = null!;

        public virtual ICollection<Pickpoint> Pickpoints { get; set; }
    }
}
