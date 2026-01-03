using DenarData.Common;
using System;
using System.ComponentModel;

namespace DenarData.Asset
{
    public class SupportingAssetDependency : IDataItem
    {
        // Implementace vlastností z IDataItem
        [Category("Obecné")]
        [DisplayName("ID")]
        [Description("Unikátní identifikátor závislosti")]
        [ReadOnly(true)]
        public Guid Id { get; set; }

        [Category("Obecné")]
        [DisplayName("Poslední zmìna")]
        [Description("Datum a èas poslední zmìny")]
        [ReadOnly(true)]
        public DateTime LastModified { get; set; }

        // Vlastnosti specifické pro závislost
        [Category("Závislost")]
        [DisplayName("ID nadøazeného aktiva")]
        [Description("ID podpùrného aktiva, které závisí na jiném")]
        public Guid DependentAssetId { get; set; }

        [Category("Závislost")]
        [DisplayName("ID podøízeného aktiva")]
        [Description("ID podpùrného aktiva, na kterém závisí nadøazené")]
        public Guid DependsOnAssetId { get; set; }

        [Category("Detaily")]
        [DisplayName("Typ závislosti")]
        [Description("Typ závislosti mezi podpùrnými aktivy")]
        public string DependencyType { get; set; }

        [Category("Detaily")]
        [DisplayName("Popis závislosti")]
        [Description("Detailní popis závislosti")]
        public string Description { get; set; }

        [Category("Detaily")]
        [DisplayName("Kritiènost")]
        [Description("Kritiènost této závislosti (1-4)")]
        public int Criticality { get; set; }

        public SupportingAssetDependency()
        {
            Id = Guid.NewGuid();
            LastModified = DateTime.Now;
            DependentAssetId = Guid.Empty;
            DependsOnAssetId = Guid.Empty;
            DependencyType = string.Empty;
            Description = string.Empty;
            Criticality = 1;
        }

        public IDataItem GetSaveData()
        {
            var copy = (SupportingAssetDependency)this.MemberwiseClone();
            return copy;
        }

        public int Load(IDataItem item)
        {
            if (item is SupportingAssetDependency source)
            {
                this.Id = source.Id;
                this.LastModified = source.LastModified;
                this.DependentAssetId = source.DependentAssetId;
                this.DependsOnAssetId = source.DependsOnAssetId;
                this.DependencyType = source.DependencyType;
                this.Description = source.Description;
                this.Criticality = source.Criticality;
                return 0;
            }
            return -1;
        }

        public Type getType()
        {
            return typeof(SupportingAssetDependency);
        }
    }
}