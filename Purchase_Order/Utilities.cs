using ExcelDataReader;
using System;
using System.Data;
using System.IO;

namespace Purchase_Order
{
    public static class Utilities
    {
        public static DataTable ReadExcelFile(string filePath, bool hasHeader)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("The specified file was not found.", filePath);

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // Create the ExcelDataReader
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Configure the dataset
                    var config = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = hasHeader
                        }
                    };

                    // Read the dataset
                    var dataset = reader.AsDataSet(config);

                    return dataset.Tables[0];
                }
            }
        }
    }
}
