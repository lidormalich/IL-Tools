@echo off
TITLE idoneapps
echo Reverse Engineering Your Digital World!
echo:
echo Unlock app installer for Combination ROMs.
echo:
adb kill-server >NUL

:installcomboapk
adb install -r unlock.apk >NUL || goto installcomboapk
echo install DONE!!!
echo:
echo Starting Unlock app....
echo:
adb shell am start -a android.intent.action.MAIN -n com.idoneapps.ssaunlock/.GETRoot >NUL
pause
echo Bye...