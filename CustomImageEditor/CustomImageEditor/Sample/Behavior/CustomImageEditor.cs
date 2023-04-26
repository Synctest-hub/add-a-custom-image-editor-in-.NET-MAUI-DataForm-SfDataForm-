using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomImageEditor
{
    public class CustomImageEditor : IDataFormEditor
    {
        private SfDataForm customdataForm;
        public CustomImageEditor(SfDataForm customDataForm) 
        {
            this.customdataForm = customDataForm;
        }
        public View CreateEditorView(DataFormItem dataFormItem)
        {
            Image inputView = new Image();
            inputView.Source = "profile.png";
            inputView.HeightRequest= 100;
            inputView.HorizontalOptions = LayoutOptions.Center;
            return inputView;
        }
        public void UpdateReadyOnly(DataFormItem dataFormItem)
        {

        }
        public void CommitValue(DataFormItem dataFormItem, View view)
        {

        }
    }
}