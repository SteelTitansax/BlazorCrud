using BlazorCrudDotNet8.Components.Entities;

namespace BlazorCrudDotNet8.Components.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
        Task<Game> GetGameById(int id);

        Task<Game> AddGame(Game game);
        Task<Game> UpdateGame(int id, Game game);
        Task<Game> DeleteGame(int id);
    }
}
