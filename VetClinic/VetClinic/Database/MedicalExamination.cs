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
    
    public partial class MedicalExamination
    {
        public int IdMedicalExamination { get; set; }
        public int IdMedicalCard { get; set; }
        public Nullable<int> IdDiagnosis { get; set; }
        public Nullable<int> IdProcedure { get; set; }
        public int IdCabinet { get; set; }
        public int IdStaff { get; set; }
    
        public virtual Cabinet Cabinet { get; set; }
        public virtual Diagnosis Diagnosis { get; set; }
        public virtual MedicalCard MedicalCard { get; set; }
        public virtual Procedure Procedure { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
