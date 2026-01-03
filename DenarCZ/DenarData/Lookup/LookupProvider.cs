using System;
using System.Collections.Generic;
using System.Text;

namespace DenarData.Lookup
{

    public static class LookupProvider
    {
        /// <summary>
        /// Vrátí spárované dvojice (Value, Label) z konfigurace "1;2;3;4" + "Nízká;Střední;Vysoká;Kritická".
        /// valueParser umožní převést string na cílový typ (int, string, …).
        /// </summary>
        public static List<(T Value, string Label)> ParsePairs<T>(
            string valuesSeparatedBySemicolon,
            string labelsSeparatedBySemicolon,
            Func<string, T> valueParser)
        {
            if (valuesSeparatedBySemicolon is null) throw new ArgumentNullException(nameof(valuesSeparatedBySemicolon));
            if (labelsSeparatedBySemicolon is null) throw new ArgumentNullException(nameof(labelsSeparatedBySemicolon));
            if (valueParser is null) throw new ArgumentNullException(nameof(valueParser));

            string[] vals = valuesSeparatedBySemicolon
                .Split(';')
                .Select(s => s.Trim())
                .Where(s => s.Length > 0)
                .ToArray();

            string[] labels = labelsSeparatedBySemicolon
                .Split(';')
                .Select(s => s.Trim())
                .Where(s => s.Length > 0)
                .ToArray();

            // Základní kontrola – počty by měly sedět
            int count = Math.Min(vals.Length, labels.Length);
            var list = new List<(T, string)>(count);

            for (int i = 0; i < count; i++)
            {
                T v = valueParser(vals[i]);
                string label = labels[i];
                list.Add((v, label));
            }

            // Pokud nesedí počty, můžeme zalogovat/varovat
            if (vals.Length != labels.Length)
            {
                // TODO: log warning – např. přes Debug.WriteLine nebo ILogger
                // Debug.WriteLine($"Warning: values={vals.Length} labels={labels.Length}; zbytek ignorován.");
            }

            return list;
        }

        
        public static List<(int Value, string Label)> GetLevelLabels(string configValues, string configLabels)
            => ParsePairs(configValues, configLabels, s => int.Parse(s, System.Globalization.CultureInfo.InvariantCulture));
    }

}
