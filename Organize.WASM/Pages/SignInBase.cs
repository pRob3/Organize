using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Organize.Business;
using Organize.Shared.Entites;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Organize.WASM.Pages
{
    public class SignInBase : SignBase
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; }

        protected string Day { get; } = DateTime.Now.DayOfWeek.ToString();


        protected async void OnSubmit()
        {
            if (!EditContext.Validate())
                return;

            var userManager = new UserManager();
            var foundUser = await userManager.TrySignInAndGetuserAsync(User);

            if (foundUser != null)
            {
                NavigationManager.NavigateTo("items");
            }


        }

    }
}
