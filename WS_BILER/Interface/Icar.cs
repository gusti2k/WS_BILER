using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WS_BILER.Models;

namespace WS_BILER.Interface
{
    public interface ICar
    {
         void StartScrapping();
         void DeleteAll();
        ICollection<SearchMenu> GetSearchMenu();

    }
}
