using AplikacjaKonsola;

namespace ProgramTests
{
    public class UnitTest1
    {
        [Fact]
        public void GivenFilePath_WhenLoadDataFromFile_ThenReturnList()
        {
            //arrange
            string filePath = "../../../test.txt";

            //act
            var test = Program.LoadDataFromFile(filePath);

            //assert
            Assert.Equal(test[0].Artist, "Gorillaz");
            Assert.Equal(test[0].Album, "\"The Now Now\"");
            Assert.Equal(test[0].SongsNumber, int.Parse("11"));
            Assert.Equal(test[0].Year, int.Parse("2018"));
            Assert.Equal(test[0].DownloadNumber, int.Parse("11000102"));


        }
    }
}