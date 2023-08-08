using LibraryManagementSystem.Core.Repositories;
using LibraryManagementSystem.Core.Services;
using LibraryManagementSystem.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;

        private readonly IUnitOfWork _unitOfWork;

        public Service(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _repository.AddRange(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }

        public async Task DeleteAsync(T entity)
        {
            _repository.Delete(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteRangeAsync(IEnumerable<T> entities)
        {
            _repository.DeleteRange(entities);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll().ToListAsync();


        }

        public async Task<T> GetByIdAsync(int id)
        {
            var hasProduct = await _repository.GetByIdAsync(id);

            return hasProduct;
        }

        public async Task UpdateAsync(T entity)
        {
            _repository.Update(entity);
            await _unitOfWork.CommitAsync();
        }
    }
}
