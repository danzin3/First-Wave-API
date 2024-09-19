using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Responses
{
    public interface ISingleResponse<T> : IMainResponse
    {
        public T Data { get; set; }
    }
}
