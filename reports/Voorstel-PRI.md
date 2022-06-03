# Voorstel-PRI

## Recipe App

Deze app is bedoeld voor een bedrijf die hun eigen recepten kan in een app steken.

# Users

Een gebruiker zal zich kunnen inloggen en registreren.
De gebruiker zal kunnen recepten bekijken, toevoegen aan hun eigen favorieten. Een like geven aan een recept en ook een score geven aan de recepten.
Als de gebruiker op een specifiek recept geklikt heeft dan kan de gebruiker het aantal personen wijzigen. Als dit gewijzigd word dan wijzigen alle hoeveelheden ingredienten aan de hand van de gekozen personen. De stappen om dit gerecht klaar te maken zijn ook eveneens beschikbaar.
Het bekijken van de recepten zal gebeuren door te communiceren met een API.

### Optioneel

Wanneer de gebruiker beslist heeft welk recept hij/zij wilt klaar maken bestaat er een mogelijkheid om deze te kunnen afdrukken. Het recept zou dan worden om gezet naar een PDF bestand zo dat het kan afgedrukt worden.

# Admin

Een Admin zal kunnen recepten, categorieën, thema's, ingredienten en soort keuken kunnen toevoegen. En gebruikers kunnen bewerken.

# Programming Integration

## API

Deze zal controllers krijgen met elk hun eigen endpoints.

### Controllers:

* Recipe
* Categorie
* Ingredient
* Theme
* User
* Kitchen (Optioneel)

<br/>

### Beveiliging endpoints

Heel veel van deze onderstaande endpoints zullen kunnen gebruikt worden door de admins. Zodat de gebruikers niets zouden kunnen toevoegen, bewerken of verwijderen.

<br/>

### Endpoints Recipe:

| **Endpoint**      | **Methode** | **Beschrijving**                     |
|:-----------------:|:-----------:|:------------------------------------:|
| /api/Recipes      | GET         | Geeft een lijst van alle recepten    |
| /api/Recipes/{id} | GET         | Geeft een recept met een bepaalde id |
| /api/Recipes/{id}/Ingredients | GET         | Geeft één recept met alle ingrediënten |
| /api/Recipes      | PUT         | Bewerkt een bepaald recept            |
| /api/Recipes      | POST        | Voegt een recept toe                 |
| /api/Recipes/{id} | DELETE      | Verwijderd een recept               |

<br/>

### Endpoints Categorie:

| **Endpoint**      | **Methode** | **Beschrijving**                     |
|:-----------------:|:-----------:|:------------------------------------:|
| /api/Categories      | GET         | Geeft een lijst van alle categorieëen|
| /api/Categories/{id} | GET         | Geeft een categorie met een bepaalde id |
| /api/Categories/{id}/Products | GET         | Geeft één categorie met alle recepten |
| /api/Categories      | PUT         | Bewerk een bepaalde categorie            |
| /api/Categories      | POST        | Voegt een categorie toe                 |
| /api/Categories/{id} | DELETE      | Verwijderd een categorie               |

<br/>

###  Endpoints Ingrediënten:

| **Endpoint**      | **Methode** | **Beschrijving**                     |
|:-----------------:|:-----------:|:------------------------------------:|
| /api/Ingredients      | GET         | Geeft een lijst van alle ingrediënten|
| /api/Ingredients/{id} | GET         | Geeft een ingrediënt met een bepaalde id |
| /api/Ingredients      | PUT         | Bewerk een bepaalde ingrediënt            |
| /api/Ingredients      | POST        | Voegt een ingrediënt toe                 |
| /api/Ingredients/{id} | DELETE      | Verwijderd een ingrediënt               |

<br/>

### Endpoints Thema's:

| **Endpoint**      | **Methode** | **Beschrijving**                     |
|:-----------------:|:-----------:|:------------------------------------:|
| /api/Themes      | GET         | Geeft een lijst van alle thema's|
| /api/Themes/{id} | GET         | Geeft een thema met een bepaalde id |
| /api/Themes/{id}/Recipes | GET         | Geeft één thema met met alle recepten |
| /api/Themes      | PUT         | Bewerk een bepaalde thema            |
| /api/Themes      | POST        | Voegt een thema toe                 |
| /api/Themes/{id} | DELETE      | Verwijderd een thema               |

<br/>

### Endpoints Users:

| **Endpoint**      | **Methode** | **Beschrijving**                     |
|:-----------------:|:-----------:|:------------------------------------:|
| /api/Users      | GET         | Geeft een lijst van alle gebruikers|
| /api/Users/{id} | GET         | Geeft een gebruiker met een bepaalde id |
| /api/Users      | PUT         | Bewerk een bepaalde gebruiker          |
| /api/Users      | POST        | Voegt een gebruiker toe                 |
| /api/Users/{id} | DELETE      | Verwijderd een gebruiker               |

<br />

### Endpoints Kitchen:

| **Endpoint**      | **Methode** | **Beschrijving**                     |
|:-----------------:|:-----------:|:------------------------------------:|
| /api/Kitchens      | GET         | Geeft een lijst van alle soorten keukens|
| /api/Kitchens/{id} | GET         | Geeft een soort keuken met een bepaalde id |
| /api/Kitchens/{id}/Recipes | GET         | Geeft één soort keuken met alle recepten |
| /api/Kitchens      | PUT         | Bewerk een bepaalde soort keuken          |
| /api/Kitchens      | POST        | Voegt een soort keuken toe                 |
| /api/Kitchens/{id} | DELETE      | Verwijderd een soort keuken               |

