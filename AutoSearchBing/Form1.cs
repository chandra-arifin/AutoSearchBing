using OpenQA.Selenium.Chrome;
using System.Windows.Forms;

namespace AutoSearchBing
{
    public partial class Form1 : Form
    {
        private int SEARCH;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 30000;//60000;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(); // Initialize WebView2

            // Load bing.com
            webView21.CoreWebView2.Navigate("https://www.bing.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            SEARCH = int.Parse(textBox1.Text.Trim());
            SEARCH++;
            string searchQuery = SEARCH.ToString();
            if (!string.IsNullOrEmpty(searchQuery))
            {
                // Navigate to Bing search results
                //webView21.CoreWebView2.Navigate($@"https://www.bing.com/search?q={searchQuery}");
                webView21.CoreWebView2.Navigate($@"https://www.bing.com/search?q={searchQuery}&qs=n&form=QBRE&sp=-1&ghc=1&lq=0&pq=12&sc=12-2&sk=&cvid=92A1761EC2BD4C11BFC81B7F31DC741E&ghsh=0&ghacc=0&ghpl=");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SEARCH++;
            string searchQuery = SEARCH.ToString();
            if (!string.IsNullOrEmpty(searchQuery))
            {
                // Navigate to Bing search results
                //webView21.CoreWebView2.Navigate($@"https://www.bing.com/search?q={searchQuery}");
                webView21.CoreWebView2.Navigate($@"https://www.bing.com/search?q={searchQuery}&qs=n&form=QBRE&sp=-1&ghc=1&lq=0&pq=12&sc=12-2&sk=&cvid=92A1761EC2BD4C11BFC81B7F31DC741E&ghsh=0&ghacc=0&ghpl=");
                //webView21.CoreWebView2.Reload();
            }
        }
    }
}
