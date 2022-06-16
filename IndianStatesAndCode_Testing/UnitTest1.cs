namespace IndianStatesAndCode_Testing
{
    public class Tests
    {
        //UC1:
        [Test]
        public void GivenStatesCensusCSVFile_CheckNumberOfRecordsMatches()
        {
            int expected = 29;
            string filePath = @"D:\BridgeLabz\IndianStates-CensusAnalyser\IndianStates_Codes\StateCensusData.csv";
            IndianStates_Codes.StatesAnalyser getMethod = new IndianStates_Codes.StatesAnalyser();
            int actual = getMethod.DataAnalyser(filePath);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenInvalidFile_ShouldThrowInvalidFileException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabz\IndianStates-CensusAnalyser\IndianStates_Codes\StateCode.csv";
                IndianStates_Codes.StatesAnalyser getMethod = new IndianStates_Codes.StatesAnalyser();
                int actual = getMethod.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidFileType_ShouldThrowInvalidFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabz\IndianStates-CensusAnalyser\IndianStates_Codes\StateCensusData.txt";
                IndianStates_Codes.StatesAnalyser getMethod = new IndianStates_Codes.StatesAnalyser();
                int actual = getMethod.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File Type", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidDelimiterFile_ShouldThrowInvalidDelimiterFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabz\IndianStates-CensusAnalyser\IndianStates_Codes\InvalidDelimiterCensusData.csv";
                IndianStates_Codes.StatesAnalyser getMethod = new IndianStates_Codes.StatesAnalyser();
                int actual = getMethod.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Delimiter", ex.Message);
            }
        }
        [Test]
        public void GivenIncorrectHeaderFile_ShouldThrowIncorrectHeaderFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabz\IndianStates-CensusAnalyser\IndianStates_Codes\IncorrectHeaderCensusData.csv";
                IndianStates_Codes.StatesAnalyser getMethod = new IndianStates_Codes.StatesAnalyser();
                int actual = getMethod.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Header", ex.Message);
            }
        }
        //UC2:
        [Test]
        public void GivenStatesCodeCSVFile_CheckNumberOfRecordsMatches()
        {
            int expected = 37;
            string filePath = @"D:\BridgeLabz\IndianStates-CensusAnalyser\IndianStates_Codes\StateCode.csv";
            IndianStates_Codes.StatesAnalyser getMethod = new IndianStates_Codes.StatesAnalyser();
            int actual = getMethod.StateCodeAnalyser(filePath);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenInvalidCodeFile_ShouldThrowInvalidFileException()
        {
            try
            {
                int expected = 37;
                string filePath = @"D:\BridgeLabz\IndianStates-CensusAnalyser\IndianStates_Codes\StateCensusData.csv";
                IndianStates_Codes.StatesAnalyser getMethod = new IndianStates_Codes.StatesAnalyser();
                int actual = getMethod.StateCodeAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File", ex.Message);
            }
        }
    }
}