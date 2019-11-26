using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MODTechnologyService.Context;
using MODTechnologyService.Models;
using MODTechnologyService.Repositories;

namespace MODTechnologyService.Repositories
{
     public interface ITechnologyRepository
    {
        List<Technology> GetAllTechnology();
        void AddTechnology(Technology item);

        void UpdateTechnology(Technology item);
        void DeleteTechnology(int id);

    }
}
