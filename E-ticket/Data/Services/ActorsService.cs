﻿using E_ticket.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Mime;

namespace E_ticket.Data.Services
{
    public class ActorsService : IActorsService
    {
        public readonly AppDbContext _context;
        public ActorsService(AppDbContext context) 
        {  
            _context = context; 
        }

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}
