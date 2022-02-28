using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitys;

namespace DataAcces
{
    public class ApiDisneyContext : DbContext
    {

        public DbSet<Characters> TCharacter { set; get; }

        public DbSet<Movie> TMovie { set; get; }

        public DbSet<Gender> TGender { set; get; }

        public DbSet<User> TUser { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Data Source=.;Initial Catalog=Dbapidisney;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            model.Entity<Characters>().HasData(
                new Characters() { IdCharacters="0A1S2D",Name= " Snow white",
                    Age=25,Weight=50,
                    History= "Once upon a time, a king and a queen had a baby daughter, and when she saw her black hair," +
                    " snowy white skin and red red lips she decided to call her Snow White. Snow White grew up to be a pretty child, but sadly, after a few years, " +
                    "her mother died and her father married again. The new queen, Snow White's stepmother, was a beautiful woman too, but she was very vain." +
                    " More than anything else she wanted to be certain that she was the most beautiful woman in the world."
                }

                );
            model.Entity<Movie>().HasData(

                new Movie() {IdMovie="8G3H4K",Title= " SNOW WHITE AND THE HUNTER",Date="1923/21/12",Qualification=4,
                    History= "Eric es un cazador cuya mujer fue asesinada mientras él estaba luchando en una guerra. " +
                "Después de que Blancanieves escapa al Bosque Oscuro, la Reina Ravenna y su hermano Finn contratan a Eric para que capture a Blancanieves" +
                ", prometiéndole que devolvería a su mujer a la vida." }
                
                );

            model.Entity<Gender>().HasData(

                new Gender() { IdGender="9V6O7T",Name="Action"}
                
                );
        }
       



    }
}
