@echo off
@echo off
SHIFT /0
COLOR 0B
cls
mode con:cols=115 lines=40
Title ARABIC_SAMSUNG_ALL_NO_ROOT_BY►♣Lidor Malich♣◄
:sifan
CLS
echo.
bin\chgcolor 0e
echo.                            ==================~~oOOo~~====================
echo.                                   ********************************
bin\chgcolor 0f
echo.                                  hebrew_SAMSUNG_ALL_NO_ROOT_BY►♣Lidor Malich♣◄
echo.
echo.
bin\chgcolor 0e
echo.                          ****************************************************
bin\chgcolor 0a
echo. 
bin\chgcolor 0a
echo                           -----------------------------------------------------
echo                           -----------  Connet-Phone in ADB_Enable  ------------
echo                           -----------------------------------------------------
bin\chgcolor 0f
bin\adb wait-for-device >NUL 2>&1
for /f "tokens=*" %%a in ('bin\adb shell getprop ro.product.manufacturer') do set sifan4=%%a
for /f "tokens=*" %%a in ('bin\adb shell getprop ro.product.model') do set sifan=%%a
for /f "tokens=*" %%a in ('bin\adb shell getprop ro.build.version.release') do set sifan2=%%a
bin\chgcolor 0c
echo                           -----------------------------------------------------
bin\chgcolor 0e
echo                              Phone-%sifan4%____Model-%sifan%____Verion-%sifansifan2%   
bin\chgcolor 0c   
echo                           -----------------------------------------------------
echo.
setlocal
echo.
if "%sifan2%" == "5.0" goto 6.0
if "%sifan2%" == "5.0.0" goto 6.0
if "%sifan2%" == "5.0.1" goto 6.0
if "%sifan2%" == "5.1.1" goto 6.0
if "%sifan2%" == "5.1.2" goto 6.0
if "%sifan2%" == "6.0" goto 6.0
if "%sifan2%" == "6.0.0" goto 6.0
if "%sifan2%" == "6.0.1" goto 6.0
if "%sifan2%" == "6.1.1" goto 6.0
if "%sifan2%" == "6.1.2" goto 6.0
if "%sifan2%" == "7.0" goto 7.0
if "%sifan2%" == "7.0.0" goto 7.0
if "%sifan2%" == "7.0.1" goto 7.0
if "%sifan2%" == "7.1.1" goto 7.0
if "%sifan2%" == "7.1.2" goto 7.0
if "%sifan2%" == "8.0" goto 8.0
if "%sifan2%" == "8.0.0" goto 8.0
if "%sifan2%" == "8.0.1" goto 8.0
if "%sifan2%" == "8.1.0" goto 8.0
if "%sifan2%" == "8.1.1" goto 8.0
if "%sifan2%" == "8.1.2" goto 8.0
if "%sifan2%" == "9.0" goto 8.0
if "%sifan2%" == "9.0.0" goto 8.0
if "%sifan2%" == "9.0.1" goto 8.0
if "%sifan2%" == "9.1.1" goto 8.0
if "%sifan2%" == "9.1.2" goto 8.0

) else (
echo.
    echo [*] your device SW Version "%sifan2%" not supported This Script.
pause
    goto sifan
)

setlocal
echo.
:8.0
bin\chgcolor 0b
echo                           ----------------------------------------------------- 
bin\chgcolor 0e
echo                           -------------------   Please Wait   -----------------
bin\chgcolor 0b
echo                           ----------------------------------------------------- 
bin\adb install -r bin\8.0\1.apk
bin\adb install -r bin\8.0\2.apk
bin\adb install -r bin\8.0\3.apk
bin\adb install -r bin\8.0\4.apk
bin\adb install -r bin\8.0\5.apk
bin\adb install -r bin\8.0\6.apk
bin\adb install -r bin\8.0\7.apk
bin\adb install -r bin\8.0\8.apk
bin\adb reboot
bin\chgcolor 0b
echo                           -----------------------------------------------------
echo                           -------------------  All done  ----------------------
echo                           -----------------------------------------------------
pause
GOTO sifan2
:7.0
bin\chgcolor 0b
echo                           ----------------------------------------------------- 
bin\chgcolor 0e
echo                           -------------------   Please Wait   -----------------
bin\chgcolor 0b
echo                           ----------------------------------------------------- 
bin\chgcolor 0f
bin\adb wait-for-device >NUL 2>&1
bin\adb install -r bin\7.0\1.apk
bin\adb install -r bin\7.0\2.apk
bin\adb install -r bin\7.0\3.apk
bin\adb install -r bin\7.0\4.apk
bin\adb install -r bin\7.0\5.apk
bin\adb install -r bin\7.0\6.apk
bin\adb install -r bin\7.0\7.apk
bin\adb install -r bin\7.0\8.apk
bin\adb install -r bin\7.0\9.apk
bin\adb install -r bin\7.0\10.apk
bin\adb install -r bin\7.0\11.apk
bin\adb install -r bin\7.0\12.apk
bin\adb reboot
bin\chgcolor 0b
echo                           -----------------------------------------------------
echo                           -------------------  All done  ----------------------
echo                           -----------------------------------------------------
pause
GOTO sifan
:6.0
bin\chgcolor 0b
echo                           ----------------------------------------------------- 
bin\chgcolor 0e
echo                           -------------------   Please Wait   -----------------
bin\chgcolor 0b
echo                           ----------------------------------------------------- 
bin\chgcolor 0f
bin\adb wait-for-device >NUL 2>&1
bin\adb install -r bin\6.0\lng.apk
bin\adb install -r bin\6.0\1.apk 
bin\adb install -r bin\6.0\2.apk 
bin\adb install -r bin\6.0\3.apk 
bin\adb install -r bin\6.0\4.apk
bin\adb install -r bin\6.0\5.apk 
bin\adb install -r bin\6.0\6.apk 
bin\adb install -r bin\6.0\7.apk 
bin\adb install -r bin\6.0\8.apk 
bin\adb install -r bin\6.0\9.apk 
bin\adb install -r bin\6.0\10.apk 
adb shell pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION
adb shell am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language iw
adb uninstall net.sanapeli.adbchangelanguage
bin\adb reboot
bin\chgcolor 0b
echo                           -----------------------------------------------------
echo                           -------------------  All done  ----------------------
echo                           -----------------------------------------------------
pause
GOTO sifan