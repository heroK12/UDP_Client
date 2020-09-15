using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP_Client
{
    public partial class Form1 : Form
    {
        public UdpClient udp;
        IPEndPoint localEP;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //受信ボタン
        private void button1_Click(object sender, EventArgs e)
        {
            ListenBroadcastMessage();
        }

        //受信
        private void ListenBroadcastMessage()
        {
            if (IPtxt.Text == "" || LocalPort.Text == "" || RemotePort.Text == "")
            {
                MessageBox.Show("未入力項目があります", "", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    //バインドするローカルIPとポート番号
                    string localIpString = IPtxt.Text;
                    IPAddress localAddress = IPAddress.Parse(localIpString);
                    int localPort = int.Parse(LocalPort.Text);

                    //受信ボタン
                    RcvStart.Enabled = false;
                    RcvClose.Enabled = true;

                    //UdpClientを作成し、ローカルエンドポイントにバインドする IP + Port
                    IPEndPoint localEP = new IPEndPoint(localAddress, localPort);

                    //ソケットおーぷん
                    udp = new UdpClient(localEP);

                    //データ受信する
                    var rcvresult = udp.BeginReceive(ReceiveCallback, null);

                    Logtxt.Items.Insert(0, "受信開始");

                }catch(SocketException e)
                {
                    MessageBox.Show("既にそのポートが使われている可能性があります。");
                }
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            UdpClient udpClient = udp;
            IPEndPoint endPoint = localEP;
            byte[] receiveByte;
            try
            {
                receiveByte = udpClient.EndReceive(ar, ref endPoint);
            }
            catch(SocketException)
            {
                CloseSocket();
                MessageBox.Show("通信エラー","",MessageBoxButtons.OK);

                return;
            }
            catch (ObjectDisposedException)
            {
                return;
            }

            //文字列に変換
            string receiveString = Encoding.UTF8.GetString(receiveByte);

            //時刻取得
            DateTime dt = DateTime.Now;

            //時間フォーマット
            string rcvtime = dt.ToString("yyyy/MM/dd HH:mm:ss");

            //Task実行の忠告非表示
            ListBox.CheckForIllegalCrossThreadCalls = false;

            //受信したデータと送信者の情報を表示する
            Logtxt.Items.Insert(0, rcvtime + " " + "【RECV】" + receiveString + "\r\n");

            //ループ処理
            udpClient.BeginReceive(ReceiveCallback, udp);

            return;
        }

        //閉じる
        private void RcvClose_Click(object sender, EventArgs e)
        {
            CloseSocket();
        }

        //ソケット閉じる処理
        private void CloseSocket()
        {
            if (udp != null)
            {
                udp.Close();
                Invoke((MethodInvoker)(() =>
                Logtxt.Items.Insert(0, "受信終了")));
                Invoke((MethodInvoker)(() =>
                RcvStart.Enabled = true));
                Invoke((MethodInvoker)(() =>
                RcvClose.Enabled = false));
            }
            else
            {
                Invoke((MethodInvoker)(() =>
                RcvStart.Enabled = true));
                Invoke((MethodInvoker)(() =>
                RcvClose.Enabled = false));
            }
        }
        //送信
        private void SendBtn_Click(object sender, EventArgs e)
        {
            sendmessage();
        }

        private void sendmessage()
        {
            //データを送信するリモートホストとリモートポート
            string remoteHost = IPtxt.Text;
            int remotePort = int.Parse(RemotePort.Text);

            //バインドするローカルポート番号
            int localPort = int.Parse(LocalPort.Text);

            //ローカルポート番号localportにバインドする
            UdpClient udp = new UdpClient(localPort);

            //送信するデータを作成する
            string strmsg = SendMsg.Text;

            //変換
            byte[] sendBytes = Encoding.UTF8.GetBytes(strmsg.ToString());

            //時間取得
            DateTime dt = DateTime.Now;

            //時刻フォーマット
            string sendtime = dt.ToString("yyyy/MM/dd HH:mm:ss");

            try
            {
                //リモートホストを指定してデータを送信する
                udp.Send(sendBytes, sendBytes.Length, remoteHost, remotePort);

                Logtxt.Items.Insert(0, sendtime + "  " + "【SEND】:" + strmsg + "\r\n");

            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            udp.Close();
        }
        

    }
}
