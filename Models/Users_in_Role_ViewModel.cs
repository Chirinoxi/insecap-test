﻿namespace SGC.Models
{
    public class Users_in_Role_ViewModel
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public TipoUsuario Tipo { get; set; }
    }
}