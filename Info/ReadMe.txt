MySqlDump10.06.2019.sql - дамп БД.
Для работы изменить строку подключения к БД. В файлах :
\SpearShopDesktop\SpearShopWeb\DAO\MyDbContext.cs
\SpearShopDesktop\SpearShopDesktop\DAO\MyDbContext.cs

Которая выглядит так:
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;UserId=root;Password=password;database=spearshop;");
        }
Ввести корректные данные для вашего случая.