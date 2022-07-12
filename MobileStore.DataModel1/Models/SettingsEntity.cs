using MobileStore.DataModelLayer.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.DataModelLayer.Models
{
    public class SettingsEntity
    {
        [Key]
        public int Settings_Id { get; set; }

        public string Settings_SiteName { get; set; }

        public string Settings_About { get; set; }

        public string Settings_Tel { get; set; }

        public string Settings_Fax { get; set; }

        public string Settings_Email { get; set; }

        public string Settings_Address { get; set; }

        public string Settings_MetaKeyword { get; set; }

        public string Settings_Description { get; set; }
    }
}
