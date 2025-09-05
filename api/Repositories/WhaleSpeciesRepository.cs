// using Microsoft.EntityFrameworkCore;
// using ClassroomHelperBackend.Database;
// using ClassroomHelperBackend.Models;

// namespace ClassroomHelperBackend.Repositories
// {
//     public interface IWhaleSpeciesRepository
//     {
//         Task<IEnumerable<WhaleSpecies>> GetWhaleSpecies();
//         WhaleSpecies GetWhaleSpeciesById(int newSpeciesId);
//         Task<WhaleSpecies> GetWhaleSpeciesByName(string speciesName);

//     }

//     public class WhaleSpeciesRepository : IWhaleSpeciesRepository
//     {
//     private readonly ClassroomHelperDbContext _context;

//     public WhaleSpeciesRepository(ClassroomHelperDbContext context)
//         {
//             _context = context;
//         }

//         public async Task<IEnumerable<WhaleSpecies>> GetWhaleSpecies()
//         {
//             return await _context.ClassroomHelperSpecies.ToListAsync();
//         }

//         public WhaleSpecies GetWhaleSpeciesById(int newSpeciesId)
//         {
//             var whale = _context.ClassroomHelperSpecies
//                                     .FirstOrDefault(whale => whale.Id == newSpeciesId);
//             if (whale == null)
//             {
//                 throw new Exceptions.NotFoundException($"Whale with {newSpeciesId} id not found");
//             }
//             return whale;
//         }

//         public async Task<WhaleSpecies> GetWhaleSpeciesByName(string speciesName)
//         {
//             var whale = await _context.ClassroomHelperSpecies
//                                     .FirstOrDefaultAsync(whale => whale.Species == speciesName);
//             if (whale == null)
//             {
//                 throw new Exceptions.NotFoundException($"Whale with {speciesName} speciesName not found");
//             }
//             return whale;
//         }
//     };
// }
