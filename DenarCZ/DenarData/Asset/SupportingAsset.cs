using DenarData.Common;
using DenarData.Lookup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Text;
using System.Windows.Forms;

namespace DenarData.Asset
{
    public class SupportingAsset : IDataItem
    {
        // Implementace vlastností z IDataItem
        [Category("Obecné")]
        [DisplayName("ID")]
        [Description("Unikátní identifikátor podpůrného aktiva")]
        [ReadOnly(true)]
        public Guid Id { get; set; }

        [Category("Obecné")]
        [DisplayName("Poslední změna")]
        [Description("Datum a čas poslední změny")]
        [ReadOnly(true)]
        public DateTime LastModified { get; set; }

        // Vlastnosti specifické pro SupportingAsset
        [Category("Detaily aktiva")]
        [DisplayName("Název")]
        [Description("Název podpůrného aktiva")]
        public string Name { get; set; }

        [Category("Detaily aktiva")]
        [DisplayName("Popis")]
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        [Description("Popis podpůrného aktiva")]
        public string Description { get; set; }

        [Category("Detaily aktiva")]
        [DisplayName("Typ aktiva")]
        [Description("Typ podpůrného aktiva (HW, SW, Síť, Personál, Prostory, atd.)")]
        [TypeConverter(typeof(SupAssetTypeConverter))]
        public string AssetType { get; set; }

        [Category("Detaily aktiva")]
        [DisplayName("Umístění")]
        [Description("Fyzické nebo logické umístění aktiva")]
        public string Location { get; set; }

        [Category("Detaily aktiva")]
        [DisplayName("Garant")]
        [Description("Garant podpůrného aktiva")]
        public string Garant { get; set; }
        
        [Category("Detaily aktiva")]
        [DisplayName("Správce")]
        [Description("Správce podpůrného aktiva")]
        public string Administrator { get; set; }


        public SupportingAsset()
        {
            Id = Guid.NewGuid();
            LastModified = DateTime.Now;
            Name = string.Empty;
            Description = string.Empty;
            AssetType = string.Empty;
            Location = string.Empty;
            Administrator = string.Empty;
        
        }

        public IDataItem GetSaveData()
        {
            var copy = (SupportingAsset)this.MemberwiseClone();
            return copy;
        }

        public int Load(IDataItem item)
        {
            if (item is SupportingAsset source)
            {
                this.Id = source.Id;
                this.LastModified = source.LastModified;
                this.Name = source.Name;
                this.Description = source.Description;
                this.AssetType = source.AssetType;
                this.Location = source.Location;
                this.Administrator = source.Administrator;
                
                return 0;
            }
            return -1;
        }

        public Type getType()
        {
            return typeof(SupportingAsset);
        }
    }
}
