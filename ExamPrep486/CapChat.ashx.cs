using System.Web;
using ExamPrep486.Chat;
using Microsoft.Web.WebSockets;

namespace ExamPrep486
{
    /// <summary>
    /// Summary description for CapChat
    /// </summary>
    public class CapChat : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.IsWebSocketRequest)
            {
                context.AcceptWebSocketRequest(new ChatWebSocketHandler());
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}