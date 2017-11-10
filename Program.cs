using System;

namespace ForumPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("This is a post", "Test post");
            post1.UpVote();
            post1.DownVote();
            post1.DownVote();
            post1.DownVote();
            Console.WriteLine("Post Title: " + post1.Title);
            Console.WriteLine("Post Desc: " + post1.Description);
            Console.WriteLine("Post Creation TimeStamp: " + post1.CreationTime.ToString());
            Console.WriteLine("Post Vote Count: " + post1.VoteCount);
        }
    }
}
