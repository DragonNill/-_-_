using System;
using System.Collections.Generic;

namespace ООО__Посуда_.Model.Enity
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public string UserSurname { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserPatronymic { get; set; } = null!;
        public string UserLogin { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public int UserRoleId { get; set; }

        public virtual Role UserRole { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
