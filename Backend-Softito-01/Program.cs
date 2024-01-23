//using Backend_Softito_01.DataLayer;

//AppDbContext db = new();
//db.Users.Add(new Backend_Softito_01.Entity.User()
//{
//    FirstName = "Hasan Ali",
//    LastName = "Kart",
//    UserName = "hasanali",
//    Password = "12345",
//    IsActive = true,
//    IdentificationNumber = "11223344551"
//});

//db.SaveChanges();

using System;
using System.Collections.Generic;
using Backend_Softito_01.DataLayer;
using Bogus;
using Bogus.Extensions.UnitedStates;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        //var userList = new List<Backend_Softito_01.Entity.User>();
        var faker = new Faker<Backend_Softito_01.Entity.User>()
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.UserName, f => f.Person.UserName)
            .RuleFor(u => u.Password, f => f.Internet.Password())
            .RuleFor(u => u.IsActive, f => true)
            .RuleFor(u => u.IdentificationNumber, f => f.Person.Ssn());

        //for (int i = 0; i < 99; i++)
        //{
        //     userList.Add(faker.Generate());
        //}

        // Elde edilen veri listesini kullanabilirsiniz (örneğin, veritabanına eklemek)
        // db.Users.AddRange(userList);

        // Örnek olarak, oluşturulan verileri ekrana yazdıralım
        //foreach (var user in userList)
        //{
        //    Console.WriteLine($"User: {user.FirstName} {user.LastName}, UserName: {user.UserName}, IdentificationNumber: {user.IdentificationNumber}");
        //}
        //AppDbContext.Users.AddRange(userList)

        //AppDbContext.Users.AddRange(userList);
        //context.SaveChanges();
        using(var context = new AppDbContext())
        {
            context.Users.AddRange(faker.Generate(99));
            context.SaveChanges();
        }
    }
}
