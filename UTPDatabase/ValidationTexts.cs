using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UTPDatabase
{
    public class ValidationTexts
    {
        [Key]
        public int ID { get; set; }
        public string PageName { get; set; }
        public string IntendedText { get; set; }
        public DateTime AddedDate { get; set; }

    }
}
