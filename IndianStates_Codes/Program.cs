using System;

namespace IndianStates_Codes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath = @"D:\BridgeLabz\IndianStates-CensusAnalyser\IndianStates_Codes\StateCensusData.csv";
            StatesAnalyser getMethod = new StatesAnalyser();
            getMethod.DataAnalyser(filePath);
        }
    }
}

