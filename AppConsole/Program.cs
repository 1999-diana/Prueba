using Modelo.Entidades;
using System;

namespace AppConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rental rental1 = new Rental()
            {
                rental_date = new DateTime(2021, 11, 01, 8, 03, 02),
                inventory_id=1,
                return_date= new DateTime(2021, 11, 01, 8, 03, 02),
                staff_id = 1,
                last_update = new DateTime(2021, 11, 01, 8, 03, 02),
            };
            Rental rental2 = new Rental()
            {
                rental_date = new DateTime(2021, 11, 01, 8, 03, 02),
                inventory_id = 8,
                return_date = new DateTime(2021, 11, 01, 8, 03, 02),
                staff_id = 8,
                last_update = new DateTime(2021, 11, 01, 8, 03, 02),
            };
            Rental rental3 = new Rental()
            {
                rental_date = new DateTime(2021, 11, 01, 8, 03, 02),
                inventory_id = 7,
                return_date = new DateTime(2021, 11, 01, 8, 03, 02),
                staff_id = 7,
                last_update = new DateTime(2021, 11, 01, 8, 03, 02),
            };
            Rental rental4 = new Rental()
            {
                rental_date = new DateTime(2021, 11, 01, 8, 03, 02),
                inventory_id = 6,
                return_date = new DateTime(2021, 11, 01, 8, 03, 02),
                staff_id = 6,
                last_update = new DateTime(2021, 11, 01, 8, 03, 02),
            };
            Rental rental5 = new Rental()
            {
                rental_date = new DateTime(2021, 11, 01, 8, 03, 02),
                inventory_id = 5,
                return_date = new DateTime(2021, 11, 01, 8, 03, 02),
                staff_id = 5,
                last_update = new DateTime(2021, 11, 01, 8, 03, 02),
            };
            Rental rental6 = new Rental()
            {
                rental_date = new DateTime(2021, 11, 01, 8, 03, 02),
                inventory_id = 4,
                return_date = new DateTime(2021, 11, 01, 8, 03, 02),
                staff_id = 4,
                last_update = new DateTime(2021, 11, 01, 8, 03, 02),
            };
            Rental rental7 = new Rental()
            {
                rental_date = new DateTime(2021, 11, 01, 8, 03, 02),
                inventory_id = 3,
                return_date = new DateTime(2021, 11, 01, 8, 03, 02),
                staff_id = 3,
                last_update = new DateTime(2021, 11, 01, 8, 03, 02),
            };
            Rental rental8 = new Rental()
            {
                rental_date = new DateTime(2021, 11, 01, 8, 03, 02),
                inventory_id = 2,
                return_date = new DateTime(2021, 11, 01, 8, 03, 02),
                staff_id = 2,
                last_update = new DateTime(2021, 11, 01, 8, 03, 02),
            };
            //Clientes
            Customer customer1 = new Customer()
            {
                store_id = 1,
                first_name = "Jose",
                last_name = "Alban",
                email = "alban12@gamil.com",
                address_id = 1,
                activebool = "true",
                create_date = new DateTime(2021, 11, 01, 8, 03, 02),
                last_update = new DateTime(2021, 11, 01, 8, 03, 02),
                active = 1
            };
            Customer customer12 = new Customer()
            {
                store_id = 1,
                first_name = "Dilan",
                last_name = "Leon",
                email = "alban12@gamil.com",
                address_id = 1,
                activebool = "true",
                create_date = new DateTime(2021, 11, 01, 8, 03, 02),
                last_update = new DateTime(2021, 11, 01, 8, 03, 02),
                active = 1
            };
            Customer customer3 = new Customer()
            {
                store_id = 1,
                first_name = "Andres",
                last_name = "Alban",
                email = "alban12@gamil.com",
                address_id = 1,
                activebool = "true",
                create_date = new DateTime(2021, 11, 01, 8, 03, 02),
                last_update = new DateTime(2021, 11, 01, 8, 03, 02),
                active = 1
            };
            Customer customer4 = new Customer()
            {
                store_id = 1,
                first_name = "Jose",
                last_name = "Alban",
                email = "alban12@gamil.com",
                address_id = 1,
                activebool = "true",
                create_date = new DateTime(2021, 11, 01, 8, 03, 02),
                last_update = new DateTime(2021, 11, 01, 8, 03, 02),
                active = 1
            };
           
        }
    }
}
