MySqlDump10.06.2019.sql - ���� ��.
��� ������ �������� ������ ����������� � ��. � ������ :
\SpearShopDesktop\SpearShopWeb\DAO\MyDbContext.cs
\SpearShopDesktop\SpearShopDesktop\DAO\MyDbContext.cs

������� �������� ���:
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;UserId=root;Password=password;database=spearshop;");
        }
������ ���������� ������ ��� ������ ������.