using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace Routing
{
    public class ContextMapper : HttpContextBase
    {
        private RequestMapper requestMapper;

        public ContextMapper(string path, HttpRequest request)
        {
            requestMapper = new RequestMapper(path, request);
        }

        public override HttpRequestBase Request
        {
            get
            {
                return requestMapper;
            }
        }
    }



    public class RequestMapper : HttpRequestBase
    {
        private string requestPath;
        private string appRequestPath;
        private HttpRequest request;

        public RequestMapper(string path, HttpRequest req)
        {
            requestPath = path;
            appRequestPath = VirtualPathUtility.ToAppRelative(path);
            request = req;
        }

        public override string AppRelativeCurrentExecutionFilePath
        {
            get
            {
                return appRequestPath;
            }
        }

        public override string PathInfo
        {
            get
            {
                return "";
            }
        }

        public override string HttpMethod
        {
            get
            {
                return request.HttpMethod;
            }
        }

        public override NameValueCollection Form
        {
            get
            {
                return request.Form;
            }
        }

        public override NameValueCollection Headers
        {
            get
            {
                return request.Headers;
            }
        }

        public override string CurrentExecutionFilePath
        {
            get
            {
                return base.CurrentExecutionFilePath;
            }
        }
    }
}