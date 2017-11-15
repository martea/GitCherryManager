using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GitCherryManager.Models.ContextModels.Git
{

    public class Commit
    {
        [Key]
        public int CommitId { get; set; }
        public string Url { get; set; }
        public virtual CodeShare CodeShare { get; set; }

    }

}
