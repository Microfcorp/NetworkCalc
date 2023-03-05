using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkCalc.NetworkObjects
{
    /// <summary>
    /// Объект коммутатора
    /// </summary>
    public class Commutator : BaseNetworkObject
    {
        public Commutator() : base()
        {
            this.TypeNetworkObject = TypesNetworksObjects.Commutator;
            this.Init();
        }

        /// <summary>
        /// Максимальное количество портов
        /// </summary>
        public int MaximumPorts
        {
            get;
            set;
        }

        /// <summary>
        /// Описание портов
        /// </summary>
        public NetworkPort[] Ports
        {
            get;
            set;
        }
    }

    public struct NetworkPort
    {
        NetworkSpeed Speed;
    }
}
