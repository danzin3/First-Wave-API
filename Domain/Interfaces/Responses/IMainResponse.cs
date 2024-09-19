using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Responses
{
    public interface IMainResponse
    {
        public bool? Success { get; set; }
        public string? Details { get; set; }
        public int? TimingInMs { get; set; }
    }
}
