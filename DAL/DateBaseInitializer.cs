using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entities;

namespace DAL
{
    class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var qualifications = new List<Qualification>
                {
                    new Qualification() {QualificationId = 1, QualificationName = "Junior Developer"},
                    new Qualification() {QualificationId = 2, QualificationName = "Midle"}
                };


            var coach = new User()
                {
                    FirstName = "Valera",
                    LastName = "Alexandrov",
                    Password = "rrr",
                    Login = "Alexander1",
                    Qualification = qualifications[1],
                    PhotoPath = "zsf",
                    CareerGrowthDayDate = new DateTime(2012, 1, 1)
                };
            var resourceManager = new User()
            {
                FirstName = "Lol",
                LastName = "Alexandrov",
                Password = "rrr",
                Login = "Alexander2",
                Qualification = qualifications[1],
                PhotoPath = "zsf1",
                CareerGrowthDayDate = new DateTime(2012, 2, 1)
            };

            context.Users.Add(resourceManager);
            context.Users.Add(coach);

            new List<User>
            {
                new User() {FirstName = "Ivan", LastName = "Ivanov", Password = "123456", Login = "Ivan", Qualification = qualifications[0], Coach =  coach, ResourceManager = resourceManager, PhotoPath = "qq", CareerGrowthDayDate = new DateTime(2012,12,1)},
                new User() {FirstName = "Anton", LastName = "Gavrilchik", Password = "111111" , Login = "Anton", Qualification = qualifications[1], Coach =  coach, ResourceManager = resourceManager, PhotoPath = "asdf", CareerGrowthDayDate = new DateTime(2011,12,1)},
                new User() {FirstName = "Alexander", LastName = "Alexandrov", Password = "rrr", Login = "Alexander", Qualification = qualifications[0], Coach =  coach, ResourceManager = resourceManager, PhotoPath = "zsdf", CareerGrowthDayDate = new DateTime(2002,12,1)}
            }.ForEach(a => context.Users.Add(a));

            context.SaveChanges();
        }
    }
}
