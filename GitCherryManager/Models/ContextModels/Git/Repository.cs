﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GitCherryManager.Models.ContextModels.Git
{
    public class Repository
    {
        [Key]
        public int RepositoryId { get; set; }
        public string Url { get; set; }
        public virtual ICollection<CodeShare> CodeShares { get; set; }
    }

}
