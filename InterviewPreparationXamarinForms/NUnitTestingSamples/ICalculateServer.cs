using System;
using System.Threading.Tasks;

namespace InterviewPreparationXamarinForms.NUnitTestingSamples
{
    public interface ICalculateServer
    {
        int Add(int a, int b);

        Task<int> AddAsync(int a, int b);
    }
}
