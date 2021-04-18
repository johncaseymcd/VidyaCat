using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static VidyaCat.Data.ApplicationDbContext;

namespace VidyaCat.MVC.Models
{
    public class RoleViewModel
    {
        public RoleViewModel() { }
        public RoleViewModel(ApplicationRole role)
        {
            ID = role.Id;
            Name = role.Name;
        }

        public string ID { get; set; }
        public string Name { get; set; }
    }
}