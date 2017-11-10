using System;
using System.Collections.Generic;
using System.Text;

namespace ForumPost
{
    class Post
    {
        //Fields
        private string title;
        private string description;
        private DateTime creationTime;
        private int voteCount = 1;

        //Properties
        public string Title
        {
            get{return title;}
            set{title = value;}
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime CreationTime
        {
            get { return creationTime; }
            set { creationTime = value; }
        }

        public int VoteCount { get { return voteCount; } }

        //constructor
        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.CreationTime = DateTime.Now;
        }

        public void UpVote()
        {
            this.voteCount++;
        }

        public void DownVote()
        {
            this.voteCount--;
        }
    }
}
