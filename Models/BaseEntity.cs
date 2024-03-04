﻿namespace Lesson8Task_.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime ModifiedTime { get; set; } = DateTime.Now;
    }
}
