﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeriLoyalty
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class teriEntities2 : DbContext
    {
        private static teriEntities2 _context;

        public teriEntities2()
            : base("name=teriEntities2")
        {
        }

        public static teriEntities2 GetContext()
        {
            if (_context == null)
                _context = new teriEntities2();

            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

    
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Loyalties> Loyalties { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
