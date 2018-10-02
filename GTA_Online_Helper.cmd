@ECHO OFF
chcp 65001 > NUL
echo off
title GTA Online helper v0.1
set storagecount=1
set storagespace=16
set boxcount=3
set timetobox=5
cls
if "%maximize%" == "yes" (goto logo) else (set maximize=yes&&title Launcher&&start /max GTA_Online_Helper.cmd&&exit)
color 09
:logo
echo.                                                                                                                                           
echo.                                                                                                                                           
echo.                                                                                                                                           
echo.                                                                                                                                           
echo.                                                                                                                                           
echo.         ░▓▓▓▒░ ░▓▓▓▓▓▓▓▒   ▓▓          ░▓▓▓▒            ░▓  ▒▓                    ░▓░    ░▓░ ░▓▓▓▓▓▓░ ▒▒      ▓▓▓▓░░  ░▓▓▓▓▓▓  ▒▓▓▓▒░     
echo.       ▓▓░    ▒░    ▓░     ▒▓▓▓       ▓▓░   ░▓▓          ░▓                        ░▓░    ░▓░ ░▓░      ▓▓      ▓░  ░▓▓ ▒▓░      ▓▒   ▓▓    
echo.      ░▓░           ▓░    ░▓░░▓░     ░▓░      ▓▓ ▒▓▓▓▓▓░ ░▓  ▒▓  ▓▒▓▓▓▒  ▒▓▓▓▓░    ░▓░    ░▓░ ░▓░      ▓▓      ▓░   ▓▓ ▒▓░      ▓▒   ▓▓    
echo.      ░▓    ▓▓▓▒    ▓░   ░▓░  ░▓░    ░▓       ▓▓ ▒▓   ▓▓ ░▓  ▒▓  ▓░   ▓░░▓░░░░▓░   ░▓░░░░░░▓░ ░▓░░░░░  ▓▓      ▓▓▓▓▓░  ▒▓░░░░░  ▓▓▓▓▒░     
echo.       ▓▓     ▓▒    ▓░   ▓▓    ▒▓░    ▓▓     ▒▓░ ▒▓   ▓▓ ░▓  ▒▓  ▓░   ▓░░▓░        ░▓░    ░▓░ ░▓░      ▓▓      ▓░      ▒▓░      ▓▒  ▒▓░    
echo.        ░▒▓▓▓▓▒░    ▓░  ▓▓      ▓▓     ░▒▓▓▓▓░   ▒▓   ▓▓ ░▓  ▒▓  ▓░   ▓░ ░▒▓▓▓░    ░▓░    ░▓░ ░▓▓▓▓▓▓░ ▓▓▓▓▓▓░ ▓░      ▒▓▓▓▓▓▓  ▓▒   ░▓▓   
echo.                                                                                                                                           
echo.                                                                                                                                           
echo.                                                                                                                                           
echo.                                                                                                                                           
echo.                                                               ▓░                                                                          
echo.                                                               ▓░░▒░░ ░░   ░░░                                                             
echo.                                                               ▓▒  ░▓▒░▓░  ▓▒                                                              
echo.                                                               ▓░   ▓▓ ░▓░▓▒                                                               
echo.                                                               ▓▓░░▓▓░  ░▓▓                                                                
echo.                                                                        ░▓                                                                 
echo.                                                                       ░░                                                                  
echo.                                                                                                                                           
echo.                                                                                                                                           
echo.                                ▓▓       ▒▓▓▓▓░   ░▓░     ▓░ ░▓▓▓▓▓▒░     ░▓▓▓▓▒░   ▓▓     ▒▓  ░▓░  ░▓▓▓▓░░▓▓▓▓▓▓▓▓                        
echo.                                ▓▓     ▒▓░    ▒▓░ ░▓▓▒    ▓░ ░▓░    ▒▓░  ▓▒    ░▓▓  ▓▓▓░   ▒▓  ░▓░ ░▓         ▓▒                           
echo.                                ▓▓    ░▓░      ▒▓ ░▓ ▒▓░  ▓░ ░▓░     ▒▓ ▓▓      ░▓░ ▓▓░▓▓  ▒▓  ░▓░ ░▓▓▒░      ▓▒                           
echo.                                ▓▓    ░▓░      ▒▓ ░▓  ░▓▒ ▓░ ░▓░     ▒▓ ▓▓      ░▓▒ ▓▓  ▒▓░▒▓  ░▓░    ░░▓▒    ▓▒                           
echo.                                ▓▓     ▒▓░    ▒▓░ ░▓    ▒▓▓░ ░▓░    ▒▓░  ▓▒    ░▓▓  ▓▓   ░▓▓▓  ░▓░ ░░   ▒▓    ▓▒                           
echo.                                ▓▓▓▓▓▓░  ▒▓▓▓▓░   ░▓     ░▓░ ░▓▓▓▓▓▒░     ░▓▓▓▓▒░   ▓▓     ▒▓  ░▓░ ░▒▓▓▓░     ▓▒                           
echo.                                                                                                                                           
echo.                                                                                                                                           
echo.                                                                                                                                           
echo.                                                                                                                                           




