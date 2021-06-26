using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private CompanyRepository _companyRepository;
        private EmployeeRepository _employeeRepository;

        public RepositoryManager(RepositoryContext repoContext)
        {
            _repositoryContext = repoContext;
        }

        public ICompanyRepository Company
        {
            get
            {
                if (_companyRepository is null)
                    _companyRepository = new CompanyRepository(_repositoryContext);
                return _companyRepository;
            }
        }

        public IEmployeeRepository Employee
        {
            get
            {
                if (_employeeRepository is null)
                    _employeeRepository = new EmployeeRepository(_repositoryContext);
                return _employeeRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}
