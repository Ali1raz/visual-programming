using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGameApi.Data;

namespace VideoGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController(VideoGameDBcontext context) : ControllerBase
    {
        private readonly VideoGameDBcontext _context = context;

        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetVideoGames() {
            return Ok(await _context.VideoGames.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetVideoGameById(int id)
        {
            var game = await _context.VideoGames.FindAsync(id);
            if (game is null)
                return NotFound();
            return Ok(game);
        }

        [HttpPost]
        public async Task<ActionResult<VideoGame>> AddVideoGame(VideoGame newVideoGame)
        {
            if (newVideoGame is null)
                return BadRequest();

            _context.VideoGames.Add(newVideoGame);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetVideoGameById),
                new { id = newVideoGame.Id }, newVideoGame);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVideoGame(int id, VideoGame updatedVideoGame)
        {
            var game = await _context.VideoGames.FindAsync(id);
            if (game is null)
                return NotFound();

            game.Title = updatedVideoGame.Title;
            game.Publisher = updatedVideoGame.Publisher;
            game.Developer = updatedVideoGame.Developer;
            game.Platform = updatedVideoGame.Platform;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVideoGame(int id)
        {
            var game = await _context.VideoGames.FindAsync(id);

            if (game is null)
                return NotFound();
            _context.VideoGames.Remove(game);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
