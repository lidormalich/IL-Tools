@echo off
adb wait-for-device
adb shell pm uninstall -k --user 0 com.huawei.retaildemo
adb shell pm uninstall -k --user 0 com.huawei.retail.assistant
adb shell pm uninstall -k --user 0 com.booking
adb shell pm uninstall -k --user 0 com.huawei.experience.ec
adb shell pm uninstall -k --user 0 com.android.managedprovisioning
adb shell pm uninstall -k --user 0 com.gamious.briquidmini
adb shell pm uninstall -k --user 0 com.gamious.lines
adb shell pm uninstall -k --user 0 com.microfun.munchkin.test
adb shell pm uninstall -k --user 0 com.vectorunit.silver.demo
adb shell pm uninstall -k --user 0 com.neuralprisma.huawei.retail
adb reboot
pause

