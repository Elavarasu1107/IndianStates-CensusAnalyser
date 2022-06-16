using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStates_Codes
{
    public class StatesAnalyser
    {
        public int DataAnalyser(string filePath)
        {
            if (Path.GetExtension(filePath) == ".csv")
            {
                try
                {
                    if (filePath.Contains("CensusData.csv"))
                    {
                        int numberOfRecords;
                        using (var reader = new StreamReader(filePath))
                        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                        {
                            var details = csv.GetRecords<StatesModel>().ToList();
                            numberOfRecords = details.Count();
                            foreach (var item in details)
                            {
                                Console.WriteLine("State: " + item.State + "\nPopulation: " + item.Population + "\nAreaInSqKm: " + item.AreaInSqKm
                                    + "\nDensityPerSqKm: " + item.DensityPerSqKm + "\n");
                            }
                        }
                        return numberOfRecords;
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.INVALID_FILE, "Invalid File");
                    }
                }
                catch (CsvHelper.MissingFieldException)
                {
                    throw new CustomException(CustomException.ExceptionType.INCORRECT_DELIMITER, "Incorrect Delimiter");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_FILE_TYPE, "Invalid File Type");
            }
            return default;
        }
    }
}
