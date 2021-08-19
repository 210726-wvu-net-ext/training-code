﻿using UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DL.Entities;
using BL;
using DL;
using System.IO;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string connectionString = configuration.GetConnectionString("petdb");

DbContextOptions<petdbContext> options = new DbContextOptionsBuilder<petdbContext>()
    .UseSqlServer(connectionString)
    .Options;

var context = new petdbContext(options);

HealthStatus status;
var obj=status.getInstance;

IMenu menu = new MainMenu(new PetBL(new PetRepo(context)));
menu.Start();