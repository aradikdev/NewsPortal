﻿using System.ComponentModel.DataAnnotations;

namespace NewsPortal.ViewModels;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Не указан Email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Не указан пароль")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Пароли не совпадают")]
    public string ConfirmPassword { get; set; }

}