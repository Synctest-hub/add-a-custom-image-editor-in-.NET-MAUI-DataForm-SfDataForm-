using Syncfusion.Maui.DataForm;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomImageEditor
{
    public class DataFormModel
    {
        public DataFormModel()
        {
            this.ProfileImage = string.Empty;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.Address = string.Empty;
            this.City = string.Empty;
            this.State = string.Empty;
            this.Country = string.Empty;
        }

        [DataFormDisplayOptions(ShowLabel = false)]
        public string ProfileImage { get; set; }

        [Display(ShortName = "First name")]
        [Required(ErrorMessage = "Name should not be empty")]
        public string FirstName { get; set; }

        [Display(ShortName = "Last name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}