using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullancı güncellendi";

        public static string UserRegister = "Kullanıcı başarıyla kaydoldu";
        public static string AuthorizationDenied="Erişim reddedildi";
        public static string UserRegistered ="Kayıt başarılı";
        public static string UserNotFound ="Kullanıcı bulunamadı";
        public static string PasswordError="Hatalı şifre";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists="Kayıtlı kullanıcı mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
        public static string MaintanceTime="Bakım zamanı";
    }
}
