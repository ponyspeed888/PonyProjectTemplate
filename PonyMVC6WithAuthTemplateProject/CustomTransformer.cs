namespace $safeprojectname$
{
 
    public class CustomTransformer : Yarp.ReverseProxy.Forwarder.HttpTransformer
    {
        public override async ValueTask TransformRequestAsync(HttpContext httpContext, HttpRequestMessage proxyRequest, string destinationPrefix)

        //public override async Task TransformRequestAsync1(HttpContext httpContext,HttpRequestMessage proxyRequest, string destinationPrefix)
        //public override async Task TransformRequestAsync(HttpContext httpContext, HttpRequestMessage proxyRequest, string destinationPrefix)
        {
            // Copy headers normally and then remove the original host.
            // Use the destination host from proxyRequest.RequestUri instead.
            await base.TransformRequestAsync(httpContext, proxyRequest, destinationPrefix);
            proxyRequest.Headers.Host = null;
        }
    }

}
