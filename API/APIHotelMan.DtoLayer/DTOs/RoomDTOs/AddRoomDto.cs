using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.DtoLayer.DTOs.RoomDTOs
{
    public class AddRoomDto
    {
        [Required(ErrorMessage = "Oda numarası boş geçilemez!")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Oda resmi boş geçilemez!")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Fiyat boş geçilemez!")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Başlık boş geçilemez!")]
        [MaxLength(50, ErrorMessage = "Başlık en fazla 50 karakter olabilir!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Yatak sayısı boş geçilemez!")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Banyo sayısı boş geçilemez!")]
        public string BathCount { get; set; }

        [Required(ErrorMessage = "Wifi durumu boş geçilemez!")]
        public string Wifi { get; set; }

        [Required(ErrorMessage = "Açıklama boş geçilemez!")]
        [MaxLength(500, ErrorMessage = "Açıklama en fazla 500 karakter olabilir!")]
        public string Description { get; set; }
    }
}
