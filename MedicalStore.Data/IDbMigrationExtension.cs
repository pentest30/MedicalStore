namespace MedicalStore.Data
{
    public interface IDbMigrationExtension
    {
        void InitializeDatabase(MedicalStoreContext context);
    }
}