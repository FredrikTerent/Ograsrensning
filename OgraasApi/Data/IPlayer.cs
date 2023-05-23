﻿using OgraasApi.Models;

namespace OgraasApi.Data
{
    public interface IPlayer
    {
        Task Create (Player player);
        Task Update (Player player);
        Task Delete (int id);
        Task<IEnumerable<Player>> GetAll();
        Task <Player> GetById (int id);

    }
}
