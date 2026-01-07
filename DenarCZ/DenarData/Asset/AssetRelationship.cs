using DenarData.Common;
using System;
using System.ComponentModel;

namespace DenarData.Asset
{
    public class AssetRelationship : IDataItem
    {
        // Implementace vlastností z IDataItem
        [Category("Obecné")]
        [DisplayName("ID")]
        [Description("Unikátní identifikátor vazby")]
        [ReadOnly(true)]
        public Guid Id { get; set; }

        [Category("Obecné")]
        [DisplayName("Poslední zmìna")]
        [Description("Datum a èas poslední zmìny")]
        [ReadOnly(true)]
        public DateTime LastModified { get; set; }

        // Vlastnosti specifické pro vazbu
        [Category("Vazba")]
        [DisplayName("ID primárního aktiva")]
        [Description("ID primárního aktiva")]
        public Guid PrimaryAssetId { get; set; }

        [Category("Vazba")]
        [DisplayName("Název primárního aktiva")]
        [Description("Název primárního aktiva (automaticky doplnìno)")]
        [ReadOnly(true)]
        public string PrimaryAssetName { get; set; }

        [Category("Vazba")]
        [DisplayName("ID podpùrného aktiva")]
        [Description("ID podpùrného aktiva")]
        public Guid SupportingAssetId { get; set; }

        [Category("Vazba")]
        [DisplayName("Název podpùrného aktiva")]
        [Description("Název podpùrného aktiva (automaticky doplnìno)")]
        [ReadOnly(true)]
        public string SupportingAssetName { get; set; }

        [Category("Detaily")]
        [DisplayName("Typ vazby")]
        [Description("Typ vztahu mezi aktivy")]
        public string RelationshipType { get; set; }

        [Category("Detaily")]
        [DisplayName("Popis vazby")]
        [Description("Detailní popis vazby mezi aktivy")]
        public string Description { get; set; }

        [Category("Detaily")]
        [DisplayName("Dùležitost")]
        [Description("Dùležitost této vazby (1-4)")]
        [TypeConverter(typeof(DenarData.Lookup.LevelLookupConverter))]
        public int Importance { get; set; }

        public AssetRelationship()
        {
            Id = Guid.NewGuid();
            LastModified = DateTime.Now;
            PrimaryAssetId = Guid.Empty;
            SupportingAssetId = Guid.Empty;
            PrimaryAssetName = string.Empty;
            SupportingAssetName = string.Empty;
            RelationshipType = string.Empty;
            Description = string.Empty;
            Importance = 1;
        }

        public IDataItem GetSaveData()
        {
            var copy = (AssetRelationship)this.MemberwiseClone();
            return copy;
        }

        public int Load(IDataItem item)
        {
            if (item is AssetRelationship source)
            {
                this.Id = source.Id;
                this.LastModified = source.LastModified;
                this.PrimaryAssetId = source.PrimaryAssetId;
                this.SupportingAssetId = source.SupportingAssetId;
                this.PrimaryAssetName = source.PrimaryAssetName;
                this.SupportingAssetName = source.SupportingAssetName;
                this.RelationshipType = source.RelationshipType;
                this.Description = source.Description;
                this.Importance = source.Importance;
                return 0;
            }
            return -1;
        }

        public Type getType()
        {
            return typeof(AssetRelationship);
        }
    }
}