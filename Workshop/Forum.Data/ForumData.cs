using System;
using System.Collections.Generic;
using System.Text;
using Forum.Models;

namespace Forum.Data
{
    public class ForumData
    {
        public List<Category> Categories { get; set; }
        public List<User> Users { get; set; }
        public List<Post> Posts { get; set; }
        public List<Reply> Replies { get; set; }

        public ForumData()
        {
            this.Categories = DataMapper.LoadCategories();
            this.Users = DataMapper.LoadUsers();
            this.Posts = DataMapper.LoadPosts();
            this.Replies = DataMapper.LoadReplies();
        }

        public void SaveChanges()
        {
            DataMapper.SaveUsers(this.Users);
            DataMapper.SaveCategories(this.Categories);
            DataMapper.SavePosts(this.Posts);
            DataMapper.SaveReplies(this.Replies);
        }
    }
}