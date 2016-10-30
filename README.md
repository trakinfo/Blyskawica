# Blyskawica
Generator testów szkolnych

Program Błyskawica.NET jest przeznaczony do generowania i przeprowadzania testów wiedzy teoretycznej. Można w nim budować testy jednokrotnego i wielokrotnego wyboru.

Aplikacja udostępnia dwa tryby pracy – tryb TEST oraz GENERATOR TESTÓW.

Domyślnie program uruchamia się w trybie TEST, w którym uczeń może otworzyć i rozwiązać udostępniony dla niego test.
Otwarcie testu wiąże się z obligatoryjnym i automatycznym utworzeniem wersji rozwiązania, która jest zapisywana w bazie danych i zawiera m.in. dane identyfikujące użytkownika komputera (login) oraz nr IP komputera, na którym wersja powstała. Uczeń może wielokrotnie rozwiązać ten sam test, ale każde nowe otwarcie jest rejestrowane w systemie, nawet wtedy, gdy użytkownik anuluje rozwiązanie w trakcie pracy z testem. Przed otwarciem testu uczeń musi wybrać swoją grupę (klasę) oraz swoje dane osobowe (nazwisko i imię) z listy dostępnych grup uczniowskich. Dopiero wtedy uzyska dostęp do przeznaczonych dla niego testów. Wybór konkretnego testu odbywa się przez podświetlenie wybranej pozycji na liście testów, a po wybraniu testu uczeń uzyskuje dodatkowe informacje na temat testu, takie jak: kryteria ocen, typ wyboru czy limit czasu wykonania.

Czas pracy z testem jest monitorowany przez program, a użytkownik na bieżąco otrzymuje informacje o pozostałym czasie. Po przekroczeniu limitu czasu test jest automatycznie zamykany, obliczany jest wynik, a odpowiedzi są zapisywane w bazie danych (użytkownik może zakończyć pracę z testem przed upływem zadanego czasu). Niezależnie od sposobu zakończenia testu, uczeń od razu otrzymuje informację o wyniku w postaci liczby punktów i oceny ustalonej na podstawie kryteriów.

Tryb GENERATOR TESTÓW jest przeznaczony do tworzenia, edycji i zarządzania testami. Posiada również moduły umożliwiające zarządzanie użytkownikami, przeglądanie i drukowanie wyników oraz moduły pomocnicze.
Przejście do tego trybu następuje po zalogowaniu zarejestrowanego użytkownika, który otrzymuje prawo do wglądu na zaplecze, przez co może zarządzać bazą danych uczniów i użytkowników (z reguły nauczycieli), bazą testów, pytań i odpowiedzi. Może także zarządzać prawami dostępu do testów, udzielać pozwoleń na odczyt testów przez uczniów oraz przeglądać i drukować wyniki.

Podstawą aplikacji jest baza pytań i odpowiedzi, które nie są bezpośrednio związane z konkretnym testem. Pytania są tworzone niezależnie od testów i są pogrupowane wg przedmiotów nauczania i modułów przedmiotowych. Do każdego pytania może być wiele odpowiedzi, wśród których muszą znaleźć się odpowiedzi prawdziwe, których suma punktów musi wynosić 100. Odpowiedzi fałszywe mogą być tworzone w dowolnej liczbie, a każdej z nich należy przypisać wartość ujemną.

Tworzenie nagłówka testu polega na podaniu nazwy i określeniu dodatkowych parametrów, takich jak: typ wyboru, limit czasu, limit odpowiedzi, hasło czy kryteria ocen. Dopiero wtedy możliwe będzie wybieranie i dołączanie do testu pytań zgromadzonych w bazie danych, przy czym pytania można wybierać tylko z modułów powiązanych z przedmiotem, dla którego test został utworzony.

Nowy test jest domyślnie nieaktywny, co oznacza, że jest niewidoczny dla uczniów, nawet jeśli uczniowie mają nadane pozwolenie odczytu. Aktywacja testu powoduje udostępnienie testu dla uczniów, a nauczyciel może manipulować tym statusem w zależności od potrzeb.

Domyślnym właścicielem testu jest jego twórca i tylko on ma pełne prawo do niego. Właściciel testu może nadać prawo dostępu do testu innym nauczycielom, co pozwoli im wykorzystywać ten test w pracy z ich uczniami. Właściciel może przekazać prawo własności innemu nauczycielowi, ale wtedy wyzbywa się praw do testu i staje się jego zwykłym użytkownikiem.
Widzialność testu dla ucznia określa uprawniony nauczyciel, nadając lub odbierając mu pozwolenie odczytu do danego testu.

Po otwarciu testu program pobiera zestaw pytań zawartych w teście oraz w zależności od typu wyboru, losuje jedną lub pobiera wszystkie prawdziwe odpowiedzi związane z danym pytaniem. Następnie losuje związane z danym pytaniem odpowiedzi fałszywe i uzupełnia nimi zestaw odpowiedzi, tak aby osiągnąć ustalony limit odpowiedzi.
W trakcie pracy nad testem uczeń może wielokrotnie wracać do pytań i zmieniać odpowiedzi. Brak jakiejkolwiek odpowiedzi do jakiegoś pytania sygnalizowany jest zmianą koloru czcionki takiego pytania na kolor czerwony.

Rejestr wyników pozwala nauczycielowi na przeglądanie wyników zakończonych testów. Nauczyciel otrzymuje informacje na temat każdej wersji stworzonej przez ucznia, tj. liczba zdobytych punktów, ocena, czas rozpoczęcia i zakończenia. Ponadto w stopce formularza można odczytać login użytkownika, który tę wersję utworzył oraz nr IP komputera, na którym ta wersja powstała. Stanowi to zabezpieczenie przed nieuczciwym uczniem, który chciałby rozwiązać test jako inny uczeń.

Wybór danej wersji umożliwia przegląd udzielonych przez ucznia odpowiedzi, przy czym pytania zawierające błędne lub niepełne odpowiedzi oznaczane są kolorem czerwonym, a pytania zawierające dobre odpowiedzi kolorem czarnym. Zarówno jedne, jak i drugie widoczne są w formie rozwijalnego drzewa, którego gałęzie stanowią pytania a liście odpowiedzi. Wybór danego pytania powoduje rozwinięcie gałęzi i wyświetlenie udzielonych odpowiedzi. Odpowiedzi oznaczone kolorem zielonym są prawidłowe, a kolorem czerwonym błędne.
Każdą wersję odpowiedzi można wydrukować. Wydruk zawiera wszystkie podstawowe informacje na temat wyników oraz wykaz udzielonych odpowiedzi.

Dodatkowym atutem programu jest możliwość importu danych uczniów z programu Sekretariat.NET, co znacznie upraszcza zarządzanie grupami uczniów oraz zwalnia nauczyciela ze żmudnego wpisywania tych danych.