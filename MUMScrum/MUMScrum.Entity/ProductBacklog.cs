﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MUMScrum.Entity
{
    public class ProductBacklog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int? OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public virtual Employee Owner { get; set; }
        public virtual ICollection<ReleaseBacklog> ReleaseBacklogs { get; set; }

        public virtual ICollection<UserStory> UserStories { get; set; }
    }
}
