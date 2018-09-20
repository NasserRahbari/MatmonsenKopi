using ConceptsMicroservice.Utilities;
using Xunit;

namespace ConceptsMicroservice.UnitTests
{
    public class FileDBTest
    {

        private IFileDB _db;

        public FileDBTest()
        {
            _db = new FileDB();
        }

        [Fact]
        public void ReadFile_Returns_Empty_List_If_Resources_Does_Not_Exist()
        {
            _db.URL = "fake url";
            var concepts = _db.ReadFromFile();

            Assert.Empty(concepts);
        }

        [Fact]
        public void Fail_This_Test()
        {
            Assert.False(true);
        }
    }
}
