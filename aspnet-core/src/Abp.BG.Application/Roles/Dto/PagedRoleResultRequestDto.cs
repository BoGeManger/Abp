using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;

namespace Abp.BG.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string RoleName { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
    }
}

