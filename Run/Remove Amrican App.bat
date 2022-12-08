@echo off
title Remove Amrican App -By Lidor Malich
adb kill-server
adb start-server
echo.
echo Waiting for device..
adb wait-for-device 
echo Remove T-Mobile App
adb shell pm uninstall -k --user 0 com.tmobile.simlock
adb shell pm uninstall -k --user 0 com.tmobile.pr.mytmobile
adb shell pm uninstall -k --user 0 com.tmobile.vvm.application
adb shell pm uninstall -k --user 0 com.tmobile.tuesdays
adb shell pm uninstall -k --user 0 com.mobitv.client.tmobiletvhd
adb shell pm uninstall -k --user 0 com.tmobile.digits
adb shell pm uninstall -k --user 0 com.tmobile.tct
adb shell pm uninstall -k --user 0 com.whitepages.nameid.tmobile
adb shell pm uninstall -k --user 0 com.tmobile.wifi
adb shell pm uninstall -k --user 0 com.tmobile.band12
adb shell pm uninstall -k --user 0 com.tmobile.familycontrols
adb shell pm uninstall -k --user 0 com.tmobile.services.nameid
adb shell pm uninstall -k --user 0 com.tmobile.syncupfleet.hos
adb shell pm uninstall -k --user 0 com.tmobile.callertunes
adb shell pm uninstall -k --user 0 com.tmobile.syncupfleet
adb shell pm uninstall -k --user 0 com.tmobile.techexperience
adb shell pm uninstall -k --user 0 com.tmobile.techexperience.arscanner
adb shell pm uninstall -k --user 0 com.tmobile.MobileInternetManagement.devices
adb shell pm uninstall -k --user 0 com.tmobile.selfhelp
adb shell pm uninstall -k --user 0 com.mobitv.tablet.tmobiletv
adb shell pm uninstall -k --user 0 com.mobitv.client.tmobiletv
adb shell pm uninstall -k --user 0 com.mobitv.client.mobitv
adb shell pm uninstall -k --user 0 com.tmobile.d411
adb shell pm uninstall -k --user 0 com.TMobileTopup
adb shell pm uninstall -k --user 0 com.tmobile.tmoid.agent
adb shell pm uninstall -k --user 0 com.tmobile.helpdesk.android

echo Remove Amazon App
adb shell pm uninstall -k --user 0 amazon.alexa.tablet
adb shell pm uninstall -k --user 0 amazon.jackson19
adb shell pm uninstall -k --user 0 com.amazon.advertisingidsettings
adb shell pm uninstall -k --user 0 com.amazon.ags.app
adb shell pm uninstall -k --user 0 com.amazon.avod
adb shell pm uninstall -k --user 0 com.amazon.alta.h2clientservice
adb shell pm uninstall -k --user 0 com.amazon.client.metrics
adb shell pm uninstall -k --user 0 com.amazon.cloud9
adb shell pm uninstall -k --user 0 com.amazon.cloud9.contentservice
adb shell pm uninstall -k --user 0 com.amazon.cloud9.kids
adb shell pm uninstall -k --user 0 com.amazon.cloud9.systembrowserprovider
adb shell pm uninstall -k --user 0 com.amazon.com.alexa.tablet
adb shell pm uninstall -k --user 0 com.amazon.csapps
adb shell pm uninstall -k --user 0 com.amazon.csapp
adb shell pm uninstall -k --user 0 com.amazon.dee.app
adb shell pm uninstall -k --user 0 com.amazon.device.backup
adb shell pm uninstall -k --user 0 com.amazon.device.backup.sdk.internal.library
adb shell pm uninstall -k --user 0 com.amazon.device.crashmanager
adb shell pm uninstall -k --user 0 com.amazon.device.logmanager
adb shell pm uninstall -k --user 0 com.amazon.device.software.ota
adb shell pm uninstall -k --user 0 com.amazon.device.sync
adb shell pm uninstall -k --user 0 com.amazon.device.sync.sdk.internal
adb shell pm uninstall -k --user 0 com.amazon.dp.contacts
adb shell pm uninstall -k --user 0 com.amazon.dp.fbcontacts
adb shell pm uninstall -k --user 0 com.amazon.dp.logger
adb shell pm uninstall -k --user 0 com.amazon.geo.client.maps
adb shell pm uninstall -k --user 0 com.amazon.geo.mapsv2
adb shell pm uninstall -k --user 0 com.amazon.geo.mapsv2.services
adb shell pm uninstall -k --user 0 com.amazon.goodreads.kindle
adb shell pm uninstall -k --user 0 com.amazon.h2settingsfortablet
adb shell pm uninstall -k --user 0 com.amazon.kcp.tutorial
adb shell pm uninstall -k --user 0 com.amazon.kindle
adb shell pm uninstall -k --user 0 com.amazon.kindle.cms
adb shell pm uninstall -k --user 0 com.amazon.kindle.devicecontrols
adb shell pm uninstall -k --user 0 com.amazon.kindle.kso
adb shell pm uninstall -k --user 0 com.amazon.kindle.otter.oobe.forced.ota
adb shell pm uninstall -k --user 0 com.amazon.kindle.otter.settings
adb shell pm uninstall -k --user 0 com.amazon.kindle.personal_video
adb shell pm uninstall -k --user 0 com.amazon.kindle.unifiedSearch
adb shell pm uninstall -k --user 0 com.amazon.legalsettings
adb shell pm uninstall -k --user 0 com.amazon.logan
adb shell pm uninstall -k --user 0 com.amazon.mp3
adb shell pm uninstall -k --user 0 com.amazon.ods.kindleconnect
adb shell pm uninstall -k --user 0 com.amazon.parentalcontrols
adb shell pm uninstall -k --user 0 com.amazon.photos
adb shell pm uninstall -k --user 0 com.amazon.photos.importer
adb shell pm uninstall -k --user 0 com.amazon.platform
adb shell pm uninstall -k --user 0 com.amazon.pm
adb shell pm uninstall -k --user 0 com.amazon.precog
adb shell pm uninstall -k --user 0 com.amazon.readynowcore
adb shell pm uninstall -k --user 0 com.amazon.recess
adb shell pm uninstall -k --user 0 com.amazon.socialplatform
adb shell pm uninstall -k --user 0 com.amazon.tahoe
adb shell pm uninstall -k --user 0 com.amazon.unifiedsharefacebook
adb shell pm uninstall -k --user 0 com.amazon.unifiedsharegoodreads
adb shell pm uninstall -k --user 0 com.amazon.unifiedsharesinaweibo
adb shell pm uninstall -k --user 0 com.amazon.unifiedsharetwitter
adb shell pm uninstall -k --user 0 com.amazon.vans.alexatabletshopping.app
adb shell pm uninstall -k --user 0 com.amazon.venezia
adb shell pm uninstall -k --user 0 com.amazon.webapp
adb shell pm uninstall -k --user 0 com.amazon.whisperlink.activityview.android
adb shell pm uninstall -k --user 0 com.amazon.whisperlink.core.android
adb shell pm uninstall -k --user 0 com.amazon.whisperplay.contracts
adb shell pm uninstall -k --user 0 com.amazon.windowshop
adb shell pm uninstall -k --user 0 com.amazon.zico
adb shell pm uninstall -k --user 0 com.audible.application.kindle
adb shell pm uninstall -k --user 0 com.goodreads.kindle
adb shell pm uninstall -k --user 0 com.here.odnp.service
adb shell pm uninstall -k --user 0 com.kingsoft.office.amz
adb shell pm uninstall -k --user 0 org.mopria.printplugin

