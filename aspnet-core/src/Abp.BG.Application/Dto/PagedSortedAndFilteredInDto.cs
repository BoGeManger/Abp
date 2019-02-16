using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.BG.Dto
{
    public class PagedSortedAndFilteredInDto : PagedAndSortedInDto
    {
        public string Filter { get; set; }
    }
}
