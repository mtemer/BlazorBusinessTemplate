1. Core nikada ne ovisi o Platform.

2. Services nikada ne koriste IJSRuntime izravno.

3. Program.cs ne sadrži poslovnu logiku.

4. Public API mora imati XML komentare.

5. Jedna javna klasa = jedna datoteka.

6. Guard se koristi za provjeru argumenata.

7. Servisi vraćaju Result ili Result<T> kada ima smisla.

8. Dependency Injection ide isključivo kroz Extensions.

9. Framework ne smije imati "magic strings".

10. Svaka nova komponenta mora imati stvaran razlog postojanja.