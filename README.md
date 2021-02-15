# Unidad27_APIs_BBDD_SQL

#API1


#### 1. Description
```
Demo API REST creada con .NET COre 3.1 utilizando varias entidades ER y conectada con base de datos 
MS Sql Virtualizada sobre Fedora 32  y Virtualbox 6.1. Aplicación con fines educativos.
```

#### 2. Link a un demo con el proyecto desplegado: https://github.com/GerardoAguilarGomez/Unidad27_APIs_BBDD_SQL.git

```
* Nombre de la App: [GIT] (https://github.com/)
```
#### 3. Lista con los pasos mínimos que se necesitan para clonar exitosamente el proyecto y echarlo a andar en local.

###### Install
```
IDE               Visual Studio 2019 Community Version
Core              C# 
Framework         NET Core 3.1
DataBase          Microsoft Sql Server 
Virtual           VirtualBox 6.1
SO                Fedora 32
```
###### packages Nuget 
```
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design  -Version 3.1.4
Install-Package Microsoft.EntityFrameworkCore.Tools               -Version 3.1.8
Install-Package Microsoft.EntityFrameworkCore.SqlServer           -Version 3.1.8
```
###### Cadena de Conexión Base de datos 
```
"AllowedHosts": "*",
  "ConnectionStrings": {
    "APIConnection": "Server=192.168.1.135;Database=Unidad27_Ej1;User ID=root;Password=NvEPtJ&kxkWhmc21f#"
    }
```
#### 4. URIs endpoints.
```
Piezas
GET       /api/Piezas
POST      /api/Piezas
GET       /api/Piezas/{id}
PUT       /api/Piezas/{id}
DELETE    /api/Piezas/{id}

Proveedores
GET       /api/Proveedores
POST      /api/Proveedores
GET       /api/Proveedores/{id}
PUT       /api/Proveedores/{id}
DELETE    /api/Proveedores/{id}

Suministras
GET       /api/Suministras
POST      /api/Suministras
GET       /api/Suministras/{id}
PUT       /api/Suministras/{id}
DELETE    /api/Suministras/{id}
```

