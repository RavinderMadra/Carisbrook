
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Demo.Core.EntityModel
{

using System;
    using System.Collections.Generic;
    
public partial class tblGallery
{

    public long id { get; set; }

    public string GalleryName { get; set; }

    public string GalleryPath { get; set; }

    public long TypeId { get; set; }

    public bool IsActive { get; set; }

    public System.DateTime CreatedDate { get; set; }

    public System.DateTime ModifiedDate { get; set; }

    public string CreatedBy { get; set; }

    public string ModifiedBy { get; set; }

}

}
