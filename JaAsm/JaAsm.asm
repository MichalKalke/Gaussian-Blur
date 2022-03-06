
.code
wl = 0 ; inicjowanie zmiennych pomocniczych
i = 4
wu = 8
wIdeal = 16
mIdeal = 24
m = 32
sigma = 64
n = 72
tab = 80
GaussBoxes PROC
start:
  mov DWORD PTR [rsp+32], r9d ; Przypisanie ze stosu 4 przekazanej zmiennej do rejestru 32 bitowego rejestru r9d
  mov QWORD PTR [rsp+24], r8 ; Przypisanie ze stosu 3 przekazanej zmiennej do rejestru r8 
  mov DWORD PTR [rsp+16], edx ; Przypisanie ze stosu 2 zmiennej przekazanej do rejestru edx
  mov DWORD PTR [rsp+8], ecx ; Przypisanie ze stosu  zmiennej przekazanej do rejestru ecx

  sub rsp, 56 ; Przesuni�cie wska�nika stosu
  imul eax, DWORD PTR sigma[rsp], 12 ; Pomno�enie 12*sigma
  imul eax, DWORD PTR sigma[rsp] ; Pomno�enie ponownie warto�ci w akumulatorze przez  sigm�
  cdq ; Konwersja podw�jnego s�owa na poczw�rne
  idiv DWORD PTR n[rsp] ; Podzielenie warto�ci akumulatora przez zmienn� n;
  inc eax ; Inkrementacja warto�ci w rejestrze eax
  cvtsi2sd xmm0, eax ; Konwersja integera do warto�ci skalarnej, zmiennoprzecinkowej oraz za�adowanie warto�ci z rejestru eax do xmm0
  sqrtsd xmm0, xmm0 ; Pierwiastek z wIdeal
  movsd   QWORD PTR wIdeal[rsp], xmm0 ; Za�adowanie warto�ci do zmiennej wIdeal z rejestru xmm0
        cvttsd2si eax, QWORD PTR wIdeal[rsp] ; Konwersja wraz z zaokr�gleniem do liczby ca�kowitej ze znakiem
        mov     DWORD PTR wl[rsp], eax ; Za�adowanie zmiennej wl do rejestru eax
        cdq ; Konwersja podw�jnego s�owa na poczw�rne

        xor     eax, edx ;  // if (wl % 2 == 0) wl--
        sub     eax, edx ; Odj�cie warto�ci //        test eax, eax
        jne       zmiennaMIdeal
        mov     eax, DWORD PTR wl[rsp] ; Za�adowanie warto�ci wl do akumulatora
        dec     eax ; Dekrementacja zmiennej wl
        mov     DWORD PTR wl[rsp], eax ; Za�adowanie zmiennej wl z akmulatora
 zmiennaMIdeal:
        mov     eax, DWORD PTR wl[rsp] ; Za�adowanie do akumulatora zmiennej wl
        add     eax, 2 ; Dodanie do akumulatora liczby 2
        mov     DWORD PTR wu[rsp], eax ; Za�adowanie do zmiennej wu warto�ci akumulatora

        imul    eax, DWORD PTR sigma[rsp], 12 ;  Pomno�enie warto�ci sigma przez 12 i za�adowanie jej do akumulatora
        imul    eax, DWORD PTR sigma[rsp] ; Ponowne pomno�enie warto�ci akumulatora przez sigm�
        mov     ecx, DWORD PTR n[rsp] ; Za�adowanie zmiennej n do rejestru ecx
        imul    ecx, DWORD PTR wl[rsp] ; Pomno�enie warto�ci rejestru ecx przez zmienn� wl
        imul    ecx, DWORD PTR wl[rsp] ; Ponowne pomno�enie warto�ci rejestru ecx przez zmienn� wl
        sub     eax, ecx ; Odj�cie od warto�ci akumulatora warto�� rejestru ecx 
        mov     ecx, DWORD PTR n[rsp] ; Za�adowanie akumulatora zmienn� n
        shl     ecx, 2 ; przesuni�cie bitowe w lewo o 2 miejsca rejestru ecx
        imul    ecx, DWORD PTR wl[rsp] ; Pomno�enie warto�ci rejestru ecx przez wl
        sub     eax, ecx ; Odj�cie od warto�ci akumulatora warto�� rejestru ecx 
        imul    ecx, DWORD PTR n[rsp], 3 ; Pomno�enie 3*n i wpisanie do rejestru ecx
        sub     eax, ecx ; Odj�cie od akumulatora warto�ci w ecx
        cvtsi2sd xmm0, eax ; Konwersja integera do warto�ci skalarnej, zmiennoprzecinkowej oraz za�adowanie warto�ci z rejestru eax do xmm0
        imul    eax, DWORD PTR wl[rsp], -4 ; Pomno�enie -4*wl i wpisanie do akmulatora
        sub     eax, 4 ; Odj�cie od akumulatora warto�ci 4
        cvtsi2sd xmm1, eax ; Konwersja integera do warto�ci skalarnej, zmiennoprzecinkowej oraz za�adowanie warto�ci z rejestru eax do xmm1
        divsd   xmm0, xmm1 ; Podzielenie warto�ci rejestr�w xmm0 oraz xmm1
        movsd   QWORD PTR mIdeal[rsp], xmm0 ; Za�adowanie wyniku dzielenia do zmiennej mIdeal
        movsd   xmm0, QWORD PTR mIdeal[rsp] ; za�adowanie xmm0 warto�cia mIdeal
        movsd   QWORD PTR m[rsp], xmm0 ; za�adowanie zmiennej m warto�ci� rejestru xmm0
        mov     DWORD PTR i[rsp], 0 ; Za�adowanie do zmiennej i warto�ci 0
        jmp    zapelnianieTablicy ; Tutaj rozpoczyna si� p�tla, kt�ra �aduje elementy do tablicy
