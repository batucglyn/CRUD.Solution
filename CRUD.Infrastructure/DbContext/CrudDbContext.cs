using ContactsManager.Core.Domain.IdentityEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class CrudDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,Guid>
    {
        public CrudDbContext(DbContextOptions options) : base(options)
        {

        }


        virtual public DbSet<Country> Countries { get; set; }
        virtual public DbSet<Person> Persons { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Countries
            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"), CountryName = "Philippines" },
                new Country { CountryId = new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"), CountryName = "Thailand" },
                new Country { CountryId = new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), CountryName = "China" },
                new Country { CountryId = new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"), CountryName = "Palestinian Territory" },
                new Country { CountryId = new Guid("501c6d33-1bbe-45f1-8fbd-2275913c6218"), CountryName = "China" }
            );

            // Seed Persons
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    PersonID = new Guid("c03bbe45-9aeb-4d24-99e0-4743016ffce9"),
                    PersonName = "Marguerite",
                    Email = "mwebsdale0@people.com.cn",
                    DateOfBirth = DateTime.Parse("1989-08-28"),
                    Gender = "Female",
                    CountryID = new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"),
                    Address = "4 Parkside Point",
                    ReceiveNewsLetters = false
                },
                new Person
                {
                    PersonID = new Guid("c3abddbd-cf50-41d2-b6c4-cc7d5a750928"),
                    PersonName = "Ursa",
                    Email = "ushears1@globo.com",
                    DateOfBirth = DateTime.Parse("1990-10-05"),
                    Gender = "Female",
                    CountryID = new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"),
                    Address = "6 Morningstar Circle",
                    ReceiveNewsLetters = false
                },
                new Person
                {
                    PersonID = new Guid("c6d50a47-f7e6-4482-8be0-4ddfc057fa6e"),
                    PersonName = "Franchot",
                    Email = "fbowsher2@howstuffworks.com",
                    DateOfBirth = DateTime.Parse("1995-02-10"),
                    Gender = "Male",
                    CountryID = new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"),
                    Address = "73 Heath Avenue",
                    ReceiveNewsLetters = true
                },
                new Person
                {
                    PersonID = new Guid("d15c6d9f-70b4-48c5-afd3-e71261f1a9be"),
                    PersonName = "Angie",
                    Email = "asarvar3@dropbox.com",
                    DateOfBirth = DateTime.Parse("1987-01-09"),
                    Gender = "Male",
                    CountryID = new Guid("12e15727-d369-49a9-8b13-bc22e9362179"),
                    Address = "83187 Merry Drive",
                    ReceiveNewsLetters = true
                },
                new Person
                {
                    PersonID = new Guid("89e5f445-d89f-4e12-94e0-5ad5b235d704"),
                    PersonName = "Tani",
                    Email = "ttregona4@stumbleupon.com",
                    DateOfBirth = DateTime.Parse("1995-02-11"),
                    Gender = "Gender",
                    CountryID = new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"),
                    Address = "50467 Holy Cross Crossing",
                    ReceiveNewsLetters = false
                },
                new Person
                {
                    PersonID = new Guid("2a6d3738-9def-43ac-9279-0310edc7ceca"),
                    PersonName = "Mitchael",
                    Email = "mlingfoot5@netvibes.com",
                    DateOfBirth = DateTime.Parse("1988-01-04"),
                    Gender = "Male",
                    CountryID = new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"),
                    Address = "97570 Raven Circle",
                    ReceiveNewsLetters = false
                },
                new Person
                {
                    PersonID = new Guid("29339209-63f5-492f-8459-754943c74abf"),
                    PersonName = "Maddy",
                    Email = "mjarrell6@wisc.edu",
                    DateOfBirth = DateTime.Parse("1983-02-16"),
                    Gender = "Male",
                    CountryID = new Guid("12e15727-d369-49a9-8b13-bc22e9362179"),
                    Address = "57449 Brown Way",
                    ReceiveNewsLetters = true
                },
                new Person
                {
                    PersonID = new Guid("ac660a73-b0b7-4340-abc1-a914257a6189"),
                    PersonName = "Pegeen",
                    Email = "pretchford7@virginia.edu",
                    DateOfBirth = DateTime.Parse("1998-12-02"),
                    Gender = "Female",
                    CountryID = new Guid("12e15727-d369-49a9-8b13-bc22e9362179"),
                    Address = "4 Stuart Drive",
                    ReceiveNewsLetters = true
                },
                new Person
                {
                    PersonID = new Guid("012107df-862f-4f16-ba94-e5c16886f005"),
                    PersonName = "Hansiain",
                    Email = "hmosco8@tripod.com",
                    DateOfBirth = DateTime.Parse("1990-09-20"),
                    Gender = "Male",
                    CountryID = new Guid("12e15727-d369-49a9-8b13-bc22e9362179"),
                    Address = "413 Sachtjen Way",
                    ReceiveNewsLetters = true
                },
                new Person
                {
                    PersonID = new Guid("cb035f22-e7cf-4907-bd07-91cfee5240f3"),
                    PersonName = "Lombard",
                    Email = "lwoodwing9@wix.com",
                    DateOfBirth = DateTime.Parse("1997-09-25"),
                    Gender = "Male",
                    CountryID = new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"),
                    Address = "484 Clarendon Court",
                    ReceiveNewsLetters = false
                },
                new Person
                {
                    PersonID = new Guid("28d11936-9466-4a4b-b9c5-2f0a8e0cbde9"),
                    PersonName = "Minta",
                    Email = "mconachya@va.gov",
                    DateOfBirth = DateTime.Parse("1990-05-24"),
                    Gender = "Female",
                    CountryID = new Guid("501c6d33-1bbe-45f1-8fbd-2275913c6218"),
                    Address = "2 Warrior Avenue",
                    ReceiveNewsLetters = true
                },
                new Person
                {
                    PersonID = new Guid("a3b9833b-8a4d-43e9-8690-61e08df81a9a"),
                    PersonName = "Verene",
                    Email = "vklussb@nationalgeographic.com",
                    DateOfBirth = DateTime.Parse("1987-01-19"),
                    Gender = "Female",
                    CountryID = new Guid("501c6d33-1bbe-45f1-8fbd-2275913c6218"),
                    Address = "9334 Fremont Street",
                    ReceiveNewsLetters = true
                }
            );
        }











    }
}
