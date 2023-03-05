using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkCalc.NetworkObjects
{
    /// <summary>
    /// Базовый объект сетевой инфраструктуры
    /// </summary>
    public abstract class BaseNetworkObject : PictureBox
    {
        /// <summary>
        /// Возникает при удалении объекта
        /// </summary>
        public event EventHandler OnDelete;

        /// <summary>
        /// Возникает при щелчке левой кнопки мыши
        /// </summary>
        public event EventHandler OnLeftMouse;

        /// <summary>
        /// Возникает при добавлении новой связи
        /// </summary>
        public event EventHandler OnAddLink;

        /// <summary>
        /// Возникает при добавлении новой связи
        /// </summary>
        public new event EventHandler OnClick;

        /// <summary>
        /// Возникает при сохранении настроек
        /// </summary>
        public event EventHandler<SelectObjectParams> OnSettings;

        public BaseNetworkObject()
        {
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.Size = new System.Drawing.Size(64, 64);

            this.TypeNetworkObject = TypesNetworksObjects.Other;

            this.ContextMenuStrip = new ContextMenuStrip();
            this.ContextMenuStrip.Items.Add("Добавить связь", null, AddLk);
            this.ContextMenuStrip.Items.Add("Параметры устройства", null, Setting);
            this.ContextMenuStrip.Items.Add("Удалить", null, Delete);

            this.MouseClick += (a, b) => { if (b.Button == MouseButtons.Left) OnLeftMouse?.Invoke(this, new EventArgs()); };
            this.Click += (a, b) => { OnClick?.Invoke(this, new EventArgs()); };

            var tt = new ToolTip();
            tt.SetToolTip(this, NetworkName);
        }

        /// <summary>
        /// Инициализирует изображение и класс
        /// </summary>
        public void Init()
        {
            this.Image = GetImageFromType(TypeNetworkObject);
        }

        /// <summary>
        /// Тип сетевого объекта
        /// </summary>
        public TypesNetworksObjects TypeNetworkObject
        {
            get;
            internal set;
        }

        /// <summary>
        /// Хэш объекта на карте
        /// </summary>
        public string HashMap
        {
            get => Name;
            set => Name = value;
        }

        /// <summary>
        /// Сетевое имя объекта
        /// </summary>
        public string NetworkName
        {
            get;
            set;
        }

        /// <summary>
        /// Удаляет объект
        /// </summary>
        public void Delete()
        {
            Delete(null, null);
        }

        private void Delete(object sender, EventArgs e)
        {
            Dispose(true);
            OnDelete?.Invoke(this, new EventArgs());
        }

        private void AddLk(object sender, EventArgs e)
        {
            OnAddLink?.Invoke(this, new EventArgs());
        }
        private void Setting(object sender, EventArgs e)
        {
            SelectObjectParams sop = new SelectObjectParams(TypeNetworkObject);
            sop.FromNetworkObject(this);
            if (sop.ShowDialog() != DialogResult.OK) return;
            NetworkName = sop.NameObject;
            OnSettings?.Invoke(this, sop);
        }

        public void SetSettings(SelectObjectParams sop)
        {
            NetworkName = sop.NameObject;
            OnSettings?.Invoke(this, sop);
        }

        public static Image GetImageFromType(TypesNetworksObjects type)
        {
            if (type == TypesNetworksObjects.Commutator)
            {
                return Properties.Resources.коммутатор;
            }
            else if (type == TypesNetworksObjects.Conchetrator)
            {
                return Properties.Resources.Концентратор;
            }
            else if (type == TypesNetworksObjects.Mobile)
            {
                return Properties.Resources.Телефон;
            }
            else if (type == TypesNetworksObjects.PC)
            {
                return Properties.Resources.Коспьютер;
            }
            else if (type == TypesNetworksObjects.Server)
            {
                return Properties.Resources.Сервер;
            }
            return Properties.Resources.солнце;
        }
    }

    public enum TypesNetworksObjects : byte
    {
        Commutator,
        Conchetrator,
        PC,
        Server,
        Mobile,
        Other,
    }
}
