using System.Threading.Tasks;

namespace Read
{
    public interface IReadRepository
    {
        Task<SampleReadModel> GetSample(int id);
    }
}
