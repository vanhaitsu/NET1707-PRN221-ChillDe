
using IMS.Models.Interfaces;
namespace IMS.Models.Common;

using IMS.Repositories;
using IMS.Repositories.Interfaces;
using IMS.Repositories.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _dbContext;
    private readonly IAccountRepository _accountRepository;
    private readonly IRoleRepository _roleRepository;
    private readonly ITrainingProgramRepository _trainingProgramRepository;
    private readonly IInternRepository _internRepository;
    private readonly IAssignmentRepository _assignmentRepository;
    private readonly ICampaignRepository _campaignRepository;
    private readonly IApplicationrepository _applicationRepository;

    public UnitOfWork(AppDbContext dbContext, IAccountRepository accountRepository,
                        IRoleRepository roleRepository, IInternRepository internRepository,
                        ITrainingProgramRepository trainingProgramRepository,
                        ICampaignRepository campaignRepository,
                        IApplicationrepository applicationRepository, IAssignmentRepository assignmentRepository)
    {
        _dbContext = dbContext;
        _accountRepository = accountRepository;
        _roleRepository = roleRepository;
        _trainingProgramRepository = trainingProgramRepository;
        _internRepository = internRepository;
        _assignmentRepository = assignmentRepository;
        _campaignRepository = campaignRepository;
        _applicationRepository = applicationRepository;
    }

    public AppDbContext DbContext => _dbContext;

    public IAccountRepository AccountRepository => _accountRepository;
    public IRoleRepository RoleRepository => _roleRepository;
    public ITrainingProgramRepository TrainingProgramRepository => _trainingProgramRepository;

    public IInternRepository InternRepository => _internRepository;
    public IAssignmentRepository AssignmentRepository => _assignmentRepository;

    public ICampaignRepository CampaignRepository => _campaignRepository;
    public IApplicationrepository ApplicationRepository => _applicationRepository;

    public async Task<int> SaveChangeAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }
}

