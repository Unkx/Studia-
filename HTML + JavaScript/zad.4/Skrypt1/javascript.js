//Instrukcja if
const liczba = prompt("podaj liczbe")
if (liczba > 50){
    console.log("liczba jest większa od 50")
}
else {
    console.log("spierdalaj stary grzybie")
}
//Pętle for
for(let i = 0; i <10; i++)
{
    console.log(i)
}
//Pętle foreach
const pracownicy=['Jan','Janina','Alicja','Bob'];
pracownicy.forEach(function(element,nr,array){
    console.log(nr + ' ' + element);
});
//tablice
const tablica = [23,90,34];
//dostęp
console.log(tablica[1]);
console.log(tablica[2]);
//length
const tab=['Ala','Ania','Aga'];
console.log(tab.length);
console.log(tab [tab.length-1]);
//dodawanie elementów
tab.push('Jan');
console.log(tab);
//reverse
const tab1 = [1,2,3,4];
console.log(tab1)
tab1.reverse();
console.log(tab1);
//pętla po tablicy
const tab2 = ['Marcin', 'Aga', 'Paweł']
for (let i = 0; i < tab2.length;i++){
    console.log('licznik petli:' + i);
    console.log('element:' + tab2[i]);
}
//konstrukcja switch
const number = prompt('napisz jakiego masz zwierzaka');
switch (number){
    case 'pies' :
    console.log('psy są najlepsze');
    break;
    case 'kot' :
        console.log('koty są lepsze');
        break;
        default :
}