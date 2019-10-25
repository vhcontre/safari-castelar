using Safari.Entities;
using Safari.Services.Contracts;
using Safari.UI.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vitruvio.UI.Process
{
    public class EspecieProcess : ProcessComponent
    {
        
        public IList<Especie> ToList()
        {
            var response = HttpGet<ListarTodosEspecieResponse>("api/Especie/ListarTodos", new Dictionary<string, object>(), MediaType.Json);
            return response.Result;
        }
    }

}
