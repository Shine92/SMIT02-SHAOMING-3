//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoundCity_V2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        public int Id { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserGender { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Telephone { get; set; }
        public string AuthCode { get; set; }
        public bool IsAdmin { get; set; }
        public bool UserStatus { get; set; }
    }
}
