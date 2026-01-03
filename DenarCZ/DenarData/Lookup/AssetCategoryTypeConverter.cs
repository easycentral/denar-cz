using DenarCZ.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using static System.ComponentModel.TypeConverter;

namespace DenarData.Lookup
{

    public class AssetCategoryTypeConverter : StringConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => true;
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => true;


        //public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        //        => new(new[] { "IT", "Security", "Operations", "HR", "Finance" });

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {

            var values = AppConfig.Instance.AssetCategories.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            return new StandardValuesCollection(values);
        }
    }

}