echo Remove Sprint App
adb shell pm uninstall -k --user 0 com.asurion.home.sprint
adb shell pm uninstall -k --user 0 com.sprint.care
adb shell pm uninstall -k --user 0 com.boost.care
adb shell pm uninstall -k --user 0 com.asurion.android.mediabackup.vault.sprint
adb shell pm uninstall -k --user 0 com.sprint.safefound
adb shell pm uninstall -k --user 0 com.asurion.android.mobilerecovery.sprint
adb shell pm uninstall -k --user 0 com.sprint.trs
adb shell pm uninstall -k --user 0 com.sprint.adp
adb shell pm uninstall -k --user 0 com.sprint.multiline
adb shell pm uninstall -k --user 0 com.sprint.sdcplus
adb shell pm uninstall -k --user 0 com.dynamicsignal.enterprise.sprint
adb shell pm uninstall -k --user 0 com.mydevices.sprintiotfactory
adb shell pm uninstall -k --user 0 com.sprint.mobilediagnostics
adb shell pm uninstall -k --user 0 com.spotme.itsai17
adb shell pm uninstall -k --user 0 com.sprint.sprintarx
adb shell pm uninstall -k --user 0 com.sprint.fng
adb shell pm uninstall -k --user 0 com.mobolize.cachefront.preload
adb shell pm uninstall -k --user 0 com.mobolize.sprint.securewifi
adb shell pm uninstall -k --user 0 com.boostmobile.boostspot
adb shell pm uninstall -k --user 0 com.hyperlync.Sprint.Backup
adb shell pm uninstall -k --user 0 com.hyperlync.Sprint.CloudBinder
adb shell pm uninstall -k --user 0 org.sprint.mobilediagnostics
adb shell pm uninstall -k --user 0 com.sprint.vvm
adb shell pm uninstall -k --user 0 com.sprint.contenttransfer
adb shell pm uninstall -k --user 0 com.aetherpal.sprint.cpad
adb shell pm uninstall -k --user 0 com.aetherpal.sprint.lge
adb shell pm uninstall -k --user 0 com.aetherpal.sprint.zte
adb shell pm uninstall -k --user 0 com.sprint.airunity.airspanviewer

echo Remove AT&T App
adb shell pm uninstall -k --user 0 com.att.tv.watchtv
adb shell pm uninstall -k --user 0 com.asurion.android.mediabackup.vault.att
adb shell pm uninstall -k --user 0 com.asurion.android.protech.att
adb shell pm uninstall -k --user 0 com.att.miatt
adb shell pm uninstall -k --user 0 com.ooyala.att.sportsnet
adb shell pm uninstall -k --user 0 io.ismconnect.att.devicealive
echo done.....