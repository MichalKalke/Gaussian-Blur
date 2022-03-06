
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

  sub rsp, 56 ; Przesuniêcie wskaŸnika stosu
  imul eax, DWORD PTR sigma[rsp], 12 ; Pomno¿enie 12*sigma
  imul eax, DWORD PTR sigma[rsp] ; Pomno¿enie ponownie wartoœci w akumulatorze przez  sigmê
  cdq ; Konwersja podwójnego s³owa na poczwórne
  idiv DWORD PTR n[rsp] ; Podzielenie wartoœci akumulatora przez zmienn¹ n;
  inc eax ; Inkrementacja wartoœci w rejestrze eax
  cvtsi2sd xmm0, eax ; Konwersja integera do wartoœci skalarnej, zmiennoprzecinkowej oraz za³adowanie wartoœci z rejestru eax do xmm0
  sqrtsd xmm0, xmm0 ; Pierwiastek z wIdeal
  movsd   QWORD PTR wIdeal[rsp], xmm0 ; Za³adowanie wartoœci do zmiennej wIdeal z rejestru xmm0
        cvttsd2si eax, QWORD PTR wIdeal[rsp] ; Konwersja wraz z zaokr¹gleniem do liczby ca³kowitej ze znakiem
        mov     DWORD PTR wl[rsp], eax ; Za³adowanie zmiennej wl do rejestru eax
        cdq ; Konwersja podwójnego s³owa na poczwórne

        xor     eax, edx ;  // if (wl % 2 == 0) wl--
        sub     eax, edx ; Odjêcie wartoœci //        test eax, eax
        jne       zmiennaMIdeal
        mov     eax, DWORD PTR wl[rsp] ; Za³adowanie wartoœci wl do akumulatora
        dec     eax ; Dekrementacja zmiennej wl
        mov     DWORD PTR wl[rsp], eax ; Za³adowanie zmiennej wl z akmulatora
 zmiennaMIdeal:
        mov     eax, DWORD PTR wl[rsp] ; Za³adowanie do akumulatora zmiennej wl
        add     eax, 2 ; Dodanie do akumulatora liczby 2
        mov     DWORD PTR wu[rsp], eax ; Za³adowanie do zmiennej wu wartoœci akumulatora

        imul    eax, DWORD PTR sigma[rsp], 12 ;  Pomno¿enie wartoœci sigma przez 12 i za³adowanie jej do akumulatora
        imul    eax, DWORD PTR sigma[rsp] ; Ponowne pomno¿enie wartoœci akumulatora przez sigmê
        mov     ecx, DWORD PTR n[rsp] ; Za³adowanie zmiennej n do rejestru ecx
        imul    ecx, DWORD PTR wl[rsp] ; Pomno¿enie wartoœci rejestru ecx przez zmienn¹ wl
        imul    ecx, DWORD PTR wl[rsp] ; Ponowne pomno¿enie wartoœci rejestru ecx przez zmienn¹ wl
        sub     eax, ecx ; Odjêcie od wartoœci akumulatora wartoœæ rejestru ecx 
        mov     ecx, DWORD PTR n[rsp] ; Za³adowanie akumulatora zmienn¹ n
        shl     ecx, 2 ; przesuniêcie bitowe w lewo o 2 miejsca rejestru ecx
        imul    ecx, DWORD PTR wl[rsp] ; Pomno¿enie wartoœci rejestru ecx przez wl
        sub     eax, ecx ; Odjêcie od wartoœci akumulatora wartoœæ rejestru ecx 
        imul    ecx, DWORD PTR n[rsp], 3 ; Pomno¿enie 3*n i wpisanie do rejestru ecx
        sub     eax, ecx ; Odjêcie od akumulatora wartoœci w ecx
        cvtsi2sd xmm0, eax ; Konwersja integera do wartoœci skalarnej, zmiennoprzecinkowej oraz za³adowanie wartoœci z rejestru eax do xmm0
        imul    eax, DWORD PTR wl[rsp], -4 ; Pomno¿enie -4*wl i wpisanie do akmulatora
        sub     eax, 4 ; Odjêcie od akumulatora wartoœci 4
        cvtsi2sd xmm1, eax ; Konwersja integera do wartoœci skalarnej, zmiennoprzecinkowej oraz za³adowanie wartoœci z rejestru eax do xmm1
        divsd   xmm0, xmm1 ; Podzielenie wartoœci rejestrów xmm0 oraz xmm1
        movsd   QWORD PTR mIdeal[rsp], xmm0 ; Za³adowanie wyniku dzielenia do zmiennej mIdeal
        movsd   xmm0, QWORD PTR mIdeal[rsp] ; za³adowanie xmm0 wartoœcia mIdeal
        movsd   QWORD PTR m[rsp], xmm0 ; za³adowanie zmiennej m wartoœci¹ rejestru xmm0
        mov     DWORD PTR i[rsp], 0 ; Za³adowanie do zmiennej i wartoœci 0
        jmp    zapelnianieTablicy ; Tutaj rozpoczyna siê pêtla, która ³aduje elementy do tablicy
tablica:
        mov     eax, DWORD PTR i[rsp] ; Za³adowanie do akumulatora zmiennej i
        inc     eax ; Inkrementowanie wartoœci akumulatora
        mov     DWORD PTR i[rsp], eax ; Za³adowanie wartoœci akumulatora do zmiennej i 
zapelnianieTablicy:
        mov     eax, DWORD PTR n[rsp] ; Za³adowanie wartoœci n do akumulatora
        cmp     DWORD PTR i[rsp], eax ; Porównanie wartoœci zmiennej i i wartoœci akumulatora 
        jge     koniec ; skok jeœli wiêksze lub równe
        cvtsi2sd xmm0, DWORD PTR i[rsp] ; Konwersja integera do wartoœci skalarnej, zmiennoprzecinkowej oraz za³adowanie wartoœci zmiennej i do xmm0
        movsd   xmm1, QWORD PTR m[rsp] ; Za³adowanie xmm1 wartoœci¹ m
        comisd  xmm1, xmm0 ; Porównanie wartoœci xmm1 i xmm0
        jbe     zmiennaWu ; Skok jeœli mniejsze b¹dŸ równe
        movsxd  rax, DWORD PTR i[rsp] ; Za³adowanie i do rax
        mov     rcx, QWORD PTR tab[rsp] ; Za³adowanie tab do rejestru rcx
        mov     edx, DWORD PTR wl[rsp] ; Za³adowanie zmiennej wl do rejestru edx
        mov     DWORD PTR [rcx+rax*4], edx ; Za³adowanie wartoœci rejestru edx do adresu rcx+rax*4
        jmp     tablica2 ; Skok bezwarunkowy do etykiety
zmiennaWu:
        movsxd  rax, DWORD PTR i[rsp] ; Za³adowanie do rax wartoœci i
        mov     rcx, QWORD PTR tab[rsp] ; Za³adowanie rejestru rcx wartoœci¹ w zmiennej tab
        mov     edx, DWORD PTR wu[rsp] ; Za³adowanie zmiennej wu do rejestru edx
        mov     DWORD PTR [rcx+rax*4], edx ; Za³adowanie wartoœci rejestru edx do adresu rcx+rax*4
tablica2:
        jmp   tablica ; Skok bezwarunkowy do etykiety
koniec:
        movsd   xmm0, QWORD PTR wIdeal[rsp] ; Za³adowanie zmiennej wIdeal do xmm0
        add     rsp, 56 ; Przesuniêcie wskaŸnika stosu na górê                         
        ret     0 ; Zwrócenie wartoœci wIdeal
GaussBoxes ENDP ; boxesForGauss
end
