//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OlympMotors.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int Id_Ticket { get; set; }
        public int Id_Flight { get; set; }
        public string Id_User { get; set; }
        public string StatusTicket { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Flight Flight { get; set; }
    }
}
