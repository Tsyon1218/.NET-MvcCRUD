//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCCRUD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CourseCode { get; set; }
        public string Course_Title { get; set; }
        public Nullable<int> Credit { get; set; }
        public string Grade { get; set; }
    }
}