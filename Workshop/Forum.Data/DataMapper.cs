using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Forum.Models;

namespace Forum.Data
{
    public class DataMapper
    {
        private const string DATA_PATH = "../data/";
        private const string CONFIG_PATH = "config.ini";
        private const string DEFAULT_CONFIG = "replies=replies.csv\r\ncategories=replies.csv\r\nposts=replies.csv\r\nreplies=replies.csv";
        private static readonly Dictionary<string, string> config;

        private static void EnsureConfigFile(string configFilePath)
        {
            if (!File.Exists(configFilePath))
            {
                File.WriteAllText(configFilePath, DEFAULT_CONFIG);
            }
        }

        private static void EnsureFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

        private static Dictionary<string, string> LoadConfig(string configPath)
        {
            EnsureConfigFile(configPath);
            var contents = ReadLines(configPath);
            var config = contents.Select(l => l.Split('='))
                .ToDictionary(t => t[0], t => DATA_PATH + t[1]);
            return config;
        }

        private static string[] ReadLines(string path)
        {
            EnsureFile(path);
            var lines = File.ReadAllLines(path);
            return lines;
        }

        private static void WriteLines(string path, string[] lines)
        {
            File.WriteAllLines(path, lines);
        }

        static DataMapper()
        {
            Directory.CreateDirectory(DATA_PATH);
            config = LoadConfig(DATA_PATH + CONFIG_PATH);
        }
        //Parsers
        public static List<Category> LoadCategories()
        {
            var categories = new List<Category>();
            var dataLines = ReadLines(config["categories"]);

            foreach (var line in dataLines)
            {
                var args = line.Split(";", StringSplitOptions.RemoveEmptyEntries);
                var id = int.Parse(args[0]);
                var name = args[1];
                var postIds = args[2].Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                var category = new Category(id, name, postIds);
                categories.Add(category);
            }
            return categories;
        }

        public static void SaveCategories(List<Category> categories)
        {
            var lines = new List<string>();

            foreach (var category in categories)
            {
                const string userFormat = "{0};{1};{2}";
                string line = string.Format(userFormat, category.Id, category.Name
                    , string.Join(",", category.Posts));

                lines.Add(line);
            }
            WriteLines(config["categories"], lines.ToArray());
        }
        //LoadUsers and SaveUsers
        public static List<User> LoadUsers()
        {
            var users = new List<User>();
            var dataLines = ReadLines(config["users"]);

            foreach (var line in dataLines)
            {
                var args = line.Split(";", StringSplitOptions.RemoveEmptyEntries);
                var id = int.Parse(args[0]);
                var userName = args[1];
                var password = args[2];
                var postids = args[3].Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                var user = new User(id, userName, password, postids);
                users.Add(user);
            }
            return users;
        }

        public static void SaveUsers(List<User> users)
        {
            var lines = new List<string>();

            foreach (var user in users)
            {
                const string userFormat = "{0};{1};{2}";
                string line = string.Format(userFormat, user.Id, user.UserName
                    , string.Join(",", user.PostIds));

                lines.Add(line);
            }
            WriteLines(config["users"], lines.ToArray());
        }
        // LoadPosts, SavePosts
        public static List<Post> LoadPosts()
        {
            var posts = new List<Post>();
            var dataLines = ReadLines(config["posts"]);

            foreach (var line in dataLines)
            {
                var args = line.Split(";", StringSplitOptions.RemoveEmptyEntries);
                var id = int.Parse(args[0]);
                var title = args[1];
                var content = args[2];
                var categoryId = int.Parse(args[3]);
                var authorId = int.Parse(args[4]);
                var postIds = args[5].Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                var post = new Post(id, title, content, categoryId, authorId, postIds);
                posts.Add(post);
            }
            return posts;
        }

        public static void SavePosts(List<Post> posts)
        {
            var lines = new List<string>();

            foreach (var post in posts)
            {
                const string postFormat = "{0};{1};{2}";
                string line = string.Format(postFormat, post.Id, post.Title
                    , string.Join(",", post.PostIds));

                lines.Add(line);
            }
            WriteLines(config["posts"], lines.ToArray());
        }
        //LoadReplies, SaveReplies
        public static List<Reply> LoadReplies()
        {
            var replies = new List<Reply>();
            var dataLines = ReadLines(config["replies"]);

            foreach (var line in dataLines)
            {
                var args = line.Split(";", StringSplitOptions.RemoveEmptyEntries);
                var id = int.Parse(args[0]);
                var content = args[1];
                var authorId = int.Parse(args[2]);
                var replyIds = int.Parse(args[3]);
                var reply = new Reply(id, content, authorId, replyIds);
                replies.Add(reply);
            }
            return replies;
        }

        public static void SaveReplies(List<Reply> replies)
        {
            var lines = new List<string>();

            foreach (var reply in replies)
            {
                const string replyFormat = "{0};{1};{2}";
                string line = string.Format(replyFormat, reply.Id, reply.AuthorId
                    , string.Join(",", reply.PostId));

                lines.Add(line);
            }
            WriteLines(config["replies"], lines.ToArray());
        }
    }
}
