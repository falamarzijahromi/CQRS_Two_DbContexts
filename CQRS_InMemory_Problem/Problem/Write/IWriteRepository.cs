using System.Threading.Tasks;

namespace Write
{
    public interface IWriteRepository
    {
        Task<int> InsertSample(SampleWriteModel sampleWrite);
    }
}
