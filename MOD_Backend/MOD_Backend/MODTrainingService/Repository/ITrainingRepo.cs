using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MODTrainingService.Context;
using MODTrainingService.Models;

namespace MODTrainingService.Repository
{
   public  interface ITrainingRepo
    {
        List<Training> GetAllTraining();
        Training GetTrainingById(int Id);
        void AddTraining(Training item);
        void UpdateTraining(Training item);
        void DeleteTraining(int id);
        List<Training> GetTrainingByUserId(int Id);

        List<Training> GetTrainingByMentorId(int Id);
    }
}
