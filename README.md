# Tic-Tac-Toe

###Семинарска по предметот: Визуелно Програмрање

Играта Х-О (Икс-Точка) е наменета за двајца играчи  и  се состои од наизменични последователни нивни потези.  Потезите се всушност клик/избор на поле од таблата при при што едниот играч  е претставен со Х а другиот со О.  

 Секое стартување на играта ни бара внес на имињата на соодветните играчи. Дополнителна прецизност во играта е воведена со можност за избор на време кое му се доделува на секој играч и за тоа време тој мора да заврши со своите потези (минимално време е 5 секунди).   
 Една игра всушност се состои од повеќе рунди  во кои играчите собираат поени во зависност од победите се додека не се достигне потребниот број на поени за победа и се прогласува победник (тој број е 10, а може и да се смени пред да се започне со играње). Играчите можат да изберат и некоја од предефинираните парови бои за играта. Откако ќе започне играта - на потег е првиот играч **(Х)** чие што преостанато време се прикажува на *Progress Bar*, исто и за вториот играч во текот на целата игра.  
   
     
     
За да се победи во една рунда потребно е да се формира линија хоризонтано, вертикално или дијагонално со ист знак  и соодветниот играч добива +1 поен за победа .  
<img src="https://fbcdn-sphotos-a-a.akamaihd.net/hphotos-ak-frc3/292476_459947164083622_1617211580_n.jpg" width="400" height="200" />
<img src="https://fbcdn-sphotos-e-a.akamaihd.net/hphotos-ak-ash3/253214_459947170750288_1806133947_n.jpg" width="400" height="200" />

Доколку сите полиња се пополнат и немаме победник имаме ситуација *Draw* (нерешено) и никој не добива поени ниту пак губи.  
Но доколку времето на некој од играчите истече пред да се пополнат сите полиња или да имаме победа од поените на тој играч се одземаат  0,5 поени. 
 
Во текот на целата игра од страна покрај таблата во *Score Board* се води евиденција за поените на двата играчи и бројот на нерешени игри. Исто така во долниот дел од прозорецот  во лабела се прикажува која рунда се игра, чиј ред е во секој момент од времето како и бројот на избрани поени за победа. Откако ќе се постигне бројот на поени за победа од страна на некој играч се прикажува *MessageBox* со порака кој е победникот во играта.

**Имплемнтација:**  

На формата за играње се поставени 9 копчиња врз кои се испишува соодветниот знак. Во зависност од тоа кое копче е кликнато во позадина се чува матрица од знаци (Х и О). Со клик на било кое копче се повикува настанот `btn_click()` кој напрво проверува кое копче го иницирало  настанот и ја пополнува матрицата со соодветниот знак на соодветното поле. По направената промена се повикува функцијата `isWonGame()`  која проверува дали тој клик доведува до победа. Доколку да, се инкрементира бројот на поени на играчот кој бил на ред. Доколку нема победа се проверува дали можеби рундата завршила нерешено со повик на функцијата `isGameDraw()` . Ако и оваа функција врати *false* значи дека не е завршена рундата и се прави промена на следниот играч (се менуваат *nextChar* и *nextColor*).  

Функцијата `isWonGame()` која проверува дали има победа всушност проверува дали имаме ист знак долж една редица или колона или пак дијагонала. Најпрво се проверува за крстот (средишната редица и колона) и дијагоналите, а потоа исто и за првата редица/колона и последната редица/колона. Доколку има победа некаде се враќа true инаку *false*.  
  
  **Изработиле:**
  1. Доналд Димитриовски - 117007  
  2. Дијана Стефановска - 115061  
  3. Кристина Груевска - 115017

 
