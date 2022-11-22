using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace MvcStartAppFinal.Models.Db
{
    [Table("Users")]
    public class User
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime JoinDate { get; set; }
    }
}
