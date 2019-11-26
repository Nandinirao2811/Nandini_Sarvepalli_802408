using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MODTrainingService.Models;
using MODTrainingService.Context;

namespace MODTrainingService.Repository
{
    public class TrainingRepo :ITrainingRepo
    {
        private readonly TrainingContext _context;
        public TrainingRepo(TrainingContext context)
        {
            _context = context;
        }

        public void AddTraining(Training item)
        {
            try
            {
                _context.Trainings.Add(item);
                _context.SaveChanges();
            }
           
               catch (Exception)
            {
                throw;
            }

        }

        public void DeleteTraining(int id)
        {
            try
            {
                var item = _context.Trainings.Find(id);
                _context.Trainings.Remove(item);
                _context.SaveChanges();
            }
           
             catch (Exception)
            {
                throw;
            }
        }

        public List<Training> GetAllTraining()
        {
            try
            {
                return _context.Trainings.ToList();
            }
          
            catch (Exception)
            {
                throw;
            }
        }

        public Training GetTrainingById(int Id)
        {
            try
            {
                return _context.Trainings.Find(Id);
            }
           
             catch (Exception)
            {
                throw;
            }
        }

        public List<Training> GetTrainingByMentorId(int Id)
        {
            try
            {
                return _context.Trainings.Where(i => i.Mentor_Id == Id).ToList();
            }
         
             catch (Exception)
            {
                throw;
            }
        }

        public List<Training> GetTrainingByUserId(int Id)
        {
            try
            {
                return _context.Trainings.Where(i => i.User_Id == Id).ToList();
            }
           
             catch (Exception)
            {
                throw;
            }
        }

        public void UpdateTraining(Training item)
        {
            try
            {
                _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
           
             catch (Exception)
            {
                throw;
            }
        }
    }
}
