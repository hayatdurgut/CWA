using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Models
{
    public partial class CarpetStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public string StatusClass { get; set; }
        public bool IsDelete { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUserId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
