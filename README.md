# Cajero Automático - ASP.NET Core MVC

Este es un proyecto de un Cajero Automático desarrollado en ASP.NET Core MVC con arquitectura Onion y Entity Framework Core. Permite a los usuarios seleccionar un modo de dispensación y retirar dinero de acuerdo con las reglas definidas.

## Características

* Selección de modo de dispensación:

  * Solo billetes de 200 y 1000

  * Solo billetes de 100 y 500

  * Modo eficiente (entrega la menor cantidad de billetes posible)

* Retiro de dinero validado según el modo de dispensación seleccionado.

* Persistencia del modo de dispensación en la base de datos.

## Tecnologías Utilizadas

* ASP.NET Core MVC

* Entity Framework Core

* SQL Server (opcional, puedes usar SQLite o en memoria)

* C# y .NET 7/8

## Endpoints Principales

### Modo de Dispensación

* GET /Cajero/SeleccionarModo → Muestra el formulario para elegir el modo de dispensación.

* POST /Cajero/SeleccionarModo → Guarda la selección del modo de dispensación.

### Retiro de Dinero

* GET /Cajero/RetirarDinero → Muestra el formulario para ingresar el monto a retirar.

* POST /Cajero/RetirarDinero → Procesa la solicitud y devuelve la cantidad de billetes dispensados.


📜 Licencia

Este proyecto está bajo la licencia MIT.

🚀 Desarrollado con ASP.NET Core MVC por Jhossua Roa Rodríguez

