using MyGitProj.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyGitProj.ViewModels
{
    public class MrUserRegViewModel
    {
        public int RegId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string Address { get; set; }
        public string PhomeNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ZipCode { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public virtual Citie_table Citie_table { get; set; }
        public virtual State_table State_table { get; set; }

    }
}