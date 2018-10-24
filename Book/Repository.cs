using System;

namespace Data
{
    public class Repository
    {
        public void Add()
        {
            using (var db = new ProductManagement())
            {
                db.Customers.Add(new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Gigel",
                    Address = "acasa",
                    PhoneNumber = "0754353",
                    Email = "mail@mail.com"
                });
                db.Products.Add(new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Maria",
                    Description = "theBest",
                    StartDate = new DateTime(1998, 05, 19),
                    EndDate = new DateTime(2008, 05, 19)
                });
                var saveChanges = db.SaveChanges();
                Console.WriteLine($"{saveChanges} recorded have been added");
            }

        }
    }
}
