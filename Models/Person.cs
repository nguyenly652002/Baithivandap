using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenThiKhanhLy_424
{
    [Table("Lophocs")]
    public class Lophoc 
    {
        
        [Key]
        public string? MaLop { get; set; }

        public int TenLop { get; set; }

        public string? SoTT { get; set; }

        

    }
}