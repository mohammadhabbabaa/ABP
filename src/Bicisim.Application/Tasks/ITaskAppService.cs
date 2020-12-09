using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Bicisim.Tasks.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicisim.Tasks
{
   public interface ITaskAppService : IApplicationService
    {

        ListResultDto<TaskListDto> GetAll();
    }
}
