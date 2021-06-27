using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Read
{
    public class ReadRepository : IReadRepository
    {
        private readonly ReadDbContext dbContext;

        public ReadRepository(ReadDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<SampleReadModel> GetSample(int id)
        {
            var sample = await dbContext.SampleReadModels.SingleOrDefaultAsync(srm => srm.Id == id);

            return sample;
        }
    }
}
