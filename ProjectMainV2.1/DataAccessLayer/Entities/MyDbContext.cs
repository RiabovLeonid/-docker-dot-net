using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Entities
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }
        public MyDbContext() { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)//fluent validation
        {
            base.OnModelCreating(modelBuilder);
            #region Spending
            modelBuilder.Entity<Spending>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Spending>()
                .Property(p => p.Id_Dep)
                .IsRequired();
            modelBuilder.Entity<Spending>()
                .Property(p => p.Id_Spend_type)
                .IsRequired();
            modelBuilder.Entity<Spending>()
                .Property(p => p.Summa)
                .IsRequired();
            modelBuilder.Entity<Spending>()
                .HasOne(q => q.Spending_type)
                .WithMany(g => g.Spendings)
                .HasForeignKey(x => x.Id_Spend_type);
            modelBuilder.Entity<Spending>()
                .HasOne(q => q.Department)
                .WithMany(g => g.Spendings)
                .HasForeignKey(x => x.Id_Dep);
            modelBuilder.Entity<Spending>()
                .Property(p => p.DateT)
                .HasDefaultValueSql("getdate()");
            #endregion

            #region Department
            modelBuilder.Entity<Department>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Department>()
                .Property(p => p.Depart_name)
                .HasMaxLength(45)
                .IsRequired();
            modelBuilder.Entity<Department>()
                .Property(p => p.Employee_count)
                .IsRequired();
            #endregion

            #region Spending_type
            modelBuilder.Entity<Spending_type>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Spending_type>()
                .Property(p => p.Spending_name)
                .HasMaxLength(45)
                .IsRequired();
            #endregion

            #region Limit_Value
            modelBuilder.Entity<LimitValue>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<LimitValue>()
                .Property(p => p.Id_Dep)
                .IsRequired();
            modelBuilder.Entity<LimitValue>()
                .Property(p => p.Id_Spend_type)
                .IsRequired();
            modelBuilder.Entity<LimitValue>()
                .Property(p => p.Limit_value_in_order)
                .IsRequired();

            modelBuilder.Entity<LimitValue>()
                .HasOne(q => q.Spending_type)
                .WithMany(g => g.LimitValues)
                .HasForeignKey(x => x.Id_Spend_type);
            modelBuilder.Entity<LimitValue>()
                .HasOne(q => q.Department)
                .WithMany(g => g.LimitValues)
                .HasForeignKey(x => x.Id_Dep);
            #endregion

            #region Employee
            modelBuilder.Entity<Employee>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Employee>()
                .Property(p => p.Name)
                .HasMaxLength(45)
                .IsRequired();
            modelBuilder.Entity<Employee>()
                .Property(p => p.SurName)
                .HasMaxLength(45)
                .IsRequired();
            modelBuilder.Entity<Employee>()
                .Property(p => p.LastName)
                .HasMaxLength(45)
                .IsRequired();
            modelBuilder.Entity<Employee>()
                .Property(p => p.Id_Dep)
                .IsRequired();
            modelBuilder.Entity<Employee>()
                .Property(p => p.Salary)
                .IsRequired();

            modelBuilder.Entity<Employee>()
                .HasOne(s => s.Department)
                .WithMany(g => g.Employees)
                .HasForeignKey(s => s.Id_Dep);
            #endregion

        //    modelBuilder.Entity<Spending_type>().HasData(new Spending_type[] {
        //        new Spending_type{ Spending_name = "paper", Description ="" },
        //        new Spending_type{ Spending_name = "pens", Description ="" },
        //        new Spending_type{ Spending_name = "equipment", Description ="" }
        //    });
        //    modelBuilder.Entity<Employee>().HasData(new Employee[] {
        //        new Employee{ Name="Денис", SurName="Скібінський", LastName="Русланович", Id_Dep=5, Salary=19000},
        //        new Employee{ Name="Олександр", SurName="Слободян", LastName="Дмитрович", Id_Dep=1, Salary=12000},
        //        new Employee{ Name="Леонід", SurName="Рябов", LastName="Костянтинович", Id_Dep=5, Salary=15000},
        //        new Employee{ Name="Андрій", SurName="Онуфрійчук", LastName="Володимирович", Id_Dep=4, Salary=8000},
        //        new Employee{ Name="Юрій", SurName="Дужий", LastName="Віталійович", Id_Dep=1, Salary=8000},
        //        new Employee{ Name="Олександр", SurName="Олександр", LastName="Анатолійович", Id_Dep=3, Salary=15000},
        //        new Employee{ Name="Михайло", SurName="Цинтар", LastName="Ілліч", Id_Dep=2, Salary=11000},
        //        new Employee{ Name="Ярослав", SurName="Кирилюк", LastName="Сергійович", Id_Dep=3, Salary=11000},
        //    });

        //    modelBuilder.Entity<LimitValue>().HasData(new LimitValue[] {
        //        new LimitValue{Id_Dep =1, Id_Spend_type = 1, Limit_value_in_order = 1000 },
        //        new LimitValue{Id_Dep =2, Id_Spend_type = 2, Limit_value_in_order = 400 },
        //        new LimitValue{Id_Dep =3, Id_Spend_type = 3, Limit_value_in_order = 700 },
        //        new LimitValue{Id_Dep =4, Id_Spend_type = 2, Limit_value_in_order = 550 },
        //        new LimitValue{Id_Dep =5, Id_Spend_type = 3, Limit_value_in_order = 5000 },
        //        new LimitValue{Id_Dep =2, Id_Spend_type = 1, Limit_value_in_order = 200 },
        //        new LimitValue{Id_Dep =3, Id_Spend_type = 1, Limit_value_in_order = 400 }
        //    });

        //    modelBuilder.Entity<Department>().HasData(new Department[] {
        //        new Department{ Depart_name = "Рекламний відділ", Employee_count=2},
        //        new Department{ Depart_name = "Фінансовий відділ", Employee_count=1},
        //        new Department{ Depart_name = "Відділ кадрів", Employee_count=2},
        //        new Department{ Depart_name = "Відділ тестерів", Employee_count=1},
        //        new Department{ Depart_name = "Відділ розробників", Employee_count=2}
        //    });
        //    modelBuilder.Entity<Spending>().HasData(new Spending[] {
        //        new Spending{Id_Dep =1, Id_Spend_type = 1, Summa = 500 },
        //        new Spending{Id_Dep =2, Id_Spend_type = 2, Summa = 300 },
        //        new Spending{Id_Dep =3, Id_Spend_type = 3, Summa = 500 },
        //        new Spending{Id_Dep =4, Id_Spend_type = 2, Summa = 500 },
        //        new Spending{Id_Dep =5, Id_Spend_type = 3, Summa = 500 },
        //        new Spending{Id_Dep =2, Id_Spend_type = 1, Summa = 100 },
        //        new Spending{Id_Dep =3, Id_Spend_type = 1, Summa = 350 }
        //    });
        }
        public DbSet<Spending> Spendings { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Spending_type> Spending_Types { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LimitValue> limit_Values { get; set; }
    }
}