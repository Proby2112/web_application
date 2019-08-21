using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;
using WebApplication.Core.Interfaces.Services;
using WebApplication.Core.Models;

namespace WebApplication.BL.Services
{
    public class ProcessService : BaseService<ProcessAddViewModel, ProcessGetFullViewModel, Process, string>, IProcessService
    {
        public ProcessService(IProcessRepository repository, IDataAdapter dataAdapter) : base(repository, dataAdapter) { }
    }

}
