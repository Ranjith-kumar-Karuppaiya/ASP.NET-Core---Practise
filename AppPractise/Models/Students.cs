using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPractise.Models
{
    public class Students
    {

        [Key]
        public int rollNo { get; set; }
        [Column(TypeName ="nvarchar(20)")]
        public string studentName { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string DOB { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string cityName { get; set; }

    }
}
