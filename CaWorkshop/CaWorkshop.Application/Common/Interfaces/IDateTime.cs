using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaWorkshop.Application.Common.Interfaces
{
    public interface IDateTime
    {
     public DateTime UtcNow { get; set; }   
    }
}
