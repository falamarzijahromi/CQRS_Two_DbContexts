using Read;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Write;
using Xunit;

namespace Test
{
    [Binding]
    public class DbContextsDataConsistencySteps
    {
        private readonly IWriteRepository writeRepository;
        private readonly IReadRepository readRepository;
        private readonly ScenarioContext context;

        public DbContextsDataConsistencySteps(IWriteRepository writeRepository, IReadRepository readRepository, ScenarioContext context)
        {
            this.writeRepository = writeRepository;
            this.readRepository = readRepository;
            this.context = context;
        }

        [Given(@"Sample Write Model With Name ""(.*)"" And Code ""(.*)"" And ID ""(.*)"" In The Write Model")]
        public async Task GivenSampleWriteModelWithNameAndCodeAndIDInTheWriteModel(string name, string code, int id)
        {
            var sample = new SampleWriteModel
            {
                Id = id,
                Name = name,
                Code = code,
            };

            await writeRepository.InsertSample(sample);
        }
        
        [When(@"Sample With ID ""(.*)"" Fetched From Read Model")]
        public async Task WhenSampleWithIDFetchedFromReadModel(int id)
        {
            var sample = await readRepository.GetSample(id);

            context.Set(sample, "Sample");
        }
        
        [Then(@"The Fetched Sample Read Model's Username shoud be ""(.*)""")]
        public void ThenTheFetchedSampleReadModelSUsernameShoudBe(string username)
        {
            var sample = context.Get<SampleReadModel>("Sample");

            Assert.NotNull(sample);
            Assert.Equal(username, sample.Name);
        }
    }
}
