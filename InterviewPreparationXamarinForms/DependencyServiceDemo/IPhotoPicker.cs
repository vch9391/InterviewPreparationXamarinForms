using System.IO;
using System.Threading.Tasks;

namespace InterviewPreparationXamarinForms.DependencyServiceDemo
{
    public interface IPhotoPicker
    {
        Task<Stream> GetImageStreamAsync();
    }
}
