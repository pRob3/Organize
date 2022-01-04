using Microsoft.AspNetCore.Components;
using Organize.Shared.Entites;

namespace Organize.WASM.Components
{
    public class ItemCheckBoxBase : ComponentBase
    {
        [Parameter]
        public BaseItem Item { get; set; }

    }
}
