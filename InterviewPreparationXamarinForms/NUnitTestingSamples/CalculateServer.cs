using System;
using System.Threading.Tasks;
using InterviewPreparationXamarinForms.NUnitTestingSamples;
using Xamarin.Forms;

[assembly: Dependency(typeof(CalculateServer))]
namespace InterviewPreparationXamarinForms.NUnitTestingSamples
{
    public class CalculateServer : ICalculateServer
    {
        public CalculateServer()
        {
        }

        public int Add(int a, int b)
        {
            int i = a + b;
            Console.WriteLine("Add : " + i);
            return i;
        }

        public Task<int> AddAsync(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
