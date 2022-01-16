using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Model
{
    [Table("CustomerAttributeModel")]
    public class CustomerAttributeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Attribute Master is required!")]
        [StringLength(50)]
        [Display(Name = "Attribute Master")]
        public string AttributeMaster { get; set; }

        [Required(ErrorMessage = "Attribute Valaue Code is required!")]
        [StringLength(2)]
        [Display(Name = "Attribute Valaue Code")]
        public string AttributeValuesCode { get; set; }

        [Required(ErrorMessage = "Description is required!")]
        [StringLength(80)]
        public string Description { get; set; }

        [Required(ErrorMessage = "ShortName is required!")]
        [StringLength(40)]
        [Display(Name = "Short Name")]
        public string ShortName { get; set; }


        [StringLength(50)]
        public string Parent { get; set; }

        public DateTime EffectiveDate { get; set; }
        public DateTime ValidUntil { get; set; }
    }
}
