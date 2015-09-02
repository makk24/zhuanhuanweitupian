using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OMCS.Passive;
using System.Configuration;

/*
 * 本demo采用的是OMCS的免费版本，不需要再次授权。若想获取OMCS其它版本，请联系 www.oraycn.com 。
 * 
 */
namespace OMCS.Demos.WhiteBoardTest
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                LoginForm loginForm = new LoginForm();
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                IMultimediaManager multimediaManager = MultimediaManagerFactory.GetSingleton();
                multimediaManager.ImageConverterFactory = new ImageConverterFactory();// 图片转换器工厂，供OMCS内部将课件转换成图片的过程中使用。
                multimediaManager.CameraDeviceIndex = 0;
                multimediaManager.MicrophoneDeviceIndex = 0;
                multimediaManager.CameraEncodeQuality = 3;
                multimediaManager.ChannelMode = ChannelMode.P2PChannelFirst;
                multimediaManager.Initialize(loginForm.CurrentUserID, "", ConfigurationManager.AppSettings["ServerIP"], int.Parse(ConfigurationManager.AppSettings["ServerPort"]));
                WhiteBoardForm mainForm = new WhiteBoardForm(loginForm.ClassRoomID,loginForm.IsTeacher);               

                Application.Run(mainForm);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message + "," + ee.StackTrace);
            }
        }
    }
}
