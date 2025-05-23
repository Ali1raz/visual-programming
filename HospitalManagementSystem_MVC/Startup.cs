public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<HospitalDBContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("HospitalDBContext")));

    services.AddControllersWithViews();
}