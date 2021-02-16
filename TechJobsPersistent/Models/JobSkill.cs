﻿using System;
namespace TechJobsPersistent.Models
{
    public class JobSkill
    {
        public int JobId { get; set; }
        public Job Job { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        public JobSkill(){}

        public JobSkill(Job job, int skillId) 
        {
            this.Job = job;
            this.SkillId = skillId;
        }
    }
}