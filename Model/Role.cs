//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Course.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role
    {
        public int RoleID { get; set; }
        public string Title { get; set; }
    
        public virtual User User { get; set; }
    }
}
