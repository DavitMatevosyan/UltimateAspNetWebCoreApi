using Contracts;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repoContext) : base(repoContext)
        {

        }

        public IEnumerable<Company> GetAllCompanies(bool trackChanges)
            => FindAll(trackChanges).OrderBy(x => x.Name).ToList();
    }
}
