﻿using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core
{
    public class WorkOutPlan : ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfDays { get; set; }
        public FitnessLevel DifficultyLevel { get; set; }
        //public DateOnly StartDate { get; set; }
        //public DateOnly EndDate { get; set; }
        [JsonIgnore]
        public ICollection<WorkOutExercises> workOutExercises { get; set; } = new HashSet<WorkOutExercises>();
    }
}
