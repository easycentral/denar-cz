using System;
using System.Collections.Generic;
using System.Text;

namespace DenarData.Lookup
{
    public class AssetCategories
    {
        public List<string> CategoryNames { get; set; } = new List<string>();
        
        AssetCategories(string categories)
        {
            string[] splits = categories.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var category in splits)
            {
                CategoryNames.Add(category.Trim());
            }
        }
    }
}
