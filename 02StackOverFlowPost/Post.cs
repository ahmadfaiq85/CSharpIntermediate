﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDateTime { get; set; }

        private int _vote { get; set; }

        public Post()
        {
            CreatedDateTime = DateTime.Now;
        }
        public Post(string title) : this()
        {
            Title = title;
        }

        public Post(string title, string description)
            : this(title)
        {
            Description = description;
        }

        public void VoteUp()
        {
            _vote++;
        }

        public void VoteDown()
        {
            _vote--;
        }
        public int Vote
        {
            get
            {
                return _vote;
            }
        }

    }
}
