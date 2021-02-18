using System;
using DalSoft.RestClient;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using System.Text.RegularExpressions;






namespace Prueba1
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();
        //Match[] matches;
        string response;
        string post;
        string todo;
        string[] todorect;
        string[] rect;
        string[] postsrect;
        string pattern;
        int id;


        int idPC;


        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Users();
        }

        public async Task Users()
        {
            
            response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");

            rect = response.Split(new string[] { "}," }, StringSplitOptions.None);
            //Console.WriteLine(rect[1]);
            pattern = @"(?<=username\"": \"").+?(?=\"")";

            foreach (string user in rect)
            {

                comboBox1.Items.Add( Regex.Match(user, pattern).Value);
                
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = @"(?<=name\"": \"").+?(?=\"")";
            string user = @"(?<=username\"": \"").+?(?=\"")";
            string email = @"(?<=email\"": \"").+?(?=\"")";
            string phone = @"(?<=phone\"": \"").+?(?=\"")";
            string website = @"(?<=website\"": \"").+?(?=\"")";
            
            richTextBox1.Clear();
            int curItem = comboBox1.SelectedIndex;
            //Console.WriteLine(curItem);
            if (curItem==0)
            {
                
                richTextBox1.AppendText("Nombre: "+Regex.Match(rect[0], name).Value +"\n");
                richTextBox1.AppendText("Usuario: "+Regex.Match(rect[0], user).Value + "\n");
                richTextBox1.AppendText("Email: " + Regex.Match(rect[0], email).Value + "\n");
                richTextBox1.AppendText("Tel: " + Regex.Match(rect[1], phone).Value + "\n");
                richTextBox1.AppendText("Web: " + Regex.Match(rect[1], website).Value + "\n");
                id = 1;

            }

            if (curItem == 2)
            {

                richTextBox1.AppendText("Nombre: " + Regex.Match(rect[2], name).Value + "\n");
                richTextBox1.AppendText("Usuario: " + Regex.Match(rect[2], user).Value + "\n");
                richTextBox1.AppendText("Email: " + Regex.Match(rect[2], email).Value + "\n");
                richTextBox1.AppendText("Tel: " + Regex.Match(rect[3], phone).Value + "\n");
                richTextBox1.AppendText("Web: " + Regex.Match(rect[3], website).Value + "\n");
                id = 2;

            }

            if (curItem == 4)
            {

                richTextBox1.AppendText("Nombre: " + Regex.Match(rect[4], name).Value + "\n");
                richTextBox1.AppendText("Usuario: " + Regex.Match(rect[4], user).Value + "\n");
                richTextBox1.AppendText("Email: " + Regex.Match(rect[4], email).Value + "\n");
                richTextBox1.AppendText("Tel: " + Regex.Match(rect[5], phone).Value + "\n");
                richTextBox1.AppendText("Web: " + Regex.Match(rect[5], website).Value + "\n");
                id = 3;

            }
            if (curItem == 6)
            {

                richTextBox1.AppendText("Nombre: " + Regex.Match(rect[6], name).Value + "\n");
                richTextBox1.AppendText("Usuario: " + Regex.Match(rect[6], user).Value + "\n");
                richTextBox1.AppendText("Email: " + Regex.Match(rect[6], email).Value + "\n");
                richTextBox1.AppendText("Tel: " + Regex.Match(rect[7], phone).Value + "\n");
                richTextBox1.AppendText("Web: " + Regex.Match(rect[7], website).Value + "\n");
                id = 4;

            }
            if (curItem == 8)
            {

                richTextBox1.AppendText("Nombre: " + Regex.Match(rect[8], name).Value + "\n");
                richTextBox1.AppendText("Usuario: " + Regex.Match(rect[8], user).Value + "\n");
                richTextBox1.AppendText("Email: " + Regex.Match(rect[8], email).Value + "\n");
                richTextBox1.AppendText("Tel: " + Regex.Match(rect[9], phone).Value + "\n");
                richTextBox1.AppendText("Web: " + Regex.Match(rect[9], website).Value + "\n");
                id = 5;

            }
            if (curItem == 10)
            {

                richTextBox1.AppendText("Nombre: " + Regex.Match(rect[10], name).Value + "\n");
                richTextBox1.AppendText("Usuario: " + Regex.Match(rect[10], user).Value + "\n");
                richTextBox1.AppendText("Email: " + Regex.Match(rect[10], email).Value + "\n");
                richTextBox1.AppendText("Tel: " + Regex.Match(rect[11], phone).Value + "\n");
                richTextBox1.AppendText("Web: " + Regex.Match(rect[11], website).Value + "\n");
                id = 6;

            }
            if (curItem == 12)
            {

                richTextBox1.AppendText("Nombre: " + Regex.Match(rect[12], name).Value + "\n");
                richTextBox1.AppendText("Usuario: " + Regex.Match(rect[12], user).Value + "\n");
                richTextBox1.AppendText("Email: " + Regex.Match(rect[12], email).Value + "\n");
                richTextBox1.AppendText("Tel: " + Regex.Match(rect[13], phone).Value + "\n");
                richTextBox1.AppendText("Web: " + Regex.Match(rect[13], website).Value + "\n");
                id = 7;

            }
            if (curItem == 14)
            {

                richTextBox1.AppendText("Nombre: " + Regex.Match(rect[14], name).Value + "\n");
                richTextBox1.AppendText("Usuario: " + Regex.Match(rect[14], user).Value + "\n");
                richTextBox1.AppendText("Email: " + Regex.Match(rect[14], email).Value + "\n");
                richTextBox1.AppendText("Tel: " + Regex.Match(rect[15], phone).Value + "\n");
                richTextBox1.AppendText("Web: " + Regex.Match(rect[15], website).Value + "\n");
                id = 8;

            }
            if (curItem == 16)
            {

                richTextBox1.AppendText("Nombre: " + Regex.Match(rect[16], name).Value + "\n");
                richTextBox1.AppendText("Usuario: " + Regex.Match(rect[16], user).Value + "\n");
                richTextBox1.AppendText("Email: " + Regex.Match(rect[16], email).Value + "\n");
                richTextBox1.AppendText("Tel: " + Regex.Match(rect[17], phone).Value + "\n");
                richTextBox1.AppendText("Web: " + Regex.Match(rect[17], website).Value + "\n");
                id = 9;

            }
            if (curItem == 18)
            {

                richTextBox1.AppendText("Nombre: " + Regex.Match(rect[18], name).Value + "\n");
                richTextBox1.AppendText("Usuario: " + Regex.Match(rect[18], user).Value + "\n");
                richTextBox1.AppendText("Email: " + Regex.Match(rect[18], email).Value + "\n");
                richTextBox1.AppendText("Tel: " + Regex.Match(rect[19], phone).Value + "\n");
                richTextBox1.AppendText("Web: " + Regex.Match(rect[19], website).Value + "\n");
                id = 10;

            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await PostU();
        }

        public async Task PostU()
        {
            richTextBox2.Clear();
            string urlP = "https://jsonplaceholder.typicode.com/users/" + id + "/posts";
            post = await client.GetStringAsync(urlP);
            postsrect = post.Split(new string[] { "}," }, StringSplitOptions.None);
            //Console.WriteLine(postsrect[0]);
            string idPost = @"(?<=id\"": ).+?(?=\,)";
            string titlePost=@"(?<=title\"": \"").+?(?=\"")";
            string bodyPost = @"(?<=body\"": \"").+?(?=\"")";


            foreach (string postIn in postsrect)
            {

                richTextBox2.AppendText("Id Post: " + Regex.Match(postIn, idPost).Value + "\n");
                idPC = Int16.Parse(Regex.Match(postIn, idPost).Value);
                richTextBox2.AppendText("Title Post: " + Regex.Match(postIn, titlePost).Value + "\n");
                richTextBox2.AppendText("Body Post: " + Regex.Match(postIn, bodyPost).Value + "\n");

            }

            
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await ToDo();
        }

        public async Task ToDo()
        {
            richTextBox2.Clear();
            string urlT = "https://jsonplaceholder.typicode.com/users/" + id + "/todos";
            todo = await client.GetStringAsync(urlT);
            todorect = todo.Split(new string[] { "}," }, StringSplitOptions.None);
            //Console.WriteLine(postsrect[0]);
            string idTodo = @"(?<=id\"": ).+?(?=\,)";
            string titleTodo = @"(?<=title\"": \"").+?(?=\"")";
            string compleTodo = @"(?<=completed\"": ).+"; ;


            foreach (string todoIn in todorect.Reverse<string>())
            {

                richTextBox2.AppendText("Id Todo: " + Regex.Match(todoIn, idTodo).Value + "\n");
                richTextBox2.AppendText("Title Todo: " + Regex.Match(todoIn, titleTodo).Value + "\n");
                richTextBox2.AppendText("Completed Todo: " + Regex.Match(todoIn, compleTodo).Value + "\n");

            }


        }

        private async void button4_Click(object sender, EventArgs e)
        {
            /*dynamic client = new RestClient ("https://jsonplaceholder.typicode.com");

            var user = new { name = "foo", email = "foo@bar.com", userId = 10 };

            //POST { "name":"foo", "email":"foo@bar.com", "userId":10 } https://jsonplaceholder.typicode.com/users  
            var result = await client.Users.Post(user);*/
        }
    }
}
