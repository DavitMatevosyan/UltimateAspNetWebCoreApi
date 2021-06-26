using Contracts;
using Entities;

namespace Repository
{
    public class CompanyRepository : RepositoryBase<CompanyRepository>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repoContext) : base(repoContext)
        {

        }
    }
}
