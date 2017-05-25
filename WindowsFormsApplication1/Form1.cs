using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets; //dodane przez nas
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_connect_Click(object sender, EventArgs e)
        {
            string host = Address.Text;
            int port = Convert.ToInt32(My_Port.Value);

            try
            {
                TcpClient klient = new TcpClient(host, port); //tworzymy klienta Tcp , klasa jest już gotowa
                Info_connect.Items.Add("Nawiazano polaczenie z " + host + " na porcie: " + port);
                klient.Close();

            }
            catch (Exception ex)
            {
                Info_connect.Items.Add("Błąd: " + "Nie udało się nawiązać połącznia!");
                MessageBox.Show(ex.ToString(), "Błąd.");
            }

        }
    }
}
