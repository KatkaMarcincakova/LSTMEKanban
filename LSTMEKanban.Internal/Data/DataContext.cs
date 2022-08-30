namespace LSTMEKanban.Internal.Data
{
    public class DataContext : DbContext
    {
        public virtual DbSet<PrintTask> PrintTasks { get; set; }
        public DataContext(DbContextOptions<DataContext>options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
