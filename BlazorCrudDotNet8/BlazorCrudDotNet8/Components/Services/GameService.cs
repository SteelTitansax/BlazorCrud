using BlazorCrudDotNet8.Components.Data;
using BlazorCrudDotNet8.Components.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Components.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _context;
        public GameService(DataContext context) 
        {

            _context = context;
             
        }

      
        public async Task<Game> AddGame(Game game)
        {
                _context.Games.Add(game);
            await _context.SaveChangesAsync();
            return game;
        }
        public async Task<Game> UpdateGame(int id , Game game)
        {
            var dbGame = await _context.Games.FindAsync(id);
            if(dbGame != null) 
            {
                dbGame.Name = game.Name; 
                await _context.SaveChangesAsync();
                return dbGame;
            }
            else
            {
                throw new Exception("Game not found");
            }

            

            
        }

        public async Task<Game> DeleteGame(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game != null)
            {
                _context.Games.Remove(game);
                await _context.SaveChangesAsync();
            }
            return game;
        }
        public async Task<List<Game>> GetAllGames()
        {
            await Task.Delay(1000);

            var games =  await _context.Games.ToListAsync();
            
            return games;
        }
        public async Task<Game> GetGameById(int id)
        {
           var game = await _context.Games.FindAsync(id);
            return game;
        }

    }
}
