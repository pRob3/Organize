using Organize.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organize.Shared.Entites
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(10, ErrorMessage ="Username is to long.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "The Password is required!")]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public GenderTypeEnum GenderType { get; set; }

        public ObservableCollection<BaseItem> UserItems { get; set; }

        public override string ToString()
        {
            var salutation = string.Empty;
            if(GenderType == GenderTypeEnum.Male)            
                salutation = "Mr";

            if (GenderType == GenderTypeEnum.Female)
                salutation = "Mrs";

            return $"{salutation}. {FirstName} {LastName}";
        }

    }
}
