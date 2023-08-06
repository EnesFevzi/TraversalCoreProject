using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalProject.DtoLayer.Dtos.RegisterDto
{
	public class CreateUserDto
	{
		[Required(ErrorMessage = "Ad Alanı Gereklidir")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Soyad Alanı Gereklidir")]
		public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı Alanı Gereklidir")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Mail Alanı Gereklidir")]
		public string EMail { get; set; }

		[Required(ErrorMessage = "Şifre Alanı Gereklidir")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Şifre Tekrar Alanı Gereklidir")]
		[Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
		public string ConfirmPassword { get; set; }

		

	}
}
