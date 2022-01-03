using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Organize.Business;
using Organize.Shared.Contracts;
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

        [Inject]
        private IUserManager UserManager { get; set; }

        protected string Day { get; } = DateTime.Now.DayOfWeek.ToString();

        protected override void OnInitialized()
        {
            base.OnInitialized();
            User = new User
            {
                FirstName = "X",
                LastName = "X",
                PhoneNumber = "1234"
            };

            EditContext = new EditContext(User);
        }


        protected async void OnSubmit()
        {
            if (!EditContext.Validate())
                return;

            var foundUser = await UserManager.TrySignInAndGetUserAsync(User);

            if (foundUser != null)
            {
                NavigationManager.NavigateTo("items");
            }


        }

    }
}
