using MvcCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dapper;

namespace MvcCrud.Data
{
    public class MovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Movie>> GetAll()
        {
            return await _context.Movies.OrderBy(m => m.Title).ToListAsync();
        }

        public async Task<Movie> GetById(int id)
        {
            var sql = "select * from Movies where Id = @Id";

            var parameters = new DynamicParameters();
            parameters.Add("Id", id);

            return await _context.Database.GetDbConnection()
                .QuerySingleOrDefaultAsync<Movie>(sql, parameters);
        }
    }
}
