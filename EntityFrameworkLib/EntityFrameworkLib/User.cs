//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UsersId { get; set; }
        public string Logon { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }
        public string Phone { get; set; }
        public Nullable<short> BatchSize { get; set; }
        public Nullable<System.DateTime> Expiry { get; set; }
        public byte Active { get; set; }
        public string Comment { get; set; }
        public System.DateTime LastModified { get; set; }
        public int ModifiedBy { get; set; }
        public bool STPUW { get; set; }
        public bool RNLUW { get; set; }
        public string Position { get; set; }
    }
}