@shift /0
@ECHO OFF
@TITLE SAMSUNG
cls
COLOR 0B
mode con:cols=78 lines=40
echo Please waiting for devices....
@adb push txt /sdcard/
@adb shell mkdir /efs
@adb shell mount /dev/block/sda3 /efs
@adb shell mount /dev/block/mmcblk0p3 /efs
@adb shell mount /dev/block/mmcblk0p11 /efs
@adb shell mount /dev/block/mmcblk0p12 /efs
@adb shell mount /dev/block/mmcblk0p13 /efs
@adb shell mv /sdcard/*.txt /efs/sec_efs/sktdm_mem
@adb shell chmod 0400 /efs/sec_efs/sktdm_mem/*.txt
@adb shell chmod 0400 /efs/sec_efs/sktdm_mem
@adb shell chmod 0400 /efs/sec_efs
@adb reboot
