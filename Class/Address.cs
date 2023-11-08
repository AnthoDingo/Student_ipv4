using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mask = IPv4.Class.Masque;
using Network = IPv4.Class.Classe;
using NetType = IPv4.Class.Type;

namespace IPv4.Class
{
    internal class Address
    {
        int _A, _B, _C, _D;
        bool _isValid = false;

        internal Address(int A, int B, int C, int D)
        {
            _A = A;
            _B = B;
            _C = C;
            _D = D;
        }

        internal bool isValid
        {
            get
            {
                if (isOutOfRange(_A) || isOutOfRange(_B) || isOutOfRange(_C) || isOutOfRange(_D))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private bool isOutOfRange(int value)
        {
            if(value < 0 || value > 255)
            {
                return true;
            }

            return false;
        }

        internal string Classe { 
            get
            {
                if(_A < 128)
                {
                    return Network.A;
                } 
                else if(_A < 192) 
                { 
                    return Network.B;
                }
                else if(_A < 224)
                {
                    return Network.C;
                }
                else if(_A < 240)
                {
                    return Network.D;
                }
                else
                {
                    return Network.E;
                }
            } 
        }

        internal string Masque
        {
            get
            {
                switch(Classe)
                {
                    case "A":
                        return Mask.A;
                        break;
                    case "B":
                        return Mask.B;
                        break;
                    case "C":
                        return Mask.C;
                        break;
                    case "D":
                        return Mask.Full;
                        break;
                    case "E":
                        return Mask.NotConcerned;
                        break;
                    default:
                        return Mask.NotConcerned;
                }
            }
        }

        internal string Type
        {
            get
            {
                switch (Classe)
                {
                    case "A":
                        if (_A == 127)
                            return NetType.Loopback;

                        if (_B == 0 & _C == 0 & _D == 0)
                            return NetType.Network;

                        if(_B == 255 & _C == 255 & _D == 255)
                            return NetType.Broadcast;

                        return NetType.Unicast;
                        break;
                    case "B":
                        if (_C == 0 & _D == 0)
                            return NetType.Network;

                        if (_C == 255 & _D == 255)
                            return NetType.Broadcast;

                        return NetType.Unicast;
                        break;
                    case "C":
                        if (_D == 0)
                            return NetType.Network;

                        if (_D == 255)
                            return NetType.Broadcast;

                        return NetType.Unicast;

                        break;
                    case "D":
                        return NetType.Multicast;
                        break;
                    case "E":
                        return NetType.NotConcerned;
                        break;
                    default:
                        return NetType.NotConcerned;
                }
            }
        }
    }
}
