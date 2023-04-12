using System;
using System.Collections.Generic;

namespace ООО__Посуда_.Model.Enity
{
    public partial class Street
    {
        public Street()
        {
            Pickpoints = new HashSet<Pickpoint>();
        }

        public int StreetId { get; set; }
        public string StreetName { get; set; } = null!;

        public virtual ICollection<Pickpoint> Pickpoints { get; set; }
    }
}
