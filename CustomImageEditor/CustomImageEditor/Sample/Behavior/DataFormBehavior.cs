using Syncfusion.Maui.DataForm;

namespace CustomImageEditor
{
    public class DataFormBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            if (dataForm != null)
            {
                dataForm.RegisterEditor("ProfileImage", new CustomImageEditor(dataForm));
            }
        }
        protected override void OnDetachingFrom(SfDataForm dataForm)
        {
            base.OnDetachingFrom(dataForm);
            if (dataForm != null)
            {
                dataForm = null;
            }
        }
    }
}