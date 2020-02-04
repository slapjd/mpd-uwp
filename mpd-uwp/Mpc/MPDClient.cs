using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace mpd_uwp.Mpc
{
    class MpdClient
    {
        private static Dictionary<MPDCommand, string> _commandDictionary
            = new Dictionary<MPDCommand, string>()
            {
                { MPDCommand.Play, "play" },
                { MPDCommand.Pause, "pause" },
                { MPDCommand.Stop, "stop" },
                { MPDCommand.Next, "next" },
                { MPDCommand.Previous, "previous" }
            };

        private TcpClient _tcpClient;
        private IPEndPoint _ipEndPoint;

        public MpdClient(IPEndPoint ipEndPoint)
        {
            _tcpClient = new TcpClient();
            _ipEndPoint = ipEndPoint;
        }

        public void Connect() => _tcpClient.Connect(_ipEndPoint);

        private String _BuildCommandString(MPDCommand command, object[] args)
        {
            string commandString;
            //If you need to add arguments, do it here
            switch (command)
            {
                default:
                    commandString = _commandDictionary[command];
                    break;
            }

            return commandString;
        }

        public void SendCommand(MPDCommand command, object[] args) 
        { 
            
        }
    }
}
