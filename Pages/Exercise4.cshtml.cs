using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using WebApplication.DataAccess;
using WebApplication.Models;

namespace WebApplication.Pages
{
    public class Exercise4 : PageModel
    {
        private keonaContext _CONTEXT;
        public ICollection<PersonDTO> personsOrders;
        public ICollection<string> availableDates;
        private IMapper _MAPPER;
        public Exercise4(keonaContext context, IMapper mapper)
        {
            _CONTEXT = context;
            _MAPPER = mapper;
        }
        public async Task OnGet()
        {
            var dateStrings = await _CONTEXT.Orders.OrderBy(o=>o.OrderDateTime).Select(s => ((DateTime) s.OrderDateTime).ToShortDateString()).ToListAsync();
            availableDates = dateStrings.Distinct().ToList();
            await GetOrdersForPerson("2020-07-02");
            Console.WriteLine(availableDates);
        }

        public async Task GetOrdersForPerson(string orderDateTime)
        {
            try
            {
                var dateParam = orderDateTime;
                var sql = $"EXEC GetPersonByOrderDate '{dateParam}'";
                var personsFromDB = await _CONTEXT.Person.FromSqlRaw(sql).ToListAsync();
                personsOrders = _MAPPER.Map<ICollection<PersonDTO>>(personsFromDB);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                var error = new List<PersonDTO>();
                error.Add(new PersonDTO()
                {
                    PersonId = -1,
                    NameFirst = "No Data or Error",
                    NameLast = "No Data or Error"
                });
                personsOrders = error;
                throw;
            }
        }

     
    }
}