using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Bicisim.Authorization;
using Bicisim.Tasks.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicisim.Tasks
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class TaskAppService : BicisimAppServiceBase, ITaskAppService
    {
        private readonly IRepository<Task> _taskRepository;

        public TaskAppService(IRepository<Task> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public ListResultDto<TaskListDto> GetAll( )
        {
            var tasks =  _taskRepository
                .GetAll()
             
             
                .OrderByDescending(t => t.CreationTime)
                .ToList();

            return new ListResultDto<TaskListDto>(
                ObjectMapper.Map<List<TaskListDto>>(tasks)
            );
        }
    }
}
