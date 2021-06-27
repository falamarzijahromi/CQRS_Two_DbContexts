using System.Threading.Tasks;

namespace Write
{
    public class WriteRepository : IWriteRepository
    {
        private readonly WriteDbContext dbContext;

        public WriteRepository(WriteDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> InsertSample(SampleWriteModel sampleWrite)
        {
            dbContext.SampleWriteModels.Add(sampleWrite);

            await dbContext.SaveChangesAsync();

            return sampleWrite.Id;
        }
    }
}
