using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Read
{
    public class ReadRepository : IReadRepository
    {
        private readonly DbContext dbContext;

        public ReadRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<SampleReadModel> GetSample(int id)
        {
            var sample = await dbContext.Set<SampleReadModel>().SingleOrDefaultAsync(srm => srm.Id == id);

            return sample;
        }
    }
}
