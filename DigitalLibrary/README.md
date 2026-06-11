# Digital Library (MVC Project)

## Autor projektu

* **Imię i nazwisko:** Volodymyr Matvieiev
* **Numer albumu:** 63367

---

## Spis treści

1. Opis projektu
2. Funkcjonalności
3. Technologie
4. Uruchomienie projektu
5. Przykładowe dane

---

## Opis projektu

Digital Library to aplikacja internetowa stworzona z wykorzystaniem ASP.NET Core MVC. System umożliwia zarządzanie książkami oraz autorami w bibliotece cyfrowej.

---

## Funkcjonalności

* Wyświetlanie listy książek
* Dodawanie nowych książek
* Edycja książek
* Usuwanie książek
* Wyszukiwanie książek po tytule i autorze
* Wybór autora z listy podczas dodawania i edycji książki
* Walidacja danych formularzy

---

## Technologie

* ASP.NET Core MVC
* C#
* Razor Views
* Bootstrap
* .NET 10

---

## Uruchomienie projektu

### Wymagania

* Zainstalowany .NET SDK 10.0 lub nowszy

### Sprawdzenie wersji .NET

```bash
dotnet --version
```

### Uruchomienie aplikacji

```bash
cd DigitalLibrary
dotnet run
```

Po uruchomieniu aplikacja będzie dostępna pod adresem:

```text
http://localhost:8080/Books
```

---

## Przykładowe dane

Domyślnie aplikacja zawiera przykładowe książki:

* Titanic – Stanisław Lem (1997)
* 1984 – George Orwell (1949)

Dostępni autorzy:

* Stanisław Lem
* George Orwell
* Adam Mickiewicz
