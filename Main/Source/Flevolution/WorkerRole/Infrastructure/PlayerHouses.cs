//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkerRole.Infrastructure
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlayerHouses
    {
        public int Id { get; set; }
        public int NoOfHouses { get; set; }
    
        public virtual Player Player { get; set; }
        public virtual Area Area { get; set; }
        public virtual Session Session { get; set; }
    }
}