using Microsoft.AspNetCore.Components;
using Organize.Shared.Contracts;
using Organize.Shared.Entites;
using Organize.WASM.ItemEdit;
using System;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace Organize.WASM.Components
{
    public partial class ItemsList : ComponentBase
    {
        [Inject]
        private ICurrentUserService CurrentUserService { get; set; }

        [Inject]
        private ItemEditService ItemEditService { get; set; }

        protected ObservableCollection<BaseItem> UserItems { get; set; } = new ObservableCollection<BaseItem>();

        protected override void OnInitialized()
        {
            base.OnInitialized();

            UserItems = CurrentUserService.CurrentUser.UserItems;

            Console.WriteLine(UserItems.Count);
            Console.WriteLine(JsonSerializer.Serialize(UserItems));
        }

        private void OnBackgroundClicked()
        {
            ItemEditService.EditItem = null;
        }
    }
}