tablica:
        mov     eax, DWORD PTR i[rsp] ; Za�adowanie do akumulatora zmiennej i
        inc     eax ; Inkrementowanie warto�ci akumulatora
        mov     DWORD PTR i[rsp], eax ; Za�adowanie warto�ci akumulatora do zmiennej i 
zapelnianieTablicy:
        mov     eax, DWORD PTR n[rsp] ; Za�adowanie warto�ci n do akumulatora
        cmp     DWORD PTR i[rsp], eax ; Por�wnanie warto�ci zmiennej i i warto�ci akumulatora 
        jge     koniec ; skok je�li wi�ksze lub r�wne
        cvtsi2sd xmm0, DWORD PTR i[rsp] ; Konwersja integera do warto�ci skalarnej, zmiennoprzecinkowej oraz za�adowanie warto�ci zmiennej i do xmm0
        movsd   xmm1, QWORD PTR m[rsp] ; Za�adowanie xmm1 warto�ci� m
        comisd  xmm1, xmm0 ; Por�wnanie warto�ci xmm1 i xmm0
        jbe     zmiennaWu ; Skok je�li mniejsze b�d� r�wne
        movsxd  rax, DWORD PTR i[rsp] ; Za�adowanie i do rax
        mov     rcx, QWORD PTR tab[rsp] ; Za�adowanie tab do rejestru rcx
        mov     edx, DWORD PTR wl[rsp] ; Za�adowanie zmiennej wl do rejestru edx
        mov     DWORD PTR [rcx+rax*4], edx ; Za�adowanie warto�ci rejestru edx do adresu rcx+rax*4
        jmp     tablica2 ; Skok bezwarunkowy do etykiety
zmiennaWu:
        movsxd  rax, DWORD PTR i[rsp] ; Za�adowanie do rax warto�ci i
        mov     rcx, QWORD PTR tab[rsp] ; Za�adowanie rejestru rcx warto�ci� w zmiennej tab
        mov     edx, DWORD PTR wu[rsp] ; Za�adowanie zmiennej wu do rejestru edx
        mov     DWORD PTR [rcx+rax*4], edx ; Za�adowanie warto�ci rejestru edx do adresu rcx+rax*4
tablica2:
        jmp   tablica ; Skok bezwarunkowy do etykiety
koniec:
        movsd   xmm0, QWORD PTR wIdeal[rsp] ; Za�adowanie zmiennej wIdeal do xmm0
        add     rsp, 56 ; Przesuni�cie wska�nika stosu na g�r�                         
        ret     0 ; Zwr�cenie warto�ci wIdeal
GaussBoxes ENDP ; boxesForGauss
end
