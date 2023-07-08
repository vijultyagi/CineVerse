﻿using System;
using CineVerseWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CineVerseWeb.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Movie> Movies { get; set; }
	}
}

