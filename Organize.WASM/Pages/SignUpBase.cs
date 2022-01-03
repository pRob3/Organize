using GeneralUi.DropdownControl;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Primitives;
using Organize.Shared.Enums;
using System.Collections.Generic;
using Microsoft.AspNetCore.WebUtilities;

namespace Organize.WASM.Pages
{
    public class SignUpBase : SignBase
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; }

        protected IList<DropdownItem<GenderTypeEnum>> GenderTypeDropDownItems { get; } = new List<DropdownItem<GenderTypeEnum>>();

        protected DropdownItem<GenderTypeEnum> SelectedGenderTypeDropDownItem { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            var male = new DropdownItem<GenderTypeEnum>
            {
                ItemObject = GenderTypeEnum.Male,
                DisplayText = "Male"
            };

            var female = new DropdownItem<GenderTypeEnum>
            {
                ItemObject = GenderTypeEnum.Female,
                DisplayText = "Female"
            };

            var neutral = new DropdownItem<GenderTypeEnum>
            {
                ItemObject = GenderTypeEnum.Neutral,
                DisplayText = "Other"
            };

            GenderTypeDropDownItems.Add(male);
            GenderTypeDropDownItems.Add(female);
            GenderTypeDropDownItems.Add(neutral);

            SelectedGenderTypeDropDownItem = female;

            TryGetUsernameFromUri();
            
        }

        private void TryGetUsernameFromUri()
        {
            var uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
            StringValues sv;

            if(QueryHelpers.ParseQuery(uri.Query).TryGetValue("username", out sv))
            {
                User.UserName = sv;
            }

        }

        protected void OnValidSubmit()
        {
            // TODO
            NavigationManager.NavigateTo("signin");
        }

    }
}
