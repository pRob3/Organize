using Organize.Shared.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organize.WASM.Components
{
    public partial class ItemEdit
    {
        private BaseItem Item { get; set; } = new BaseItem();

        private int TotalNumber { get; set; }
    }
}
