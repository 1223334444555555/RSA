using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using RSAManager.Helpers;

namespace Client
{
    public partial class Client : Form
    {
        private Socket client;
        byte[] buff = new byte[1024];
        byte[] buff2 = new byte[1024];

        private delegate void updateUI(string massage);
        private updateUI updateUi;
        public Client()
        {
            InitializeComponent();
            updateUi = new updateUI(update);
            CheckForIllegalCrossThreadCalls = false;
        }
        private void update(string m)
        {
            lbHienThi.Items.Add(m);
        }
        private void sendata(IAsyncResult ia)
        {
            client.EndSend(ia);
        }
        private void startClient()
        {
            EndPoint ep = new IPEndPoint(IPAddress.Parse(txtIP.Text), Int32.Parse(txtPort.Text));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            updateUi("Đang kết nối tới server...");
            client.BeginConnect(ep, new AsyncCallback(beginConnect), client);
        }
        private void beginConnect(IAsyncResult ar)
        {
            Socket s = (Socket)ar.AsyncState;
            s.EndConnect(ar);
            updateUi("Đã nhận kết nối từ server " + s.RemoteEndPoint.ToString());
            
            client.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(beginReceive), client);
        }
        private void beginReceive(IAsyncResult ia)
        {
            Socket s = (Socket)ia.AsyncState;
            int recv = 0;
            recv = s.EndReceive(ia);
            
            string recvei = Encoding.ASCII.GetString(buff, 0, recv);
            updateUi("Server: " + recvei);
            if (recvei == "5 Fail")
            {
                updateUi("Đã tồn tại, vui lòng đăng ký tài khoản khác!");

            }
            if (recvei == "6 Ok")
            {
                updateUi("Bạn đã đăng ký thành công!");

            }
            if (recvei == "2 Ok")
            {
                updateUi("Bạn đã đăng nhập thành công!");

            }
            if (recvei == "3 Fail")
            {
                updateUi("Sai tai khoản hoặc mật khẩu, vui lòng kiểm tra lại!");

            }
            buff = new byte[1024];
            client.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(beginReceive), client);

        }
        private void send()// gửi dữ liệu đăng ký
        {
            string H1 = 4 +"|"+ txtBM.Text + "|" + txtPublicKey.Text + "|" + txtPrivateKey.Text;
            
            byte[] guiacc = new byte[10000];
            guiacc = Encoding.ASCII.GetBytes(H1);
            updateUi("Server: " + H1);
            client.BeginSend(guiacc, 0, guiacc.Length, SocketFlags.None, new AsyncCallback(sendata), client);

        }
        private void sendDN()// gửi dữ liệu đăng nhập
        {
            string H2 = 1 + "|" + txtBM.Text + "|" + txtPublicKey.Text + "|" + txtPrivateKey.Text;

            byte[] guiacc = new byte[10000];
            guiacc = Encoding.ASCII.GetBytes(H2);
            updateUi("Server: " + H2);
            client.BeginSend(guiacc, 0, guiacc.Length, SocketFlags.None, new AsyncCallback(sendata), client);

        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            startClient();
            txtUs.Focus();
            
        }

       
        private void txtPort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startClient();

            }
        }

        private void txtTK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                send();

            }
        }

        private void txtMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                send();

            }
        }
        private void txtPrivateKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                send();

            }
        }
        private void txtPublicKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                send();

            }
        }


        //phần soucre RSA
        private RSAHelper _rsa = null;

        private void mniKeySize512_CheckedChanged(object sender, EventArgs e)
        {
            var mniState = ((ToolStripMenuItem)sender).Checked;
            if (mniState) changeCheckMenuItems(sender, false);
        }

        private void changeCheckMenuItems(object sender, bool chacked)
        {
            foreach (var item in mniKeySize.DropDownItems)
            {
                ((ToolStripMenuItem)item).CheckedChanged -= mniKeySize512_CheckedChanged;
            }

            foreach (var item in mniKeySize.DropDownItems)
            {
                if (item != sender)
                {
                    ((ToolStripMenuItem)item).Checked = chacked;
                }
            }

            foreach (var item in mniKeySize.DropDownItems)
            {
                ((ToolStripMenuItem)item).CheckedChanged += mniKeySize512_CheckedChanged;
            }
        }

        private int getKeySize()
        {
            foreach (var item in mniKeySize.DropDownItems)
            {
                var mni = ((ToolStripMenuItem)item);
                if (mni.Checked) return int.Parse(mni.Text);
            }
            return 0;
        }

        private void mniGenerate_Click_1(object sender, EventArgs e)
        {
            // look for the selcted menu item
            var keySize = getKeySize();
            if (keySize == 0)
            {
                MessageBox.Show("Please, selected a key size!");
                return;
            }
            // conver the menu item key size (512, 1024, ....) and generate a key pair
            // attention! you can not use a different private key to decrypt an encrypted data
            // if you realize, we are saving the pair (public and private keys) 
            lblKeySizeValue.Text = keySize.ToString();
            _rsa = new RSAHelper(keySize);
            txtPublicKey.Text = _rsa.PublicKey();
            txtPrivateKey.Text = _rsa.PrivateKey();
        }

        

        private void btnDk_Click(object sender, EventArgs e)
        {
            
            //mã hóa
            if (_rsa == null)
            {
                MessageBox.Show("Please, generate a key pair first!");
                return;
            }
            if (string.IsNullOrEmpty(txtUs.Text + "|" + txtPw.Text))
            {
                MessageBox.Show("Please, inform some content!");
                return;
            }
            try
            {
                txtBM.Text = _rsa.EncryptString(txtUs.Text + "|" + txtPw.Text, txtPublicKey.Text);
            }
            catch (Exception ex)
            {
                updateUi ( "");
                MessageBox.Show("There was an error trying to encrypt the text content. Check if the key size is enought to the text size!");
            }
            // gửi
            send();
        }

        private void btnDn_Click(object sender, EventArgs e)
        {
            
            if (_rsa == null)
            {
                MessageBox.Show("Please, generate a key pair first!");
                return;
            }
            if (string.IsNullOrEmpty(txtTK.Text + "|" + txtMK.Text))
            {
                MessageBox.Show("Please, inform some content!");
                return;
            }
            try
            {
                txtBM.Text = _rsa.EncryptString(txtTK.Text + "|" + txtMK.Text, txtPublicKey.Text);
            }
            catch (Exception ex)
            {
                updateUi("");
                MessageBox.Show("There was an error trying to encrypt the text content. Check if the key size is enought to the text size!");
            }
            // gửi
            sendDN();
            txtUs.Clear();
            txtPw.Clear();
        }
    }
}
