using Microsoft.EntityFrameworkCore;
using Notes.Aplication.intefaces;
using Notes.Domain;
using Notes.Persistance.EntityTypeConfigurations;
using System;
 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Persistance
{
    public class NotesDbContext : DbContext, INoteDbContext
    {

        public DbSet<Note> Notes { get; set; }
        public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(builder);
        }

    }
    
}
