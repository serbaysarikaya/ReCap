﻿using Core.Entities;

namespace Entities.DTOs
{
    public class UserDto : IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] Passwordhash { get; set; }//veri tabanında güvenlik açısından kullanıcı şifrelerini byte olarak ve has'leyerek koyuyorum
        public byte[] PasswordSalt { get; set; }//şifre hash'lerken kendim tuzlama yapıyorum, tekrar şifreyi verify edeceğim zaman bu salt değerine ihtiyacım var.
        public bool Status { get; set; }
    }
}
