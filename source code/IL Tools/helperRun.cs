using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IL_Tools
{
    class helperRun
    {
        public static void runAmricanAppRemove()
        {
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.simlock");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.pr.mytmobile");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.vvm.application");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.tuesdays");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.mobitv.client.tmobiletvhd");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.digits");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.tct");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.whitepages.nameid.tmobile");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.wifi");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.band12");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.familycontrols");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.services.nameid");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.syncupfleet.hos");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.callertunes");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.syncupfleet");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.techexperience");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.techexperience.arscanner");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.MobileInternetManagement.devices");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.selfhelp");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.mobitv.tablet.tmobiletv");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.mobitv.client.tmobiletv");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.mobitv.client.mobitv");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.d411");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.TMobileTopup");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.tmoid.agent");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.tmobile.helpdesk.android");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 amazon.alexa.tablet");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 amazon.jackson19");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.advertisingidsettings");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.ags.app");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.avod");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.alta.h2clientservice");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.client.metrics");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.cloud9");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.cloud9.contentservice");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.cloud9.kids");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.cloud9.systembrowserprovider");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.com.alexa.tablet");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.csapps");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.csapp");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.dee.app");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.device.backup");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.device.backup.sdk.internal.library");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.device.crashmanager");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.device.logmanager");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.device.software.ota");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.device.sync");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.device.sync.sdk.internal");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.dp.contacts");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.dp.fbcontacts");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.dp.logger");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.geo.client.maps");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.geo.mapsv2");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.geo.mapsv2.services");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.goodreads.kindle");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.h2settingsfortablet");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.kcp.tutorial");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.kindle");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.kindle.cms");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.kindle.devicecontrols");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.kindle.kso");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.kindle.otter.oobe.forced.ota");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.kindle.otter.settings");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.kindle.personal_video");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.kindle.unifiedSearch");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.legalsettings");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.logan");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.mp3");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.ods.kindleconnect");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.parentalcontrols");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.photos");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.photos.importer");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.platform");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.pm");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.precog");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.readynowcore");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.recess");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.socialplatform");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.tahoe");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.unifiedsharefacebook");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.unifiedsharegoodreads");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.unifiedsharesinaweibo");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.unifiedsharetwitter");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.vans.alexatabletshopping.app");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.venezia");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.webapp");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.whisperlink.activityview.android");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.whisperlink.core.android");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.whisperplay.contracts");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.windowshop");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.zico");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.audible.application.kindle");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.goodreads.kindle");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.here.odnp.service");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.kingsoft.office.amz");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 org.mopria.printplugin");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.asurion.home.sprint");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sprint.care");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.boost.care");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.asurion.android.mediabackup.vault.sprint");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sprint.safefound");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.asurion.android.mobilerecovery.sprint");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sprint.trs");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sprint.adp");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sprint.multiline");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sprint.sdcplus");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.dynamicsignal.enterprise.sprint");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.mydevices.sprintiotfactory");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sprint.mobilediagnostics");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.spotme.itsai17");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sprint.sprintarx");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sprint.fng");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.mobolize.cachefront.preload");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.mobolize.sprint.securewifi");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.boostmobile.boostspot");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.hyperlync.Sprint.Backup");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.hyperlync.Sprint.CloudBinder");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 org.sprint.mobilediagnostics");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sprint.vvm");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sprint.contenttransfer");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.aetherpal.sprint.cpad");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.aetherpal.sprint.lge");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.aetherpal.sprint.zte");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sprint.airunity.airspanviewer");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.att.tv.watchtv");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.asurion.android.mediabackup.vault.att");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.asurion.android.protech.att");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.att.miatt");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.ooyala.att.sportsnet");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 io.ismconnect.att.devicealive");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.yellowpages.android.ypmobile");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.mShop.android.install");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.kindle");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.amazon.mShop.android");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.wavemarket.waplauncher");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.matchboxmobile.wisp");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.att.android.digitallocker");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.yahoo.mobile.client.android.mail.att");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.telenav.app.android.cingular");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.asurion.android.mobilerecovery.att");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 net.aetherpal.device");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.att.android.attsmartwifi");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.cequint.ecid");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sec.android.devicehelp");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.drivemode");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.synchronoss.dcs.att.r2g");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.locationlabs.cni.att");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sec.att.usagemanager3");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.samsung.vvm");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.vcast.mediamanager");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.verizon.messaging.vzmsgs");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.verizon.mips.services");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.vzw.hss.myverizon");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.gotv.nflgamecenter.us.lite");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.asurion.android.verizon.vms");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.slacker.radio");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.vznavigator.Generic");
        }
        public static void removeApp(String appPkg)
        {
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 " + appPkg);
        }
    }
}
