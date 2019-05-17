namespace HomeWork2019.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(View_1MetaData))]
    public partial class View_1
    {
    }
    
    public partial class View_1MetaData
    {
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 客戶名稱 { get; set; }
        public Nullable<int> 客戶銀行數量 { get; set; }
        public Nullable<int> 客戶聯絡人數量 { get; set; }
    }
}
