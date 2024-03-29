﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using InventoryTrackWeb.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryTrackWeb.Models.Context
{
    public partial class InventoryTrackTestContext
    {
        private IInventoryTrackTestContextProcedures _procedures;

        public virtual IInventoryTrackTestContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new InventoryTrackTestContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public IInventoryTrackTestContextProcedures GetProcedures()
        {
            return Procedures;
        }

        protected void OnModelCreatingGeneratedProcedures(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetAll_ProductResult>().HasNoKey().ToView(null);
        }
    }

    public partial class InventoryTrackTestContextProcedures : IInventoryTrackTestContextProcedures
    {
        private readonly InventoryTrackTestContext _context;

        public InventoryTrackTestContextProcedures(InventoryTrackTestContext context)
        {
            _context = context;
        }

        public virtual async Task<List<GetAll_ProductResult>> GetAll_ProductAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<GetAll_ProductResult>("EXEC @returnValue = [dbo].[GetAll_Product]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
