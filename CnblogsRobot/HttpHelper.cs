﻿/*
 *  Description：Http操作工具类
 *  Author: FrankFan
 *  Email:fanyong@gmail.com
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace CnblogsRobot
{
    public class HttpHelper
    {
        //全局变量：cookie容器
        //CookieContainer cookie = new CookieContainer();

        public static string HttpGet(string url, string postedData)
        {
            string urlParam = string.Empty;
            if (string.IsNullOrEmpty(postedData))
            {
                urlParam = "";
            }
            else
            {
                urlParam = "?" + postedData;
            }

            //create a http request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            //get http response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //get stream
            Stream responseStream = response.GetResponseStream();
            //通过StreamReader读取Stream流中的内容
            StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
            //将流转化成字符串
            string html = reader.ReadToEnd();

            //close resource
            responseStream.Close();
            reader.Close();

            return html;
        }

        public static string HttpPost(string url, string postedData,CookieContainer cc)
        {
            string html = string.Empty;
            Stream myResponseStream = null;
            StreamReader sreamReader = null;
            StreamWriter myStreamWriter = null;

            //create a http web request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //set request type
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = Encoding.UTF8.GetByteCount(postedData);
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";

            //set cookie
            
            request.CookieContainer = cc;


            try
            {
                //get request stream
                Stream responseStream = request.GetRequestStream();
                //用StreamWriter向流request stream中写入字符，格式是UTF8
                myStreamWriter = new StreamWriter(responseStream, Encoding.UTF8);
                myStreamWriter.Write(postedData);

                //get http response
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                //获取服务器的cookie
                //response.Cookies = cookieContainer.GetCookies(response.ResponseUri);
                //得到response stream
                myResponseStream = response.GetResponseStream();
                //用StreamReader解析response stream
                sreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
                //将流转化成字符串
                html = sreamReader.ReadToEnd();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ////关闭资源
                //myResponseStream.Close();
                //sreamReader.Close();
                ////关闭writer
                //myStreamWriter.Close();
            }


            return html;
        }

        /// <summary>
        /// 获取cookie
        /// </summary>
        /// <param name="loginUrl"></param>
        /// <param name="postedData"></param>
        /// <param name="header"></param>
        /// <returns></returns>
        public static CookieContainer GetCookie(string loginUrl, string postedData, HttpHeader header)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            CookieContainer cc = new CookieContainer();

            try
            {
                //准备发起请求
                request = (HttpWebRequest)WebRequest.Create(loginUrl);
                request.Method = header.Method;
                request.ContentType = header.ContentType;
                byte[] postDataByte = Encoding.UTF8.GetBytes(postedData);
                request.ContentLength = postDataByte.Length;
                request.CookieContainer = cc;
                request.KeepAlive = true;
                request.AllowAutoRedirect = false;

                //提交请求
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(postDataByte, 0, postDataByte.Length);
                requestStream.Close();

                //接收响应
                response = (HttpWebResponse)request.GetResponse();
                response.Cookies = request.CookieContainer.GetCookies(request.RequestUri);

                CookieCollection cookieCollection = response.Cookies;

                cc.Add(cookieCollection);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cc;
        }

        /// <summary>
        /// Get方式获携带cookie获取页面html
        /// </summary>
        /// <param name="url">请求的url</param>
        /// <param name="cc">cookie</param>
        /// <param name="header">请求Header对象</param>
        /// <returns>页面源代码html</returns>
        public static string GetHtml(string url, CookieContainer cc, HttpHeader header)
        {
            string html = string.Empty;
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            StreamReader streamReader = null;
            Stream responseStream = null;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.CookieContainer = cc;
                request.ContentType = header.ContentType;
                request.ServicePoint.ConnectionLimit = header.MaxTry;
                request.Referer = url;
                request.Accept = header.Accept;
                request.UserAgent = header.UserAgent;
                request.Method = "GET";

                //发起请求，得到Response
                response = (HttpWebResponse)request.GetResponse();
                responseStream = response.GetResponseStream();
                streamReader = new StreamReader(responseStream, Encoding.UTF8);
                html = streamReader.ReadToEnd();


            }
            catch (Exception ex)
            {
                if (request != null)
                    request.Abort();
                if (response != null)
                    response.Close();
                return string.Empty;
            }
            finally
            {
                //关闭各种资源
                streamReader.Close();
                responseStream.Close();
                request.Abort();
                response.Close();
            }


            return html;
        }

        public static string HttpPostByCookie(string url, CookieContainer cc, HttpHeader header)
        {
            throw new NotImplementedException();
        }
    }
}
