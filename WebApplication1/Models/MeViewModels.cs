using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    // 由 MeController 動作傳回的模型。
    public class GetViewModel
    {
        public string Hometown { get; set; }
    }
}