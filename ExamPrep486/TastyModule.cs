using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ExamPrep486
{
    public class TastyModule : IHttpModule
    {
        private const string RandomCookie = "randomcookie";
        public void Dispose()
        {
        }
        
        public void Init(HttpApplication app)
        {
            var wrapper = new EventHandlerTaskAsyncHelper(DoAsyncWork);
            app.AddOnBeginRequestAsync(wrapper.BeginEventHandler, wrapper.EndEventHandler);
        }

        async Task DoAsyncWork(object sender, EventArgs e)
        {
            var app = (HttpApplication)sender;
            var ctx = app.Context;
            // read data async from file
            var text = await ReadTextAsync(Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "App_Data/RandomCookieData.txt"));
            // set this into some random cookie
            ctx.Response.SetCookie(new HttpCookie(RandomCookie, text));
        }

        // some copy pasted code to read async from a file
        private async Task<string> ReadTextAsync(string filePath)
        {
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Open, FileAccess.Read, FileShare.Read,
                bufferSize: 4096, useAsync: true))
            {
                StringBuilder sb = new StringBuilder();

                byte[] buffer = new byte[0x1000];
                int numRead;
                while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string text = Encoding.ASCII.GetString(buffer, 0, numRead);
                    sb.Append(text);
                }

                return sb.ToString();
            }
        }
    }
}