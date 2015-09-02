using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;

/*
 * 本demo采用的是OMCS的免费版本，不需要再次授权。若想获取OMCS其它版本，请联系 www.oraycn.com 。
 * 
 */
namespace OMCS.Server
{
    static class Program
    {
        private static IMultimediaServer MultimediaServer;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                GlobalUtil.SetAuthorizedUser(ConfigurationManager.AppSettings["AuthorizedUser"], ConfigurationManager.AppSettings["AuthorizedPassword"]);
                GlobalUtil.SetMaxLengthOfUserID(byte.Parse(ConfigurationManager.AppSettings["MaxLengthOfUserID"]));
                OMCSConfiguration config = new OMCSConfiguration(
                    int.Parse(ConfigurationManager.AppSettings["CameraFramerate"]),
                    int.Parse(ConfigurationManager.AppSettings["DesktopFramerate"])
                   );

                //用于验证登录用户的帐密
                DefaultUserVerifier userVerifier = new DefaultUserVerifier();
                Program.MultimediaServer = MultimediaServerFactory.CreateMultimediaServer(int.Parse(ConfigurationManager.AppSettings["Port"]), userVerifier, config, bool.Parse(ConfigurationManager.AppSettings["SecurityLogEnabled"]));
                ServerForm form = new ServerForm(Program.MultimediaServer);

                Application.Run(form);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }     
    }
}