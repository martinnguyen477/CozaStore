// <copyright file="Tag.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.EntitiesModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;
    using CozaStore.Model.BaseModel;

    [Table("Tag")]
    public class TagEntities : BaseTableWithId
    {
        [Column("Tag")]
        public string Tag { get; set; }
    }
}
