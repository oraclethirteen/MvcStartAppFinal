using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace MvcStartAppFinal.Models.Db
{
    [Table("UserPosts")]
    public class UserPost
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
