﻿using System;
using DAL;

namespace Common.Entities
{
    public class NewsItem
    {
        public int Id { get; set; }

        public int OldId { get; set; }

        public int CategoryId { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public bool Pending { get; set; }

        public bool OnTop { get; set; }

        public bool CanCommentary { get; set; }

        public long AdditionTime { get; set; }

        public int NumberCommentaries { get; set; }

        public User User { get; set; }

        public string Title { get; set; }

        public string Brief { get; set; }

        public string Message { get; set; }

        public int Reads { get; set; }

        public string Source { get; set; }

        public float Rating { get; set; }

        public int RatingNumbers { get; set; }

        public int RatingSumm { get; set; }

        public string PhotoPath { get; set; }

        public long LastModifiedUTC { get; set; }
    }
}
