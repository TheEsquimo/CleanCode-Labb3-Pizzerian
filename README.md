***Elvis Sahlén & Charlotte Magnusson***

Vi har använt oss av tre designmönster.

**1. Singleton**

Vi har implementerat singleton på de klasser som vi vet aldrig kommer att behövas fler objekt av. Det blir bättre för minnet än att skapa statiska klasser.

Några klasser detta är applicerat på: ProgramNavigator, OrderManager, MenuContentCreator.

**2. Builder**

Vi har implementerat builder på de olika beställvarorna, för att underlätta skapandet och modifierandet av de olika subklasser som hör där till. Detta gör det mer skalbart då man enkelt kan lägga till nya subklasser med egna värden och beteenden, utan att förändra sättet man skapar dem på, tack vare den abstrakta buildern och dess director.

Några klasser detta är applicerat på: PizzaBuilder (PizzaMaker = director), DrinkBuilder (DrinkMaker = director), ToppingBuilder(ToppingMaker = director)

**3. Template Pattern**

Vi har implementerat template pattern inom våra directors i samband med vårt builder pattern. I våra directors finns det respektive build-metoder (BuildPizza, BuildDrink, BuildTopping) som ser till att allt körs i rätt ordning, med flera metodanrop samlat i en metod.

Detta är applicerat på: PizzaMaker.cs BuildPizza(), DrinkMaker.cs BuildDrink(), ToppingMaker.cs BuildTopping().
