using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using WorkPlaceConnector.Models;
using System.Collections.Generic;
using System.IO;

namespace WorkPlaceConnector.Data
{
    public static class CsvDataLoader
    {
        public static List<WorkPlaceProperties> LoadDataFromCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.RegisterClassMap<AppliancePartMap>();
                return new List<WorkPlaceProperties>(csv.GetRecords<WorkPlaceProperties>());
            }
        }
    }

    public class ApplianceListConverter : DefaultTypeConverter
    {
        public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            var appliances = text.Split(';');
            return new List<string>(appliances);
        }
    }

    public class AppliancePartMap : ClassMap<WorkPlaceProperties>
    {
        public AppliancePartMap()
        {
            Map(m => m.PostId);
            Map(m => m.PostedBy);
            Map(m => m.description);
            Map(m => m.PostedOn);
            Map(m => m.URL);
           // Map(m => m.Appliances).TypeConverter<ApplianceListConverter>();
        }
    }
}