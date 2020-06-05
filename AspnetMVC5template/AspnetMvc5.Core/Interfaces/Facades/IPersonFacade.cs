using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspnetMvc5.Core.Models;

namespace AspnetMvc5.Core.Interfaces.Facades
{
    public interface IPersonFacade
    {

        List<Person> GetAllPersons();

    }
}
