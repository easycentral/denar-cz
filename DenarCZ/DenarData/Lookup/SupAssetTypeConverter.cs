using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DenarData.Lookup
{
    public class SupAssetTypeConverter : StringConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => true;
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => true;
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            var values = DenarCZ.Data.AppConfig.Instance.SupportingAssetTypes.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            return new StandardValuesCollection(values);
        }
    }
}
