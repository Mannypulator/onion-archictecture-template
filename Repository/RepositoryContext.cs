﻿
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class RepositoryContext : DbContext
{
	public RepositoryContext(DbContextOptions options)
		: base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		// add the configuartion to populate the database or seed database
	}

	
}
