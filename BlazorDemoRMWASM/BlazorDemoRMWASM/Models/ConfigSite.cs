﻿using System.ComponentModel.DataAnnotations;

namespace BlazorDemoRMWASM.Models
{
    public class ConfigSite
    {
        public int Id { get; set; }

        [Display(Name = "Thẻ title"), StringLength(200, ErrorMessage = "Tối đa 200 ký tự"), UIHint("TextBox")]
        public string Title { get; set; }

        [Display(Name = "Thẻ description"), StringLength(500, ErrorMessage = "Tối đa 500 ký tự"), UIHint("TextArea")]
        public string Description { get; set; }

        [StringLength(50, ErrorMessage = "Tối đa 50 ký tự"), Display(Name = "Email"), UIHint("TextBox")]
        public string Email { get; set; }

        [Display(Name = "Địa chỉ"), UIHint("TextBox")]
        public string Address { get; set; }

        [Display(Name = "Hotline"), StringLength(50, ErrorMessage = "Tối đa 50 ký tự"), UIHint("TextBox")]
        public string Hotline { get; set; }

        [Display(Name = "Logo"), UIHint("ImageConfig")]
        public string Image { get; set; }

        [Display(Name = "Favicon"), UIHint("ImageConfig")]
        public string Favicon { get; set; }

        [StringLength(500, ErrorMessage = "Tối đa 500 ký tự"), Display(Name = "Đường dẫn Facebook"),
         Url(ErrorMessage = "Đường dẫn không chính xác"), UIHint("TextBox")]
        public string Facebook { get; set; }

        [Display(Name = "Tài khoản Zalo"), StringLength(50, ErrorMessage = "Tối đa 50 ký tự"), UIHint("TextBox")]
        public string Zalo { get; set; }

        [Display(Name = "Thông tin chân trang"), UIHint("EditorBox")]
        public string InfoFooter { get; set; }

        [StringLength(4000, ErrorMessage = "Tối đa 4000 ký tự"), Display(Name = "Mã Google Map"), UIHint("TextArea")]
        public string GoogleMap { get; set; }

        [StringLength(4000, ErrorMessage = "Tối đa 4000 ký tự"), Display(Name = "Mã Google Analytics"), UIHint("TextArea")]
        public string GoogleAnalytics { get; set; }


    }
}
