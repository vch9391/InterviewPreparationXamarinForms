using System;
using InterviewPreparationXamarinForms.NUnitTestingSamples;
using Moq;
using NUnit.Framework;
using Xamarin.Forms.Mocks;

namespace TestingWithNUnit
{
    [TestFixture()]
    public class MainPageViewModelTest
    {
        DependencyServiceStub DependencyService { get; set; }
        Mock<ICalculateServer> ServerSideDataMock { get; set; }

        [SetUp]
        public void SetUp()
        {
            MockForms.Init();
            DependencyService = new DependencyServiceStub();
            ServerSideDataMock = new Mock<ICalculateServer>();
            DependencyService.Register<ICalculateServer>(ServerSideDataMock.Object);
        }

        [Test]
        public void TestCase()
        {
            var _DependencyService = new DependencyServiceStub();
            var testVm = new MainPageViewModelForNunit(_DependencyService);
            testVm.TempSubmitCommand.Execute(null);
            Assert.AreEqual(10, testVm.TempTesting);
        }

        [Test]
        public void TestCase2()
        {
            ServerSideDataMock.Setup(m => m.Add(1, 3)).Returns(4);

            var testVm = new MainPageViewModelForNunit(DependencyService);
            testVm.Entry1 = 1;
            testVm.Entry2 = 3;
            testVm.SubmitCommand.Execute(null);
            Assert.AreEqual(4, testVm.Label1);
        }
    }
}
