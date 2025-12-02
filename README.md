## Välkommen till Github Workshop

>## OBS!!
>Var alltid vaksam när du hämtar kod från internet.
>
>Eller när någon säger åt dig att köra saker i terminalen...
>
>Eller när du klickar på länkar...
>
>Vi ska göra alla tre men du kan lita på mig ;)

>## Installera git
>
>### WINDOWS
>
>https://www.youtube.com/watch?v=hC0IRTdbV7o
>
>Kort sammanfattat, gå till https://git-scm.com
>
>Klicka vidare till install, hämta för din dator, följ installationsguiden.
>
>Verifiera i cmd (kommandotolken) med: git --version
> Om du får felmeddelande, titta på videon och säkerställ att du lagt till git i PATH.
> Videon visar hur du gör detta i efterhand.
>### MACOS
>Git kommer i bundle med xcode i macOS men jag använder personligen Homebrew, 
>rekomenderar att ni gör det också då det är väldigt smidigt.
>
>#### Homebrew
>klicka på länk: https://brew.sh
>- Öppna terminal
>- Kör kommandot från brew.sh
>#### Git
>kör:
>brew install git
>
>verifiera med: git version
>
>och sedan: type -a git

>## Installera Github Desktop
>Gå till: https://desktop.github.com/download/
>
>Ladda ner och installera.
>Logga in

>## Länka IDE
> ### RIDER
> Settings > Version Control > GitHub > Sign in
> ### Visual Studio
> Tools > Options > Source Control > Plug-in Selection > GitHub Extension for Visual Studio
> Log in

>## Hämta repo
>Nu ska vi plocka hem ett repository från GitHub, via GitHub Desktop
>
>Add > Clone Repository > URL
>https://github.com/tedpet0423/Workshop_repo_1.git
> 
> Välj plats, 
> #### OBS! Var noga med var du lägger dina repon och solutions då det skapas beroenden och om du flyttar filer/mappar kan du orsaka problem

>## Öppna i IDE
> ### Via GitHub Desktop
>Nu när du har klonat repon så kan du öppna den i din IDE
> GitHub Desktop har en knapp för detta "Open in Visual Studio" eller "Open in Rider"
> Klicka på den och vänta på att IDEn öppnar projektet
> Det kan vara så att det är en annan IDE som är förvald, detta går att ändra i inställningarna i GitHub Desktop
>### Via IDE
>Alternativt kan du öppna IDEn först och sedan öppna projektet därifrån

>## Köra projektet
>Nu när du har projektet öppet i din IDE så kan du köra det.
> I Visual Studio är det bara att klicka på den gröna play knappen högst upp
> I Rider är det liknande, en grön play knapp högst upp till höger
> Kör och följ instruktionerna i konsolen

> ## Skapa en Branch
> Innan du gör ändringar i koden så är det bra att skapa en branch
> En branch är som en kopia av koden där du kan göra ändringar utan att påverka huvudkoden (main branch)
> I GitHub Desktop kan du skapa en ny branch genom att klicka på "Current Branch" > "New Branch"
> Ge din branch ett namn och skapa den
> 
> #### OBS! Var noga med att du är på rätt branch när du gör ändringar

> ## Göra ändringar och commita
> Nu kan du göra ändringar i koden som du vill
> När du är klar med dina ändringar så kan du commita dem
> ### Github Desktop
> I GitHub Desktop ser du dina ändringar under "Changes"
> Skriv en commit message som beskriver dina ändringar
> Klicka på "Commit to [din branch]"
> ### IDE
> I din IDE kan du också göra commits
> I Visual Studio finns det en "Git Changes" panel där du kan se ändringar och göra commits
> I Rider finns det en "Version Control" panel för samma sak

> ## Pusha ändringar
> Efter att du har committat dina ändringar så behöver du pusha dem till GitHub
> I GitHub Desktop finns det en "Push origin" knapp som du kan klicka på
> I din IDE finns det också alternativ för att pusha ändringar

> ## Merge
> Välj branch du vill merge *till*
> Välj branch du vill hämta från
> Tryck på merge branch1 to branch2
