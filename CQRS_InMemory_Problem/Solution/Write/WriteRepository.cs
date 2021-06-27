using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Write
{
    public class WriteRepository : IWriteRepository
    {
        private readonly DbContext dbContext;

        public WriteRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> InsertSample(SampleWriteModel sampleWrite)
        {
            dbContext.Set<SampleWriteModel>().Add(sampleWrite);

            await dbContext.SaveChangesAsync();

            return sampleWrite.Id;
        }
    }
}
