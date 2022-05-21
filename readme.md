## Prototipos del proyecto Commics

https://www.figma.com/file/tgZbxZDIrarmFnsUsdvMSq/Comics-Store?node-id=0%3A1

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

## Pasos para generar una tabla a partir de una clase

1. Creo la clase y sus atributos

2. Le agrego la anotacion [Table("nombre_tabla")]

3. Agregar un PK  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  [Column("id")]

3. Hago la migracion dotnet ef migrations add SegundaMigration --context appcomics.Data.ApplicationDbContext -o "C:\Users\Inteligo\Code\netcore\usmp\20221\appcomics\Data\Migrations"

4. dotnet ef database update

## roles

AspNetRoles

Id   |Name |NormalizedName|ConcurrencyStamp                    |
-----+-----+--------------+------------------------------------+
admin|admin|admin         |604e948a-93a0-4c5f-aa63-ec2e39858a8c|

AspNetUserRoles

UserId                              |RoleId|
------------------------------------+------+
1205450e-9d35-492d-994d-7445e96d795e|admin |

AspNetUsers

Id                                  |UserName               
------------------------------------+-----------------------
1205450e-9d35-492d-994d-7445e96d795e|fduartej@gmail.com     
84ec9582-80a0-425c-b429-638c66f0f9f9|brandon162001@gmail.com
a47d07d6-2e52-40f0-b299-73731cb0013e|elagunau@qbe.net.pe    


select anu."Email" ,anur."RoleId" 
from "AspNetUsers" anu
left outer join "AspNetUserRoles" anur on anu."Id"  = anur."UserId"

Email                  |RoleId|
-----------------------+------+
fduartej@gmail.com     |admin |
elagunau@qbe.net.pe    |      |
brandon162001@gmail.com|      |


## generar crud producto

dotnet aspnet-codegenerator controller -name ProductoController -m Producto -dc appcomics.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries


## SendGrid

dotnet add package SendGrid --version 9.28.0