mshta "about:<script>alert('Инструкция по эксплуатации:\n В главном меню необходимо выбрать нужный вам пункт и нажать ENTER.\n В некоторых разделах есть предустановленная информация типа: 16.\n Если ее значение вас устраивает, то ничего не вводите и нажмите ENTER.');close()</script>"
:main
cls
echo Выберите нужный вам раздел:
echo.
echo [0]  Exit
echo [1]  Работа босса (SecureServ)
echo [2]  Доставка ящиков (SecureServ)
echo [3]  Торговля транспортом (SecureServ)
echo [4]  Мотоклубы [IN DEV]
echo [5]  Ночные клубы [IN DEV]
echo [6]  Ограбления
echo [7]  Информация о скрипте
set /p main=Введите номер: 

if %main% == 1 (goto ss-boss)
if %main% == 2 (goto ss-rus-mail)
if %main% == 3 (goto ss-rob-car)
if %main% == 4 (goto moto)
if %main% == 5 (goto night-club)
if %main% == 6 (goto robbery)
if %main% == 7 (goto info)
if %main% == 0 (exit) else (mshta "about:<script>alert('Модуль не существует, либо не найден.\nПроверьте введенные вами данные: %main%');close()</script>"&&goto main)


:ss-boss
mshta "about:<script>alert('В разработке. Ждите обновление.');close()</script>"
goto main

:ss-rus-mail
cls
set /p storagecount=Введите количество складов [ %storagecount% ]: 
cls
set /p storagespace=Введите емкость складов [ %storagespace% ]: 
cls
set /p boxcount=Введите количество ящиков за ходку [ %boxcount% ]: 
cls
set /p timetobox=Введите время 'в минутах', затрачиваемое на 1 ящик [ %timetobox% ]: 
cls
if %storagespace% LEQ 16 (goto ss-rus-mail-small)
if %storagespace% GEQ 16 if %storagespace% LEQ 42 (goto ss-rus-mail-medium)
if %storagespace% GEQ 42 if %storagespace% LEQ 110 (goto ss-rus-mail-large) else (mshta "about:<script>alert('Не существует склада такой вместимости!');close()</script>"&&goto main)

