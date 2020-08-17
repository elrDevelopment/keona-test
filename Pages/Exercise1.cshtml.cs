using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication.DataAccess;
using WebApplication.Models;
using System.Text.Json;

namespace WebApplication.Pages
{
    public class Exercise1 : PageModel
    {
        private keonaContext _CONTEXT;
        public IList<PersonLastOrderDTO> personOrderList;
       
        public Exercise1(keonaContext context)
        {
            _CONTEXT = context;
           
        }
        public void OnGet()
        {
            var sql = _CONTEXT.JsonReturn.FromSqlRaw("EXEC GetPersonLastOrderDate").AsEnumerable();
            personOrderList = new List<PersonLastOrderDTO>();
            personOrderList = JsonSerializer.Deserialize<IList<PersonLastOrderDTO>>(sql.FirstOrDefault().ReturnValue);
        }

      
    }
}