## Pasos usados para esta APP

git clone https://github.com/fduartej/appcomics.git

cd appcomics

dotnet new mvc --auth Individual

vscode>terminal

dotnet tool install --global dotnet-aspnet-codegenerator --version 6.0.2

add .gitignore

https://dashboard.heroku.com/apps/appcomics/resources

add postgress

dotnet aspnet-codegenerator identity -dc appcomics.Data.

ApplicationDbContext --files "Account.Register;Account.Login"

editas los nombres y el html

borrar la carpeta migrations

dotnet ef migrations add InitialMigration --context appcomics.Data.ApplicationDbContext -o "C:\Users\Inteligo\Code\netcore\usmp\20221\appcomics\Data\Migrations"

dotnet ef database update