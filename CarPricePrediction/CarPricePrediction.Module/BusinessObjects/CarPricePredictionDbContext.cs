using DevExpress.ExpressApp.EFCore.Updating;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EFCore.DesignTime;

namespace CarPricePrediction.Module.BusinessObjects;

// This code allows our Model Editor to get relevant EF Core metadata at design time.
// For details, please refer to https://supportcenter.devexpress.com/ticket/details/t933891.
public class CarPricePredictionContextInitializer : DbContextTypesInfoInitializerBase {
	protected override DbContext CreateDbContext() {
		var optionsBuilder = new DbContextOptionsBuilder<CarPricePredictionEFCoreDbContext>()
            .UseSqlServer(";")
            .UseChangeTrackingProxies()
            .UseObjectSpaceLinkProxies();
        return new CarPricePredictionEFCoreDbContext(optionsBuilder.Options);
	}
}
//This factory creates DbContext for design-time services. For example, it is required for database migration.
public class CarPricePredictionDesignTimeDbContextFactory : IDesignTimeDbContextFactory<CarPricePredictionEFCoreDbContext> {
	public CarPricePredictionEFCoreDbContext CreateDbContext(string[] args) {
		//throw new InvalidOperationException("Make sure that the database connection string and connection provider are correct. After that, uncomment the code below and remove this exception.");
		var optionsBuilder = new DbContextOptionsBuilder<CarPricePredictionEFCoreDbContext>();
		optionsBuilder.UseSqlServer("Data Source=BahaY;Initial Catalog=CarPricePrediction;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        optionsBuilder.UseChangeTrackingProxies();
        optionsBuilder.UseObjectSpaceLinkProxies();
		return new CarPricePredictionEFCoreDbContext(optionsBuilder.Options);
	}
}
[TypesInfoInitializer(typeof(CarPricePredictionContextInitializer))]
public class CarPricePredictionEFCoreDbContext : DbContext {
	public CarPricePredictionEFCoreDbContext(DbContextOptions<CarPricePredictionEFCoreDbContext> options) : base(options) {
	}
	public DbSet<VwCars> VwCars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangingAndChangedNotificationsWithOriginalValues);
        modelBuilder.UsePropertyAccessMode(PropertyAccessMode.PreferFieldDuringConstruction);
    }
}
