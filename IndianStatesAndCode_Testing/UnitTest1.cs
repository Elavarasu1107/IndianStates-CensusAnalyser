namespace IndianStatesAndCode_Testing
{
    public class Tests
    {
        [Test]
        public void GivenStatesCensusCSVFile_CheckNumberOfRecordsMatches()
        {
            int expected = 29;
            string filePath = @"D:\BridgeLabz\IndianStates-CensusAnalyser\IndianStates_Codes\StateCensusData.csv";
            IndianStates_Codes.StatesAnalyser getMethod = new IndianStates_Codes.StatesAnalyser();
            int actual = getMethod.DataAnalyser(filePath);
            Assert.AreEqual(expected, actual);
        }
    }
}