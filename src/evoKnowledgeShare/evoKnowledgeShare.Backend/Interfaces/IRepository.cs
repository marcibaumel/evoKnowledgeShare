﻿namespace evoKnowledgeShare.Backend.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        Task AddAsync(T entity);
        void AddRange(IEnumerable<T> entities);
        T GetById(int id);
        T GetByUserId(string id);
        T GetByGuid(Guid guid);
        T GetByTopicId(int id);
        T GetByCreationTime(DateTimeOffset date);
        T GetByDescription (string description);
        T GetByTitle (string title);
        IEnumerable<T> GetRangeById(IEnumerable<int> ids);
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        void Remove(T entity);
        void RemoveById(int id);
        void RemoveRange(IEnumerable<T> entities);
        void RemoveRangeById(IEnumerable<int> ids);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entitites);
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
