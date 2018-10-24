using System;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Product
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Required]
        public int Price { get; set; }

        private const int V = 100;

        [Required]
        public double Vat;

        public Product(string name, string description, DateTime startDate, DateTime endDate, int price)
        {
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
        }

        public Product()
        {
            throw new NotImplementedException();
        }

        public bool IsValid(DateTime startDate, DateTime endDate)
        {
            return startDate <= endDate;
        }

        public double ComputeVat(int price)
        {
            if (price < 100)
            {
                var v = 9 * price;
                return Vat = v / V;
            }
            var v1 = price * 14;
            return Vat = v1 / V;
        }
    }
}

