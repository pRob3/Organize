using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Organize.Shared.Entites;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Organize.WASM.Pages
{
    public class SignBase : ComponentBase
    {

        protected User User { get; set; } = new User();

        protected EditContext EditContext { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            EditContext = new EditContext(User);
        }

        public string GetError(Expression<Func<object>> fu)
        {
            if (EditContext == null)
            {
                return null;
            }

            return EditContext.GetValidationMessages(fu).FirstOrDefault();
        }
    }
}
