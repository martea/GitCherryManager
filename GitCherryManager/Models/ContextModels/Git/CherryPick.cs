using GitCherryManager.Models.Enumerables;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GitCherryManager.Models.ContextModels.Git
{
    public class CherryPick
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Repository LocalRepository { get; set; }
        public Repository RemoteRepository { get; set; }
        public ProccessStatusType ProccessStatus { get; set; }
        public MergeStatusType MergeStatus {get;set;}
    }

}
