using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GitCherryManager.Models.ContextModels.Git
{
    public class CodeShare
    {
        [Key]
        public int CodeShareId { get; set; }
        public virtual Repository Repository { get; set; }
        public virtual ICollection<Commit> Commits{ get; set; }
    }
}
