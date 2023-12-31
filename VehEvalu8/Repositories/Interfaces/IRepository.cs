﻿using VehEvalu8.Data;
using VehEvalu8.Data.DBModels;

namespace VehEvalu8.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        void AddMotorcycle(T motorcycle, MotoContext context);

        Task TopFiveByProfitAsync();

        //WHY THIS WON'T WORK!?
        //Task<T> MotorcycleInfoAsync(string link, MotoContext context) where T : class;

        Task<string> RepositoryStatusAsync();

        string RemoveMotorcycle(string link, MotoContext context);

        //void MotorcycleExists(T motorcycle); -- Not sure if this will be needed for the scope of the program, will just add it for now

        //TODO - METHODS TO IMPLEMENT ON A LATER STAGE - ASYNC

        //Task<T> GetByIdAsync<T>(int id) where T : class;
        //Task AddAsync<T>(T entity) where T : class; 
        //Task AddRangeAsync<T>(IEnumerable<T> entitis) where T : class; 
        //Task DeleteAsync<T>(int id) where T : class;
        //Task SaveChangesAsync();
    }
}
