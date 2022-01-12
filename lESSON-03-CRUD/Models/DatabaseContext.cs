using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        /// <summary>
        /// در پروژه های وب از این روش استفاده می کنیم
        /// </summary>
        ///// <summary>
        ///// یک سری ویژگی ها را مانند نحوه ی اتصال به بانک اطاعاتی به همراه می آورد option در اینجا پارامتر 
        ///// </summary>
        ///// <param name="options"></param>
        //public DatabaseContext(Microsoft.EntityFrameworkCore.DbContextOptions<DatabaseContext> options)
        //    : base(options: options)
        //{
        //}

        private readonly string _connectionString;
        public DatabaseContext(string connectionString)
        {
            _connectionString = connectionString;

            Database.EnsureCreated();
        }

        /// <summary>
        /// در پروژه های غیر وب از این روش استفاده می کنیم
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          

            optionsBuilder.UseSqlServer(connectionString: _connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        /// <summary>
        ///  نداشت table database قرار می دادید تاثیری در نام  collection قدیمی یا کلاسیک نامی که برای این  Entity Framework در 
        /// خواهد بود database در table قرار می دهید  نام   People مانند  collection  دقیقا همین نامی که برای  Entity Framework Core ولی در 
        /// </summary>
        public Microsoft.EntityFrameworkCore.DbSet<Models.User> Users { get; set; }
    }
}
