﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using appcomics.Models;

namespace appcomics.Data;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<appcomics.Models.Contacto> DataContactos { get; set; }

        public DbSet<appcomics.Models.Producto> DataProductos { get; set; }

        public DbSet<appcomics.Models.Proforma> DataProforma { get; set; }

        public DbSet<appcomics.Models.Pago> DataPago { get; set; }

        public DbSet<appcomics.Models.Pedido> DataPedido { get; set; }

         public DbSet<appcomics.Models.DetallePedido> DataDetallePedido { get; set; }
    }
