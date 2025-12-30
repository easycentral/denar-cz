using DenarData.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Text;

namespace DenarData.Asset
{
    public class PrimaryAsset : IDataItem
    {
        // Implementace vlastností z IDataItem
        [Category("Obecné")]
        [DisplayName("ID")]
        [Description("Unikátní identifikátor aktiva")]
        [ReadOnly(true)]
        public Guid Id { get; set; }
        [Category("Obecné")]
        [DisplayName("Poslední změna")]
        [Description("Datum a čas poslední změny")]
        [ReadOnly(true)]
        public DateTime LastModified { get; set; }

        // Vlastnosti specifické pro PrimaryAsset
        [Category("Detaily aktiva")]
        [DisplayName("Název")]
        [Description("Název primárního aktiva")]
        public string Name { get; set; }
        [Category("Detaily aktiva")]
        [DisplayName("Popis")]
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        [Description("Popis primárního aktiva")]
        public string Description { get; set; }
        [Category("Detaily aktiva")]
        [DisplayName("Kategorie aktiva")]
        [Description("Kategorie, do které primární aktivum patří")]
        public string AssetCategory { get; set; }
        [Category("Detaily aktiva")]
        [DisplayName("Vlastník")]
        [Description("Vlastník primárního aktiva")]
        public string Owner { get; set; }
        [Category("Ohodnocení")]
        [DisplayName("Důvěrnost")]
        [Description("Hodnocení důvěrnosti primárního aktiva (1-4)")]
        public int ConfidentialityRequirement { get; set; }
        [Category("Ohodnocení")]
        [DisplayName("Integrita")]
        [Description("Hodnocení integrity primárního aktiva (1-4)")]
        public int IntegrityRequirement { get; set; }
        [Category("Ohodnocení")]
        [DisplayName("Dostupnost")]
        [Description("Hodnocení dostupnosti primárního aktiva (1-4)")]
        public int AvailabilityRequirement { get; set; }
        [Category("Ohodnocení")]
        [DisplayName("Kritičnost")]
        [Description("Kritičnost primárního aktiva, vypočítaná jako maximum z hodnocení důvěrnosti, integrity a dostupnosti")]
        [ReadOnly(true)]
        public int Criticality => Math.Max(ConfidentialityRequirement,
                                  Math.Max(IntegrityRequirement, AvailabilityRequirement));


        [Category("Související aktiva")]
        [DisplayName("ID podpůrných aktiv")]
        [Description("Seznam ID podpůrných aktiv spojených s tímto primárním aktivem")]
        public List<Guid> SupportingAssetIds { get; set; }

        public PrimaryAsset()
        {
            Id = Guid.NewGuid();
            LastModified = DateTime.Now;
            Name = string.Empty;
            Description = string.Empty;
            AssetCategory = string.Empty;
            Owner = string.Empty;
            SupportingAssetIds = new List<Guid>();
        }

        
        public IDataItem GetSaveData()
        {
            var copy = (PrimaryAsset)this.MemberwiseClone();
            copy.SupportingAssetIds = new List<Guid>(this.SupportingAssetIds);
            return copy;
        }

        public int Load(IDataItem item)
        {
            if (item is PrimaryAsset source)
            {
                this.Id = source.Id;
                this.LastModified = source.LastModified;
                this.Name = source.Name;
                this.Description = source.Description;
                this.AssetCategory = source.AssetCategory;
                this.Owner = source.Owner;
                this.ConfidentialityRequirement = source.ConfidentialityRequirement;
                this.IntegrityRequirement = source.IntegrityRequirement;
                this.AvailabilityRequirement = source.AvailabilityRequirement;
                this.SupportingAssetIds = source.SupportingAssetIds != null
                    ? new List<Guid>(source.SupportingAssetIds)
                    : new List<Guid>();
                return 0;
            }
            return -1;
        }

        public Type getType()
        {
            return typeof(PrimaryAsset);
        }
    }
}
