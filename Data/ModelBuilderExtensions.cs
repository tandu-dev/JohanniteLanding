using JohanniteLanding.Models;
using Microsoft.EntityFrameworkCore;

namespace JohanniteLanding.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Link>().HasData(
                new Link {
                    LinkId = 1,
                    Href = "https://office.johannite.tech",
                    displayName = "Divine Office of the Apostolic Johannite Church",
                    Active = true

                },
                new Link {
                    LinkId = 2,
                    Href = "https://lectionary.johannite.tech",
                    displayName = "The Lectionary of the Apostolic Johannite Church",
                    Active = false

                },
                new Link {
                    LinkId =3,
                    Href = "https://johannite.org",
                    displayName = "The Apostolic Johannite Church",
                    Active = true
                }
            );
            return modelBuilder;
        }
    }
}