using Xunit;
using pluralsight_concourse_dotnetcore.Controllers;

namespace unittests {

    public class TestClass {

        private ValuesController _vc;

        public TestClass() {
            _vc = new ValuesController();
        }

        [Fact]
        public void Test1(){
            
            Assert.Equal("pluralsight", _vc.Get(2).Value);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(8)]
        //[InlineData(20)]
        public void Test2(int value) {
            Assert.Equal("closed", _vc.GetCaseStatus(value));
        }

    }

}