:ss-rus-mail-small
rem ssrms
set /a fullstoragespace=%storagespace%*%storagecount%
set /a fulltime=%fullstoragespace%*%timetobox%
if %boxcount% == 1 (set /a fullpay=%fullstoragespace%*2000&&goto ssrms-result)
if %boxcount% == 2 (set /a fullpay=%fullstoragespace%/2*8000&&goto ssrms-result)
if %boxcount% == 3 (goto ssrms-check)
:ssrms-check
if %storagecount% == 3 (goto ssrms0) else (goto ssrms1)
:ssrms0
set /a fullpay=%fullstoragespace%/3*18000
goto ssrms-result
:ssrms1
if %storagecount% == 5 (goto ssrms2) else (goto ssrms3)
:ssrms2
set /a fullpay=((((%fullstoragespace%-2)/3)*18000)+8000)
goto ssrms-result
:ssrms3
set /a fullpay=((((%fullstoragespace%-1)/3)*18000)+2000)
goto ssrms-result

:ssrms-result
mshta "about:<script>alert('Количество сладов: %storagecount%\nТип склада: неизвестно\nПрибыль: неизвестно\nКоличество ходок: неизвестно\nЗатраты по времени: %fulltime% минут\nВсего ящиков: %fullstoragespace%\nМатериальные затраты: %fullpay%$');close()</script>"
echo ==========%time%========== >> GTAHelperResult%date%.txt
echo Количество складов: %storagecount% >> GTAHelperResult%date%.txt
echo Тип склада: Малый склад >> GTAHelperResult%date%.txt
echo Прибыль: [IN DEV] >> GTAHelperResult%date%.txt
echo Количество ходок: [IN DEV] >> GTAHelperResult%date%.txt
echo Затраты по времени: %fulltime% минут >> GTAHelperResult%date%.txt
echo Всего ящиков: %fullstoragespace% >> GTAHelperResult%date%.txt
echo Материальные затраты: %fullpay%$ >> GTAHelperResult%date%.txt
pause
goto main

:ss-rus-mail-medium
set /a fullstoragespace=%storagespace%*%storagecount%
set /a fulltime=%fullstoragespace%*%timetobox%
if %boxcount% == 1 (set /a fullpay=%fullstoragespace%*2000&&goto ssrms-result)
if %boxcount% == 2 (set /a fullpay=%fullstoragespace%/2*8000&&goto ssrms-result)
if %boxcount% == 3 (set /a fullpay=%fullstoragespace%/3*18000&&goto ssrms-result)


goto ssrms-result

:ss-rus-mail-large
set /a fullstoragespace=%storagespace%*%storagecount%
set /a fulltime=%fullstoragespace%*%timetobox%
if %boxcount% == 1 (set /a fullpay=%fullstoragespace%*2000&&goto ssrms-result)
if %boxcount% == 2 (set /a fullpay=%fullstoragespace%/2*8000&&goto ssrms-result)
if %boxcount% == 3 (goto ssrml-check)
:ssrml-check
if %storagecount% == 5 (goto ssrml1) else (goto ssrml0)
:ssrml0
set /a fullpay=%fullstoragespace%/3*18000
goto ssrms-result
:ssrml1
set /a fullpay=((((%fullstoragespace%-1)/3)*18000)+2000)
goto ssrms-result

:ss-rob-car
mshta "about:<script>alert('В разработке. Ждите обновление.');close()</script>"
goto main

:moto
mshta "about:<script>alert('В разработке. Ждите обновление.');close()</script>"
goto main

:night-club
mshta "about:<script>alert('В разработке. Ждите обновление.');close()</script>"
goto main

:robbery
mshta "about:<script>alert('В разработке. Ждите обновление.');close()</script>"
goto main

:info
cls
echo [Информация о скрипте]
echo.
echo Разработчик: LondonistTV
echo.
echo Скрипты написаны: LondonistTV
echo.
echo Разделы 'Работа босса' и 'Доставка ящиков':
echo LondonistTV и клан RUNE
echo.
echo Раздел 'Торговля транспортом':
echo [В разработке]
echo.
echo Раздел 'Мотоклубы':
echo [В разработке]
echo.
echo Раздел 'Ночные клубы':
echo [В разработке]
echo.
echo Раздел 'Ограбления':
echo [В разработке]
pause
goto main

