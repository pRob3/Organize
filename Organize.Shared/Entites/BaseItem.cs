using Organize.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organize.Shared.Entites
{
    public class BaseItem : BaseEntity
    {
        public int ParentId { get; set; }

        public ItemTypeEnum ItemTypeEnum { get; set; }

        public int Position { get; set; }

        public bool IsDone { get; set; }

        public string Title { get; set; }
    }
}
