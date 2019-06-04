using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ClassLibraryNetCatch
{
    public class Net
    {
        public List<NestObject> GetPointTree()
        {
            List<NestObject> resList = new List<NestObject>();

            return resList;
        }


        public static void test()
        {
            var url = "http://zujuan.xkw.com/Web/Handler1.ashx?action=categorytree&parentid=141822&iszsd=1&isinit=1";
            var httpRequest = new HttpRequestClient(true);

            string reponse = httpRequest.HttpGet(url, HttpRequestClient.defaultHeaders);
            var dom = CsQuery.CQ.CreateDocument(reponse);
        }
    }
}
