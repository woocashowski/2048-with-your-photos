using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.View
{
    interface IView
    {
        //załadować 
        event Action BoardLoad;
        event Action BoardMove;
        event Action Reset;

        


        //kliknięcie strzałki to event
        //klikanie resetu
        /*  strona tytuła, przedsatwić, tytuł projketu, nazwa przedmiotu, polsl wydział etc, data
         *  opis czym projekt jest, do czego służy, nietechniczne max 10 stron, którtki opis funkcjonalności
         *  funkcjonalności jakie aplikacja zapewnia (dodawanie informacji do bazy), rozwinąć. Z punktu widzenia usera i serwera
         *  model danych, nie format dancyh, nie odnośnie bazy tylko np model relacyjny, mamy takie tabele, uml jako opis bazy
         *  projekt interfejsu, czy model interfejsu spełnia wymagania i oczekiwania
         *  instrukcja dla użytkownika, może być w projekcie interfejsu
         *  opis użytej technologii, jaki serwer zarządzania bazą danych + wersja, numer .Neta, 
         *  opis modelu obiektowego, opisać interfejs publiczny, opis sygnatury, ta metoda służy do tego i tego
         *  nie zamieszczamy kodu
         *  można wrzucić ciekawe rozwiązania, wartościowe
         *  ma zawierać tyle stron ile potrzeba
         *  dokumentację piszemy implementując projekt, w trakcie pisania 
         */
    }
}
