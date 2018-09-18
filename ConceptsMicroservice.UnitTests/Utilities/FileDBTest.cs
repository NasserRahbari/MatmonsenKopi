
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Utilities;
using Xunit;

namespace ConceptsMicroservice.UnitTests
{
    public class FileDBTest
    {

        private IFileDB _db;
        private string _projectDirectory;
        private string _filesDirectory;

        public FileDBTest()
        {
            _db = new FileDB();
            _projectDirectory = System.Environment.CurrentDirectory;
            _filesDirectory = Path.Join(_projectDirectory, "Files");
        }

        [Fact]
        public void ReadFile_Returns_Empty_List_If_File_Is_Empty()
        {
            _db.DbFilePath = Path.Join(_filesDirectory, "no_concepts.csv");
            var concepts = _db.ReadFromFile();

            Assert.Empty(concepts);
        }

        [Fact]
        public void ReadFile_Returns_Empty_List_If_File_Does_Not_Exist()
        {
            _db.DbFilePath = Path.Join(_filesDirectory, "does not even exist....csv");
            var concepts = _db.ReadFromFile();

            Assert.Empty(concepts);
        }

        [Fact]
        public void ReadFile_Returns_List_Of_ConceptItems_If_File_Exist()
        {
            _db.DbFilePath = Path.Join(_filesDirectory, "concepts.csv");
            var concepts = _db.ReadFromFile();

            Assert.NotEmpty(concepts);
        }
    }
}
