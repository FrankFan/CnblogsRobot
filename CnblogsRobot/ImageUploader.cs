/*
 *  Description：图片上传类
 *  Author: FrankFan
 *  Email:fanyong@gmail.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnblogsRobot
{
    /*
     * 1.请求url:http://upload.cnblogs.com/imageuploader/upload
     * 真正请求的是ajax url：http://upload.cnblogs.com/imageuploader/processupload?host=&qqfile=test.jpg
     * 2.需要登录，添加cookie
     * 3.发起http请求，上传图片， Reponse中返回上传成功的图片地址。
     */
    public class ImageUploader
    {
        const string URL = "http://upload.cnblogs.com/imageuploader/processupload?host=&qqfile={0}";

        public static string Uploade(string imageLocalPath)
        {
            string serverPath = string.Empty;

            //TODO:用C#模拟javascript ajax请求

            return serverPath;
        }

    }
}
