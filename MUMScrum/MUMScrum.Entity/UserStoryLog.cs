﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MUMScrum.Entity
{
    public class UserStoryLog
    {
        [Key]
        public int Id { get; set; }

        public int UserStoryId { get; set; }
        [ForeignKey("UserStoryId")]
        public virtual UserStory UserStory { get;  set; }

        public LogType LogType { get;  set; }

        public int OldValue { get;  set; }

        [Required]
        public int NewValue { get; set; }

        public DateTime Date { get;  set; }
        public int ChangedByUserId { get;  set; }
        [ForeignKey("ChangedByUserId")]
        public virtual Employee User { get;  set; }


    }
}
