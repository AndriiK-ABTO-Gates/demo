namespace WpfDemoApp.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            await Task.Delay(1000);
            Assert.Pass();
        }

        [Test]
        public async Task Test2()
        {
            await Task.Delay(1500);
            Assert.Pass();
        }

        [Test]
        public async Task Test3()
        {
            await Task.Delay(2000);
            Assert.Pass();
        }

        [Test]
        public async Task Test4()
        {
            await Task.Delay(2500);
             Assert.Pass();
        }
    }
}
