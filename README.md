## ASP.Net Core
ASP.NET Core är ett ramverk för att bygga webbappar och tjänster men även Web API:er. Det har ett eget hosting-system där man ber om de klasser som man vill använda genom Dependency Injection för att möjliggöra en http request. Skapandet av objekten sker automatiskt och man behöver bara skriva ut dom för att berätta att man vill få åtkomst till dom.
Det finns två projekttyper inom själva ramverket som åstadkommer samma sak men är två olika sätt att strukturera sitt program på: Razor Pages & MVC

## Razor Pages
En "Razor Page"-fil är två sidor som hör ihop. Den ena sidan är till för att bygga utseendet på en sida med html, css & Javascript. Man kan även klämma in C#-kod. Den andra, tillhörande sidan är en POC (plain old C#)-klass där man bygger funktionaliteten bakom htmlcs-sidan.

En Razor Page består alltså utav en htmlcs-fil och en tillhörande htmlcs.cs-fil. Ordet ContentPage syftar till den förstnämnda filen medan PageModel syftar till den sistnämnda filen.
I PageModel finns metoder som OnGet() och OnPost() där man skriver kod som reagerar på när info hämtas från servern eller skickas till servern.

## MVC
Models, Controllers, Views (MVC) är den andra projekttypen som åstadkommer samma sak som Razor Pages men är uppbyggt lite annorlunda.
En mapp för Models funkar precis på samma sätt som i Razor Pages där man har sina modell-klasser som kommer att bli tabeller i databasen med tillhörande properties.

Controllers är en mapp som hanterar funktionaliteten i den här projekttypen.
Views motsvarar då ContentPage i Razor Pages där de olika sidorna finns.
Controllers tar emot data genom requests, från någon input genom t.ex en

i Views, som Controllern sedan reagerar på och skickar vidare till databasen (Models).
