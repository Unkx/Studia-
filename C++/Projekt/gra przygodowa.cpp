#include <iostream>
#include <cmath>
#ifdef _WIN32
#include <Windows.h>
#else
#include <unistd.h>
#endif
#include <iostream>
#include <cstdlib>
#include <iomanip>  // for  floating
#include <locale.h> // for local language support
#include <conio.h>  // for  concurrency
//#include <windows.h> // for windows
//#include <unistd.h> // for linux
//nie może być input=getch() bo linux ma problem
//gra była robiona na dwóch systemach operacyjnych: linux i windows 


using namespace std;

int main(){
    setlocale(LC_CTYPE, "Polish");

    
    cout << "Witamy w grze " << endl;

    int number;
    string imie;


    
    cout << "Podaj imię : " << endl << "> ";
    cin >> imie ;


    exit:
    cout << "Wybierz bohatera opowieści : " << endl;
    cout << "1.Podróżnik " << endl << "2.Złodziej" << endl << "3.Wciśnij [7] by dowiedzieć się więcej o postaciach" << endl;

    cout << "> " ;
    cin >> number;
    

    if (number == 1){
        cout << "> ";
        cout << " Wybrałeś klasę : Podróżnik" << endl;
        cout << "> Witaj , " << imie << endl;
        cout << "> Twoja przygoda zaczyna się w karczie, gdzie po przebudzeniu dowiadujesz się że zostałeś okradziony [złoty zegarek kieszonkowy] przez lokalnego złodzieja" << endl;
        cout << "Co zamierzasz zrobić ?" << endl << "> [1] Odzyskam skradzioną własność " << endl << "> [2] Zostawię to , w końcu to tylko zegarek, kupisz sobie nowy "<< endl <<
        "> [3] Dlaczego zostałem okradziony?"<< endl ;
        cout << "> ";
        cin >> number;

            {
                if (number == 1){
                    cout << "A więc chcesz odzyskać swój złoty zegarek , który jest pamiątką po ojcu" << endl;
                    cout << "Wychodzisz z karczmy i zastanawiasz się co zrobić dalej"  << endl;
                    cout << "[1] Straż" << endl << "[2] Kasyno" << endl ;

                    cout << "> ";
                    cin >> number;
                {

                    if (number == 1){
                        cout << "Wybrałeś Straż " << endl;
                        cout << "Idziesz więc na straż a tam widzisz swój zegarek, a obok strażnika przesłuchującego złodzieja" << endl;
                        cout << "Mówisz więc że to twój zegarek, lecz złodziej nie podziela twojego zdania i uważa że to jego zegarek i ma na to dowody." << endl;
                        cout << "Straż nie wierzy jednak złodziejowi i skazuje go na 5 lat za kradzież i składanie fałszywych zeznań, a Ty odzyskujesz zegarek!" << endl;
                        printf("KONIEC GRY");

                    }
                    else if(number == 2){
                        cout << "Wybrałeś Kasyno " << endl;
                        cout << "Zapdadł zmrok, a ty wychodzisz więc z kasyna, i zauważasz złodzieja który w ręku ma złoty zegarek, twój zegarek" << endl;
                        cout << "Co robisz ?" << endl << "[1] Zaciągam siłą złodzieja na policję" << endl << "[2] Sam wymierzam sprawiedliwość" << endl;

                        cout << "> ";
                        cin >> number;

                        if (number == 1){
                            cout << "Złodziej zaczął się wyrywać więc postanowiłeś go ogłuszyć i zaczynasz ciągnąć go na najbliższy komisariat" << endl;
                            cout << "Po drodze spotykasz strażnika który patrzy się dość dziwnie na to co robisz "<< endl;
                            cout << "[1] Zaczynasz się tłumaczyć że sam złapałeś złodzieja ponieważ wiesz że Straż i tak by nic nie zrobiła" << endl; 
                            cout << "[2] Chciałeś przyśpieszyć działanie Straży łapiąc złodzieja" << endl;

                            cout << "> ";
                            cin >> number ;

                            if(number == 1){
                                cout << "Za obrazę Straży zostajesz skazany na rok więzienia" << endl;
                                cout << "Nie dość że nie odzyskałeś zegarka, to jeszcze skończyłeś w więzieniu" << endl << "Dość słabe zakończenie , nieprawdzaż ?" << endl;
                                printf("KONIEC GRY");
                            }
                        }
                        else if(number == 2){
                            cout << "Postanawiasz sam odebrać coś co do ciebie należy , niestety bandyta nie chce oddać TWOJEJ własności ";
                            cout << "Uderzasz go więc drewnianą laską: " << endl ;
                            cout << "Odzyskałeś swój zegarek jednak uderzenie było zbyt mocne a złodziej zmarł na miejscu" << endl;
                            printf("KONIEC GRY");
                            
                        }
                        
                        }
                    }
                }
                    else if (number == 2){
                        cout << "Poszedłeś do lombardu i kupiłeś w miarę tani, ładny zegarek" << endl;
                        cout << "Zegarek trafił w ręce bogatego arystokraty" << endl;
                        printf("KONIEC GRY");
                        cout << endl << "[1] Gram od nowa" << endl << "[2] end" << endl;

                            cout << "> ";
                            cin >> number;
                            if (number == 1){
                               goto exit;
                            }
                            else {
                                exit;
                            }
                    }


                
                else if(number == 3){
                    cout << "Zostałeś okradziony prawdopodobnie przez nieuwagę grając w karty" << endl;
                    cout << "Albo byłeś zbyt pijany by myśleć, a złodziej wykorzystał okazję" << endl;
                    goto exit;
                    
                }  
            }
        }
        else if (number == 2){
            cout << "Jesteś złodziejem i właśnie przechadzasz się po karczmie gdy nagle zobaczyłeś bogatego podróżnika który ma na sobie złoty zegarek" << endl;
            cout << "[1] Chcę go ukraść, przecież kupiec kupi sobie drugi" << endl << "[2] Nie będe okradał nowopoznanego kupca , to nie w moim stylu" << endl;
            
            cout << "> ";
            cin >> number;
            ree:
                if(number == 1){
                cout << "Czekasz więc aż kupiec będzie wystarczająco pijany, by nie zauważyć braku zegarka" << endl;

                cout << "Mija kilkanaście minut ,podróżnik jest już tak pijany że nie zauważy braku zegarka";

                cout << "Naprawdę chcesz to zrobić?" << endl;
                cout << "[1] Nie " << "[2] Tak " <<  endl;

                cout << "> ";
                cin >> number;

                    if (number == 1){
                        cout << "Podchodzisz do niego, pytasz o cel podróży. Gdy zaczyna bełkotać o swoich podrózach , udajesz że się potykasz i ściągasz mu zegarek z dłoni" << endl;
                        cout << "Widzisz jednak że jednak podróżnik nie jest aż tak pijany i zaczyna ciągnąć cię za ręke i wołać straż" << endl;
                        cout << "[1] Poddaję się!" << endl << "[2] Liczę na moje szczęście i próbuję uciec"<< endl;

                        cout << "> ";
                        cin >> number;

                        if(number == 1){
                            cout << "Za próbę kradzieży idziesz do więzienia na 5 lat" << endl;
                            printf("Koniec gry!");
                            cout << endl << "[1] Gram od nowa" << endl << "[2] end" << endl;

                            cout << "> ";
                            cin >> number;
                            if (number == 1){
                               goto exit;
                            }
                            else {
                                exit;
                            }
                        }
                        else if(number == 2){
                            cout << "Wybiegasz przed karczmę lecz upadasz na śliskiej kostce brukowej" << endl;
                            cout << "Zostajesz złapany i idziesz do więzienia " << endl;
                            printf("Koniec Gry!");
                            cout << endl << "[1] Gram od nowa" << endl << "[2] end" << endl;

                            cout << "> ";
                            cin >> number;
                            if (number == 1){
                               goto exit;
                            }
                            else {
                                exit;
                            }

                            }
                            }
                        }
                else if (number == 2){
                        cout << "Śledzisz kupca w drodze o jego pokoju, aż w końcu dociera do swojego pokoju." << endl;
                        cout << "Zamknął drzwi ale Ty, jako dobry złodziej mógłbyś włamać się do jego pokoju" << endl;
                        cout << "[1] Wchodzę przez otwarte okno" << endl << "[2] Wytrychem otwieram jego drzwi i po cichu się włamuję" << endl;

                        cout << "> ";
                        cin >> number;

                        if(number == 1){
                            cout << "Wspinasz się po zabudowaniu do właściwego okna, po czym otwierasz je i wchodzisz do pomieszczenia" << endl;
                            cout << "Po cichu docierasz do łóżka. Dostrzegasz zegarek na półce, postanawiasz go sobie wziąć" << endl;
                            cout << "Wychodzisz tak jak wszedłeś, starając się nie spaśc" << endl ;
                            cout << "[1] Nazajutrz staram się sprzedać jak najszybciej zegarek" << endl << "[2] Czekam kilka dni aby nie wzbudzać podejrzeń" << endl;
                            cin >> number;

                            if(number == 1){
                                cout << "Idziesz do lombardu, aby jak najszybciej pozbyć się problemu, lecz straż już tam jest" << endl;
                                cout << "Przez Twoją nieuwagę, zostałeś złapany i skazany na 2 lata więzienia" << endl;
                                printf("Koniec Gry !");
                                cout << endl << "[1] Gram od nowa" << endl << "[2] end" << endl;

                                cout << "> ";
                                cin >> number;
                                if (number == 1){
                                    goto exit;
                                }
                                else {
                                    exit;
                                }
                            }
                        
                            else if(number == 2){
                                cout << "Czekasz 13 dni aby sprawa kradzieży ucichła i sprzedajesz bez przeszkód zegarek" << endl;
                                cout << "Otrzymujesz za niego 2000 monet, czyli opłacało się go ukraść" << endl;
                                cout << "Za te pieniądze uciekasz do innego kraju i tam kontynuujesz włamania" << endl;
                                printf("Koniec Gry !");
                                cout << endl << "[1] Gram od nowa" << endl << "[2] end" << endl;

                                cout << ">" ;
                                cin >> number;
                                if (number == 1){
                                    goto exit;
                                }
                                else {
                                    exit;
                                }
                            }
                            }   
                        else if (number == 2){
                            cout << "Włamujesz się do pokoju i od razu widzisz na szafce nocnej niepilnoway zegarek" << endl;
                            cout << "Kradniesz zegarek i bezszelestnie wychodzisz z pokoju" << endl;
                            cout << "[1]Postanawiam poczekać ze sprzedażą" << endl << "[2]Sprzedam go od razu, przecież mnie nie złapią" << endl;

                            cout << ">" ;
                            cin >> number;

                            if (number == 1){
                                cout << "Czekasz tydzień i sprzedajesz go za 1000 monet" << endl;
                                printf("Koniec Gry !");
                                cout << endl <<"[1] Gram od nowa" << endl << "[2] end" << endl;

                                cout << ">" ;
                                cin >> number;
                                if (number == 1){
                                    goto exit;
                                }
                                else {
                                    exit;
                                }

                            }
                            else if(number == 2){
                                cout << "Zostajesz złapany nazajutrz, lecz tak ukryłeś zegarek, że strażnicy nigdy go nie znajdą" << endl;
                                cout << "Zostajesz uniewinniony, ponieważ straż nie ma dowodów że to TY UKRADŁEŚ zegarek" << endl;
                                printf("Koniec Gry !");
                                cout << endl << "[1] Gram od nowa" << endl << "[2] end" << endl;

                                cout << ">" ;
                                cin >> number;
                                if (number == 1){
                                    goto exit;
                                }
                                else {
                                    exit;
                                }
                            }   
                        }
                     }
                }
                        
                    
                    
                
                  

    else if (number == 3){
        cout << "WCISNĄŁEŚ [7], " << endl;
        cout << "- Wędrowiec : jest sprytny, jest dobrym kupcem, zna dobrze świat. Nie potrafi się bić, lecz jest doskonałym podróźnikiem." << endl;
        cout << "- Złodziej : nie jest zbyt inteligentny, lecz nadrabia to sprytem. Potrafi szybko się przemieszczać i uciekać." << endl;


        goto exit;
        } 
    else {
        exit(0);
    }             


}


