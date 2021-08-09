using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "This field is required.")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "This field is required.")]
        public Employer Employer { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int EmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            Skills = skills;
            Employers = new List<SelectListItem>();

            foreach (var i in employers)
            {
                Employers.Add(
                    new SelectListItem
                    {
                        Value = i.Id.ToString(),
                        Text = i.Name
                    }
                    );
            }
        }

        public AddJobViewModel() { }


        public int SkillId { get; set; }

        public List<Skill> Skills { get; set; }





    }
}
