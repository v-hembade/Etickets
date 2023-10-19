using E_ticket.Data.Base;
using E_ticket.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Mime;

namespace E_ticket.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }

        
    }
}
