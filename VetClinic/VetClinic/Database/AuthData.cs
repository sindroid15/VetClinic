//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VetClinic.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class AuthData
    {
        public int IdAuth { get; set; }
        public int IdStaff { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    
        public virtual Staff Staff { get; set; }
    }
}