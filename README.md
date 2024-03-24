# ContactsApp

## Klasy
- ContactsController
Pobiera kontakty z bazy danych za pomocą methody GET 
Edytowanie i tworzenie kontaktów za pomocą POST
Usuwanie za pomocą metody http DELETE

- HomeController
Odpowiada za obsułgę strony głównej i błędów aplikacji
- Contact
Umożliwia przechowywanie danych w wygodny sposób
- ErrorViewModel
Przekazuje informacje o błędach do widoku w aplikacji.
- Views
Contacts - widok odpowiedzialny za tworzenie, usuwanie, edytowanie, wyświetlanie detali i indexu w ścieżce Contacts
Home - widok odpowiedzialny za wyswietlanie strony głównej
Shared - widoki które są wyswietlane sie niezależnie od ścieżki

## Wykorzystane biblioteki
- AspNetCore.Mvc
- EntityFrameworkCore

## Kompilowanie aplikacji 
Aplikacja kompilowana jest przy użyciu frameworka ASP.NET w Visual Studio
