namespace NdCRM.Utility
{
    public static class ConnectionString
    {
        private static string cName = "server=103.83.81.251;database=admin_NDCrM;User ID=admin_NDCrM;Password=NDCrM@12345#;TrustServerCertificate=True";
        public static string CName
        {
            get => cName;
        }
    }
}
