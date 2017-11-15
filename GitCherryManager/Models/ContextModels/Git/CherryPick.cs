using GitCherryManager.Models.Enumerables;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GitCherryManager.Models.ContextModels.Git
{
    public class CherryPick
    {
        [Key]
        public int CherryPickId { get; set; }
        public virtual CodeShare CodeShare { get; set; }
        public virtual Repository Repository{ get; set; }
        public ProccessStatusType ProccessStatus { get; set; }
        public MergeStatusType MergeStatus { get; set; }

    }

}
