using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using DenarCZ.Data;

namespace DenarData.Lookup
{

    public sealed class LevelLookupConverter : TypeConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true; // jen výběr z nabídky
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            var pairs = GetPairs(context);
            int count = pairs.Count;

            // přeneseme hodnoty do jednoduchého pole
            int[] values = new int[count];
            for (int i = 0; i < count; i++)
                values[i] = pairs[i].Value;

            return new StandardValuesCollection(values);
        }

        //Řekneme PropertyGridu, že umíme převádět ze stringu (pro vstup z ComboBoxu)
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        //Řekneme PropertyGridu, že umíme převádět na string (pro zobrazení v UI)
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return true;
            }
            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                var pairs = GetPairs(context);
                for (int i = 0; i < pairs.Count; i++)
                {
                    if (Equals(pairs[i].Value, value))
                        return pairs[i].Label;
                }
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string s)
            {
                var pairs = GetPairs(context);
                for (int i = 0; i < pairs.Count; i++)
                {
                    if (pairs[i].Label == s)
                        return pairs[i].Value;
                }
                return int.Parse(s);
            }

            return base.ConvertFrom(context, culture, value);
        }

        private static System.Collections.Generic.List<(int Value, string Label)> GetPairs(ITypeDescriptorContext context)
        {

            if (context == null || context.PropertyDescriptor == null)
                return new System.Collections.Generic.List<(int, string)>();


            string name = context.PropertyDescriptor.Name;

            if (name.IndexOf("ConfidentialityRequirement", StringComparison.OrdinalIgnoreCase) >= 0)
                return LookupProvider.ParsePairs(
                    AppConfig.Instance.ConfidentialityLevels,
                    AppConfig.Instance.ConfidentialityLabels,
                    int.Parse);

            if (name.IndexOf("IntegrityRequirement", StringComparison.OrdinalIgnoreCase) >= 0)
                return LookupProvider.ParsePairs(
                    AppConfig.Instance.IntegrityLevels,
                    AppConfig.Instance.IntegrityLabels,
                    int.Parse);

            if (name.IndexOf("AvailabilityRequirement", StringComparison.OrdinalIgnoreCase) >= 0)
                return LookupProvider.ParsePairs(
                    AppConfig.Instance.AvailabilityLevels,
                    AppConfig.Instance.AvailabilityLabels,
                    int.Parse);

            if (name.IndexOf("Criticality", StringComparison.OrdinalIgnoreCase) >= 0)
                return LookupProvider.ParsePairs(
                    AppConfig.Instance.CriticalityLevels,
                    AppConfig.Instance.CriticalityLabels,
                    int.Parse);


            return new System.Collections.Generic.List<(int, string)>();
        }
    }


}
