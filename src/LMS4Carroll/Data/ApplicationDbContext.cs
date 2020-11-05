﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LMS4Carroll.Models;
using Microsoft.EntityFrameworkCore.Storage;
using LMS4Carroll.Data;

namespace LMS4Carroll.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<ChemEquipment> ChemicalEquipments { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Vendor> Vendors { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<FileDetail> FileDetails { get; set; }
		public DbSet<BioEquipment> BioEquipments { get; set; }
		public DbSet<BioArchive> BioArchives { get; set; }
		public DbSet<Animal> Animal { get; set; }
		public DbSet<Cage> Cage { get; set; }
		public DbSet<CageLog> CageLog { get; set; }
		public DbSet<Chemical> Chemical { get; set; }
		public DbSet<ChemInventory> ChemInventory { get; set; }
		public DbSet<ChemInventory2> ChemInventory2 { get; set; }
		public DbSet<ChemInventoryArc> ChemInventoryArc { get; set; }
		public DbSet<ChemInventoryArc2> ChemInventoryArc2 { get; set; }
		public DbSet<Formula> Formula { get; set; }
		public DbSet<FormulaLog> FormulaLog { get; set; }
		public DbSet<ChemArchive> ChemArchives { get; set; }
		public DbSet<Course> Course { get; set; }
		public DbSet<ChemLog> ChemLog { get; set; }
		public DbSet<PhyEquipment> PhyEquipments { get; set; }
		public DbSet<PhyArchive> PhyArchives { get; set; }
		public DbSet<Disposable> Disposable { get; set; }
		public DbSet<PhyDisposables> PhyDisposables { get; set; }
		

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}      
	}
}
