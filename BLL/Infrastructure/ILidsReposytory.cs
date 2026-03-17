using BLL.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Infrastructure
{
    public interface ILidsReposytory
    {
        public  Task CreateNewLid(ContactLidsDTO lid);
        public Task<List<ContactLidsDTO>> GetAllLids();

        public Task<List<CategoryLidsDTO>> GetAllCategories();
    }
}
