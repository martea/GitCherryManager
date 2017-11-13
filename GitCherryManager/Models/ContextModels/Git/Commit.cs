using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GitCherryManager.Models.ContextModels.Git
{
    public class Commit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Message { get; set; }
        public string Hash { get; set; }
        public ICollection<CherryPick> CherryPicks { get; set; }

    }

}
