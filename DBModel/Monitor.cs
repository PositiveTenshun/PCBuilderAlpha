//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Monitor : Component
    {
        public int MonitorId { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Latency { get; set; }
        public string HasSpeakers { get; set; }
    }
}