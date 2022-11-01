using DernekOtomasyon.DATA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyon.DATA.Entity
{
    public class Member : BaseEntity
    {
        public string  Username { get; set; } //giriş yapacağı kullanıcı adı
        public string  UniqueKey { get; set; } //2fa doğrulama için gerekli key alanı
        public string  Password { get; set; }  
        public string  Showname { get; set; } //email
        public int  Status { get; set; } //durumu

        /*
         * 0 -> Kullanıcı Onay bekliyor
         * 1 -> Kullanıcı Onaylı
         * 2 -> Kullanıcı yasaklı
         */
    }
}
