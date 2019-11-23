using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GuiServerPCars2V2._0
{
    class CreateCfgFile : IDisposable
    {
        private string secure;
        private string sportsPlay;
        private string whiteList;
        private string blackList;
        private string httpApi;
        public string stats = "\"sms_stats\"";
        

        

       private void Secure()
        {
            if (Form2.mainWindow.CheckBox_secure.Checked)
            {
                secure = "secure : true";
            }
            else
            {
                secure = "secure : false";
            }
            
        }

        private void SportsPlay()
        {
            if (Form2.mainWindow.CheckBox_SportsPlay.Checked)
            {
                sportsPlay = "sportsPlay : true";
            }
            else
            {
                sportsPlay = "sportsPlay : false";
            }
            
        }

        private void WhiteList()
        {
            if (Form2.mainWindow.CheckBox_WhiteList.Checked)
            {
                whiteList = "whiteList : \"whitelist.cfg\"";
            }
            else
            {
                whiteList = "";
            }
        }

        private void BlackList()
        {
            if (Form2.mainWindow.CheckBox_BlackList.Checked)
            {
                blackList = "blacklist : \"blacklist.cfg\"";
            }
            else
            {
                blackList = "";
            }
        }

        private void EnableHttpApi()
        {
            if (Form2.mainWindow.CheckBox_EnableHttpApi.Checked)
            {
                httpApi = "enableHttpApi : true";
            }

            else
            {
                httpApi = "enableHttpApi : false";
            }
        }

        public void EditOrCreateFileCfg()
        {
            Secure();
            SportsPlay();
            WhiteList();
            BlackList();
            EnableHttpApi();

            string fileCfg = Form1.workFolder + "\\server.cfg";

            bool fileOk = false;
            while (!fileOk)
            {
                if (File.Exists(fileCfg))
                {
                    fileOk = true;
                }
                else
                {
                    File.Create(fileCfg).Dispose();

                }

            }

            var streamFileCfg = new StreamWriter(new FileStream(fileCfg, FileMode.OpenOrCreate));
            string cfg = "logLevel : \"" + Form2.mainWindow.CbBox_LogLevel.Text + "\"" + "\r\n" +
                "eventsLogSize :" + Form2.mainWindow.TxtBx_LogSize.Text + "\r\n" +
                "name : " + "\"" + Form2.mainWindow.TxtBx_Name.Text + "\"" + "\r\n" +
                secure + "\r\n" +
                "password : \"" + Form2.mainWindow.TxtBx_Password.Text + "\"" + "\r\n" +
                "maxPlayerCount : " + Form2.mainWindow.CbBox_MaxPlayerCount.Text + "\r\n" +
                "bindIP : \"" + Form2.mainWindow.TxtBx_BindIp.Text + "\"" + "\r\n" +
                "steamPort : " + Form2.mainWindow.TxtBx_SteamPort.Text + "\r\n" +
                "hostPort : " + Form2.mainWindow.TxtBx_HostPort.Text + "\r\n" +
                "queryPort : " + Form2.mainWindow.TxtBx_QueryPort.Text + "\r\n" +
                "sleepWaiting : " + Form2.mainWindow.TxtBx_SleepWaiting.Text + "\r\n" +
                "sleepActive : " + Form2.mainWindow.TxtBx_SleepActive.Text + "\r\n" +
                sportsPlay + "\r\n" +
                whiteList + "\r\n" +
                blackList + "\r\n" +
                httpApi + "\r\n" +
                "httpApiLogLevel : \"warning\"" + "\r\n" +
                "httpApiInterface : \"" + Form2.mainWindow.TxtBx_HttpApiInterface.Text + "\"" + "\r\n" +
                "httpApiPort : " + Form2.mainWindow.TxtBx_HttpApiPort.Text + "\r\n" +
                "httpApiExtraHeaders : {" + "\r\n" +
                "    \"*\" : \"Access-Control-Allow-Origin: *\" " + "\r\n" +
                "}" + "\r\n" +
                "httpApiAccessLevels : {}" + "\r\n" +
                "httpApiAccessFilters : {" + "\r\n" +
                "\r\n" +
                "\"public\" : [" + "\r\n" +
                     "{ \"type\" : \"accept\" }" + "\r\n" +
                "]," + "\r\n" +
                "\r\n" +
                "\"private\" : [" + "\r\n" +
                "    { \"type\" : \"ip-accept\", \"ip\" : \"" + Form2.mainWindow.TxtBx_HttpApiInterface.Text + "/32\" }," + "\r\n" +
                "    { \"type\" : \"group\", \"group\" : \"private\" }," + "\r\n" +
                "    { \"type\" : \"reject-password\" }" + "\r\n" +
                "], " + "\r\n" +
                "\r\n" +
                "\"admin\" : [" + "\r\n" +
                "    { \"type\" : \"ip-accept\", \"ip\" : \"" + Form2.mainWindow.TxtBx_HttpApiInterface.Text + "/32\" }," + "\r\n" +
                "    { \"type\" : \"group\", \"group\" : \"admin\" }," + "\r\n" +
                "    { \"type\" : \"reject-password\" }" + "\r\n" +
                "]," + "\r\n" +
                " }" + "\r\n" +
                "\r\n" +
                "httpApiUsers : { " + "\r\n" +
                "\"" + Form2.mainWindow.TxtBx_AdminHttpApi.Text + "\"" + " : " + "\"" + Form2.mainWindow.TxtBx_PassHttpApi.Text + "\"" + "\r\n" + "}" + "\r\n"+
                 "}" + "\r\n" +
                "httpApiGroups : {" + "\r\n" +
                "\"private\" : [" + Form2.mainWindow.TxtBx_AdminHttpApi.Text + "]," + "\r\n" +
                "\"admin\" : [" + Form2.mainWindow.TxtBx_AdminHttpApi.Text + "]," + "\r\n" +
                "}" + "\r\n" +
                "staticWebFiles: \"web_files\"" + "\r\n" +
                "enableLuaApi : true" + "\r\n" +
                "luaAddonRoot : \"lua\"" + "\r\n" +
                "luaConfigRoot : \"lua_config\"" + "\r\n" +
                "luaOutputRoot : \"lua_output\"" + "\r\n" +
                "luaApiAddons : [ " + "\r\n" +
                "     \"sms_base\"," + "\r\n" +
                "     \"sms_rotate\", " + "\r\n" +
                "     \"sms_motd\", " + "\r\n" +
                 "     " + stats + "]" + "\r\n" +
                "luaAllowedLibraries : [ " + "\r\n" +
                "     \"lib_rotate\" ]" + "\r\n" +
                "allowEmptyJoin : true" + "\r\n" +
                "\r\n" +
                "controlGameSetup : true" + "\r\n" +
                "\r\n" +
                "sessionAttributes : { " + "\r\n" +
                    "\"ServerControlsTrack\" : 1," + "\r\n" +
                    "\"ServerControlVehicleClass\" : 1, " + "\r\n" +
                    "\"ServerControlVehicle\" : 1, " + "\r\n" +
                    "\"GridSize\" :" + Form2.mainWindow.TxtBx_GridSize.Text + "," + "\r\n" +
                    "\"MaxPlayers\" : " + Form2.mainWindow.TxtBx_NumberOfDrivers.Text + "," + "\r\n" +
                "}"
            ;
            streamFileCfg.Write(cfg);
            streamFileCfg.Close();
            streamFileCfg.Dispose();
            
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
