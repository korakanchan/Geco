// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable UnusedMember.Global
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Geco.Tests.Database.Model
{
    [GeneratedCode("Geco", "1.0.8.0")]
    public partial class SalesOrderHeaderSalesReason
    {
        // Key Properties
        public int SalesOrderID { get; set; }
        public int SalesReasonID { get; set; }

        // Scalar Properties
        public DateTime ModifiedDate { get; set; }

        // Foreign keys
        public SalesOrderHeader SalesOrderHeader { get; set; }
        public SalesReason SalesReason { get; set; }

    }
}