#### 5. Screenshot imagen que indique cómo debe verse el proyecto.
![image](https://user-images.githubusercontent.com/76479548/107931065-18584d00-6f7c-11eb-93bd-98a98abbc244.png)

#API2


1. Description
Demo API REST creada con .NET COre 3.1 utilizando varias entidades ER y conectada con base de datos 
MS Sql Virtualizada sobre Fedora 32  y Virtualbox 6.1. Aplicación con fines educativos.
2. Link a un demo con el proyecto desplegado: https://github.com/GerardoAguilarGomez/Unidad27_APIs_BBDD_SQL.git
* Nombre de la App: [GIT] (https://github.com/)
3. Lista con los pasos mínimos que se necesitan para clonar exitosamente el proyecto y echarlo a andar en local.
Install
IDE               Visual Studio 2019 Community Version
Core              C# 
Framework         NET Core 3.1
DataBase          Microsoft Sql Server 
Virtual           VirtualBox 6.1
SO                Fedora 32
packages Nuget
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design  -Version 3.1.4
Install-Package Microsoft.EntityFrameworkCore.Tools               -Version 3.1.8
Install-Package Microsoft.EntityFrameworkCore.SqlServer           -Version 3.1.8
Cadena de Conexión Base de datos
"AllowedHosts": "*",
  "ConnectionStrings": {
    "APIConnection": "Server=192.168.1.135;Database=Unidad27_Ej2;User ID=root;Password=NvEPtJ&kxkWhmc21f#"
    }
4. URIs endpoints.
Poryectos
GET       /api/Poryectos
POST      /api/Poryectos
GET       /api/Poryectos/{id}
PUT       /api/Poryectos/{id}
DELETE    /api/Poryectos/{id}

Cientificos
GET       /api/Cientificos
POST      /api/Cientificos
GET       /api/Cientificos/{id}
PUT       /api/Cientificos/{id}
DELETE    /api/Cientificos/{id}

Asignados
GET       /api/Asignados
POST      /api/Asignados
GET       /api/Asignados/{id}
PUT       /api/Asignados/{id}
DELETE    /api/Asignados/{id}

5. Screenshot imagen que indique cómo debe verse el proyecto.
![image](https://user-images.githubusercontent.com/76479548/107978453-14005400-6fbd-11eb-8836-ced001e81356.png)

#API3

1. Description
Demo API REST creada con .NET COre 3.1 utilizando varias entidades ER y conectada con base de datos 
MS Sql Virtualizada sobre Fedora 32  y Virtualbox 6.1. Aplicación con fines educativos.
2. Link a un demo con el proyecto desplegado: https://github.com/GerardoAguilarGomez/Unidad27_APIs_BBDD_SQL.git
* Nombre de la App: [GIT] (https://github.com/)
3. Lista con los pasos mínimos que se necesitan para clonar exitosamente el proyecto y echarlo a andar en local.
Install
IDE               Visual Studio 2019 Community Version
Core              C# 
Framework         NET Core 3.1
DataBase          Microsoft Sql Server 
Virtual           VirtualBox 6.1
SO                Fedora 32
packages Nuget
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design  -Version 3.1.4
Install-Package Microsoft.EntityFrameworkCore.Tools               -Version 3.1.8
Install-Package Microsoft.EntityFrameworkCore.SqlServer           -Version 3.1.8
Cadena de Conexión Base de datos
"AllowedHosts": "*",
  "ConnectionStrings": {
    "APIConnection": "Server=192.168.1.135;Database=Unidad27_Ej3;User ID=root;Password=NvEPtJ&kxkWhmc21f#"
    }
    
4. URIs endpoints.
Cajeros
GET       /api/Cajeros
POST      /api/Cajeros
GET       /api/Cajeros/{id}
PUT       /api/Cajeros/{id}
DELETE    /api/Cajeros/{id}

Máquinas
GET       /api/Maquinas
POST      /api/Maquinas
GET       /api/Maquinas/{id}
PUT       /api/Maquinas/{id}
DELETE    /api/Maquinas/{id}

Productos
GET       /api/Productos
POST      /api/Productos
GET       /api/Productos/{id}
PUT       /api/Productos/{id}
DELETE    /api/Productos/{id}

Productos
GET       /api/Ventas
POST      /api/Ventas
GET       /api/Ventas/{id}
PUT       /api/Ventas/{id}
DELETE    /api/Ventas/{id}

5. Screenshot imagen que indique cómo debe verse el proyecto.
![image](https://user-images.githubusercontent.com/76479548/107978804-b0c2f180-6fbd-11eb-81c4-d3b5423880ba.png)


#API4


#### 1. Description
```
Demo API REST creada con .NET COre 3.1 utilizando varias entidades ER y conectada con base de datos 
MS Sql Virtualizada sobre Fedora 32  y Virtualbox 6.1. Aplicación con fines educativos.
```

#### 2. Link a un demo con el proyecto desplegado: https://github.com/GerardoAguilarGomez/Unidad27_APIs_BBDD_SQL.git

```
* Nombre de la App: [GIT] (https://github.com/)
```
#### 3. Lista con los pasos mínimos que se necesitan para clonar exitosamente el proyecto y echarlo a andar en local.

###### Install
```
IDE               Visual Studio 2019 Community Version
Core              C# 
Framework         NET Core 3.1
DataBase          Microsoft Sql Server 
Virtual           VirtualBox 6.1
SO                Fedora 32
```
###### packages Nuget 
```
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design  -Version 3.1.4
Install-Package Microsoft.EntityFrameworkCore.Tools               -Version 3.1.8
Install-Package Microsoft.EntityFrameworkCore.SqlServer           -Version 3.1.8
```
###### Cadena de Conexión Base de datos 
```
"AllowedHosts": "*",
  "ConnectionStrings": {
    "APIConnection": "Server=192.168.1.135;Database=Unidad27_Ej4;User ID=root;Password=NvEPtJ&kxkWhmc21f#"
    }
```
#### 4. URIs endpoints.
```
Equipos
GET       /api/Equipos
POST      /api/Equipos
GET       /api/Equipos/{id}
PUT       /api/Equipos/{id}
DELETE    /api/Equipos/{id}

Facultades
GET       /api/Facultades
POST      /api/Facultades
GET       /api/Facultades/{id}
PUT       /api/Facultades/{id}
DELETE    /api/Facultades/{id}

Investigadores
GET       /api/Investigadores
POST      /api/Investigadores
GET       /api/Investigadores/{id}
PUT       /api/Investigadores/{id}
DELETE    /api/Investigadores/{id}

Reservas
GET       /api/Reservas
POST      /api/Reservas
GET       /api/Reservas/{id}
PUT       /api/Reservas/{id}
DELETE    /api/Reservas/{id}
```

#### 5. Screenshot imagen que indique cómo debe verse el proyecto.
