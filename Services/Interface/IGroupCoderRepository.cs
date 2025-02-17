using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RiwiTalent.Models;

namespace RiwiTalent.Services.Interface
{
    public interface IGroupCoderRepository
    {
        Task<IEnumerable<GroupCoder>> GetGroupCoders();
    }
}