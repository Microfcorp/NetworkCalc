using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkCalc.NetworkObjects;

namespace NetworkCalc
{
    public class NetworkMap
    {
        private Dictionary<string, BaseNetworkObject> Objects = new Dictionary<string, BaseNetworkObject>();
        /// <summary>
        /// Связь От-список Кому по хэшам
        /// </summary>
        private List<NetworkMapsLink> Links = new List<NetworkMapsLink>();

        /// <summary>
        /// Добавляет новый элемент на карту
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string Add(BaseNetworkObject obj)
        {
            string hash = Guid.NewGuid().ToString();
            Objects.Add(hash, obj);
            return hash;
        }

        /// <summary>
        /// Добавляет свезь между объектами
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public bool AddLink(string from, string to)
        {
            if (Links.Where(t => t.From == from).Any())
            {
                if (!Links.Where(t => t.From == from && t.To == to).Any())
                {
                    Links.Add(new NetworkMapsLink() { From = from, To = to });
                    return true;
                }
                else
                    return false;
            }
            else
            {
                Links.Add(new NetworkMapsLink() { From = from, To = to });
                return true;
            }
        }

        /// <summary>
        /// Добавляет свезь между объектами
        /// </summary>
        /// <param name="from">От кого</param>
        /// <param name="to">Кому</param>
        /// <returns></returns>
        public bool AddLink(NetworkMapsLink link)
        {
            if (Links.Where(t => t.From == link.From).Any())
            {
                if (!Links.Where(t => t.From == link.From && t.To == link.To).Any())
                {
                    Links.Add(link);
                    return true;
                }
                else
                    return false;
            }
            else
            {
                Links.Add(link);
                return true;
            }
        }

        /// <summary>
        /// Удаляет связь между объектами
        /// </summary>
        /// <param name="from">От кого</param>
        /// <param name="to">Кому</param>
        public void RemoveLink(string from, string to)
        {
            if (Links.Where(t => t.From == from).Any())
            {
                if (Links.Where(t => t.From == from && t.To == to).Any())
                {
                    Links.Remove(Links.Where(t => t.From == from && t.To == to).First());
                }
            }
        }
        /// <summary>
        /// Удаляет все связи с этим объектом
        /// </summary>
        public void RemoveLink(string obj)
        {
            if (Links.Where(t => t.From == obj || t.To == obj).Any())
            {
                var el = Links.Where(t => t.From == obj || t.To == obj).ToArray();
                foreach (var item in el)
                {
                    RemoveLink(item.From, item.To);
                }             
            }
        }
        /// <summary>
        /// Удаляет элемент с карты по хэшу
        /// </summary>
        /// <param name="hash"></param>
        public void Delete(string hash)
        {
            Objects.Remove(hash);
        }

        /// <summary>
        /// Возвращает список всех связей
        /// </summary>
        /// <returns></returns>
        public NetworkMapsLink[] ToLinksArray()
        {
            return Links.ToArray();
        }

        /// <summary>
        /// Возвращает массив объектов
        /// </summary>
        /// <returns></returns>
        public BaseNetworkObject[] ToArray()
        {
            return Objects.Values.ToArray();
        }

        /// <summary>
        /// Возвращает массив объектов с определенным типом
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public BaseNetworkObject[] GetToType(TypesNetworksObjects type)
        {
            return Objects.Where(t => t.Value.TypeNetworkObject == type).Select(t => t.Value).ToArray();
        }
    
        /// <summary>
        /// Возвращает или задает объект карты по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public BaseNetworkObject this[int index]
        {
            get
            {
                return Objects.ElementAt(index).Value;
            }
            set
            {
                Objects[Objects.ElementAt(index).Key] = value;
            }
        }

        /// <summary>
        /// Возвращает или задает объект карты по хэшу
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        public BaseNetworkObject this[string hash]
        {
            get
            {
                return Objects[hash];
            }
            set
            {
                Objects[hash] = value;
            }
        }
    }

    public class NetworkMapsLink
    {
        public NetworkMapsLink()
        {
            Speed = NetworkSpeed.Ethernet;
        }

        public NetworkMapsLink(string from, string to) : this()
        {
            From = from;
            To = to;
        }

        public NetworkMapsLink(string from, string to, NetworkSpeed speed) : this()
        {
            From = from;
            To = to;
            Speed = speed;
        }

        /// <summary>
        /// От кого
        /// </summary>
        public string From
        {
            get;
            set;
        }

        /// <summary>
        /// Кому
        /// </summary>
        public string To
        {
            get;
            set;
        }

        /// <summary>
        /// Скорость
        /// </summary>
        public NetworkSpeed Speed
        {
            get;
            set;
        }
    
        /// <summary>
        /// Возвращает цвет связи, соответствующей скорости
        /// </summary>
        /// <param name="Speed">Скорость сети</param>
        /// <returns></returns>
        public static Color GetNetworkColor(NetworkSpeed Speed)
        {
            if (Speed == NetworkSpeed.Ethernet)
                return Color.Orange;
            else if (Speed == NetworkSpeed.FastEthernet)
                return Color.Green;
            else if (Speed == NetworkSpeed.GigabitEthernet)
                return Color.Blue;
            else return Color.Black;
        }
    }
}
