using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WebViewTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private  void MyWebView_WebResourceRequested(WebView sender, WebViewWebResourceRequestedEventArgs args)
        {
            if (args.Request.Method.Method == "POST")
            {
                HttpStreamContent content = (HttpStreamContent)args.Request.Content;
              
                var contentBuffer = content.ReadAsBufferAsync().GetResults();
                byte[] buffer = contentBuffer.ToArray();

                //var readStream = inputStream.AsStreamForRead();
                
                //MemoryStream ms = new MemoryStream();

             


                //byte[] b = null;
                //using (MemoryStream mss = new MemoryStream())
                //{
                //    int count = 0;

                   
                //        do
                //        {
                //            try
                //            {
                //                byte[] buf = new byte[1024];
                //                count = readStream.Read(buf, 0, 1024);
                //                mss.Write(buf, 0, count);
                //            }
                //            catch (Exception)
                //            {

                               
                //            }
                           
                //        } while (readStream.CanRead && count > 0);
                       
                   
                   
                //}

            }

            
        }
        public static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[13];
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, read);
            }
        }


      
    }
}
