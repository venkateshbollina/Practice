﻿using System.ComponentModel.DataAnnotations;

namespace Magicvilla_VillaApi.VillaDTo
{
    public class VillaDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]

        public string Name { get; set; }
        //public DateTime CreatedDate { get; set; }

    }
}
