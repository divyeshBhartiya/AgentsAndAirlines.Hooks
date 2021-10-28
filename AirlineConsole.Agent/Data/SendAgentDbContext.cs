using AirlineAgentConsole.Models;
using Microsoft.EntityFrameworkCore;

namespace AirlineAgentConsole.Data
{
    public class SendAgentDbContext : DbContext
    {
        public SendAgentDbContext(DbContextOptions<SendAgentDbContext> opt) : base(opt) { }
        public DbSet<WebhookSubscription> WebhookSubscriptions { get; set; }
    }
}
