//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp4
{
    using System;
    using System.Collections.Generic;
    
    public partial class patientResultValue
    {
        public int resultID { get; set; }
        public Nullable<int> testID { get; set; }
        public Nullable<int> patient_id { get; set; }
        public Nullable<int> patient_test_id { get; set; }
        public string ResultValue { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual Patient_Test Patient_Test { get; set; }
        public virtual Sub_Test Sub_Test { get; set; }
    }
}
