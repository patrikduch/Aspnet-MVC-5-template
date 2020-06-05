using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspnetMvc5.Core.Interfaces.Facades;
using AspnetMvc5.Core.Models;

namespace AspnetMVC5.Infrastructure.Facades
{
    public class PersonFacade : IPersonFacade
    {
        public List<Person> GetAllPersons()
        {
            return new List<Person>()
            {
                new Person()
                {
                    Id = 1,
                    FirstName = "Patrik",
                    LastName = "Duch"

                }
            };
        }
    }
}
