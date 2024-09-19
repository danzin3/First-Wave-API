using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Responses
{
    public interface IPaginatedResponse<T> : IMainResponse
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }
        public ICollection<T> Data { get; set; }
    }
}
