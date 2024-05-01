﻿using System.ComponentModel.DataAnnotations;

namespace Client.Layer.Dtos.Incoming
{
    public class InSupplierDto
    {
        [Required(ErrorMessage = "The {0} field must be provided. (Obrigatório!)")]
        [StringLength(100, ErrorMessage = "The {0} field must be between {2} and {1} characters. (Inválido!)", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The {0} field must be provided. (Obrigatório!)")]
        [StringLength(14, ErrorMessage = "The {0} field must be between {2} and {1} characters. (Inválido!)", MinimumLength = 11)]
        public string Document { get; set; }

        [Range(1, 2, ErrorMessage = "Please enter {1} to Individual or {2} to Corporation.")]
        public int SupplierType { get; set; }

        [Required(ErrorMessage = "The {0} field must be provided. (Obrigatório!)")]
        public InAddressDto Address { get; set; }

        public bool Active { get; set; }

        public IEnumerable<InProductDto> Products { get; set; }
    }
}
