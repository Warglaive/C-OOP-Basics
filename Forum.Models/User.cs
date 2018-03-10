using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<int> PostIds { get; set; }

        public User(int id, string userName, string password, IEnumerable<int> postids)
        {
            this.Id = id;
            this.UserName = userName;
            this.Password = password;
            this.PostIds = new List<int>(postids);
        }
    }
}
