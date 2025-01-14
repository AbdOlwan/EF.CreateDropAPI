﻿using EF.CreateDropAPI.Data;
using EF.CreateDropAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF.CreateDropAPI
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                await context.Database.EnsureCreatedAsync();

                if (!await context.Set<Individual>().AnyAsync())
                {
                    context.Set<Individual>().AddRange(SeedData.LoadIndividuals());
                }
                if (!await context.Set<Coporate>().AnyAsync())
                {
                    context.Set<Coporate>().AddRange(SeedData.LoadCorporates());
                }
                if (!await context.Set<Course>().AnyAsync())
                {
                    context.Set<Course>().AddRange(SeedData.LoadCourses());
                }
                if (!await context.Set<Office>().AnyAsync())
                {
                    context.Set<Office>().AddRange(SeedData.LoadOffices());
                }
                if (!await context.Set<Schedule>().AnyAsync())
                {
                    context.Set<Schedule>().AddRange(SeedData.LoadSchedules());
                }
                if (!await context.Set<Instructor>().AnyAsync())
                {
                    context.Set<Instructor>().AddRange(SeedData.LoadInstructors());
                }
                if (!await context.Set<Section>().AnyAsync())
                {
                    context.Set<Section>().AddRange(SeedData.LoadSections());
                }
                if (!await context.Set<Enrollment>().AnyAsync())
                {
                    context.Set<Enrollment>().AddRange(SeedData.LoadEnrollments());
                }

                await context.SaveChangesAsync();
            }
            Console.ReadKey();
        }
    }
}
