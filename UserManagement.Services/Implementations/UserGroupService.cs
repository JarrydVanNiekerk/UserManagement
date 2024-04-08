using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.Core.Models;
using UserManagement.Repository.Interfaces;
using UserManagement.Services.Interfaces;

namespace UserManagement.Services.Implementations
{
    public class UserGroupService : IUserGroupService
    {
        private readonly IGenericRepository<UserGroup> _userGroupRepository;

        public UserGroupService(IGenericRepository<UserGroup> userGroupRepository)
        {
            _userGroupRepository = userGroupRepository;
        }

        public async Task<IEnumerable<UserGroup>> GetAllAsync()
        {
            return await _userGroupRepository.GetAllAsync();
        }

        public async Task<UserGroup> GetByIdAsync(object id)
        {
            return await _userGroupRepository.GetByIdAsync(id);
        }

        public async Task InsertAsync(UserGroup entity)
        {
            await _userGroupRepository.InsertAsync(entity);
        }

        public async Task UpdateAsync(UserGroup entity)
        {
            await _userGroupRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(UserGroup entity)
        {
            await _userGroupRepository.DeleteAsync(entity);
        }
    }
}
