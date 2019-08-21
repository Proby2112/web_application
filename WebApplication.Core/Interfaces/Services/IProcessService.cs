using WebApplication.Core.Entities;
using WebApplication.Core.Models;

namespace WebApplication.Core.Interfaces.Services
{
    public interface IProcessService : IBaseService<ProcessAddViewModel, ProcessGetFullViewModel, Process, string>
    {
    }
}
