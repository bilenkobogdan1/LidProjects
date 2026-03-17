using AutoMapper;
using BLL.Infrastructure;
using BLL.ModelDTO;
using ConsoleApp1.LidProjectContext;
using Data.LidProject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class LidsReposytory: ILidsReposytory
    {
        private readonly LidProjectContext _context;
        private readonly IMapper _mapper;

        public LidsReposytory(LidProjectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        /// <summary>
        /// Додати новий лід
        /// </summary>
        /// <param name="lid"></param>
        /// <returns></returns>
        public async Task CreateNewLid(ContactLidsDTO lid)
        {
            using (_context)
            {
               await _context.ContactLids.AddAsync(_mapper.Map<Data.LidProject.ContactLids>(lid));
                _context.SaveChanges(); 
            }
        }
        /// <summary>
        /// Отримати всіх лідів
        /// </summary>
        /// <returns></returns>
        public async Task<List<ContactLidsDTO>> GetAllLids()
        {
            using (_context)
            {
                var lids = await _context.ContactLids.ToListAsync();
                return _mapper.Map<List<ContactLidsDTO>>(lids);
            }
        }
        public async Task<List<CategoryLidsDTO>> GetAllCategories()
        {
            using(_context)
            {
                var categorys = await _context.CategoryLids.ToListAsync();
                return _mapper.Map<List<CategoryLidsDTO>>(categorys);
            }
        }
    }
}
