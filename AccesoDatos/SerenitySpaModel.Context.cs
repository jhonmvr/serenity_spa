﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Modelo.Entidades;
    
    public partial class db_serenity_spaEntities : DbContext
    {
        public db_serenity_spaEntities()
            : base("name=db_serenity_spaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_citas> tb_citas { get; set; }
        public virtual DbSet<tb_clientes> tb_clientes { get; set; }
        public virtual DbSet<tb_especialidades> tb_especialidades { get; set; }
        public virtual DbSet<tb_horarios> tb_horarios { get; set; }
        public virtual DbSet<tb_reservas> tb_reservas { get; set; }
        public virtual DbSet<tb_salones> tb_salones { get; set; }
        public virtual DbSet<tb_servicios> tb_servicios { get; set; }
        public virtual DbSet<tb_terapeutas> tb_terapeutas { get; set; }
        public virtual DbSet<tb_usuarios> tb_usuarios { get; set; }
    }
}