using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GitCherryManager.Models.ContextModels.Git
{
    public class Repository
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Url { get; set; }
        public ICollection<Commit> Commits { get; set; } 
    }

}
