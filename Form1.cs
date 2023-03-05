using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkCalc.NetworkObjects;

namespace NetworkCalc
{
    public partial class Form1 : Form
    {
        private bool IsAdded = false;
        private bool IsAddedLink = false;
        private TypesNetworksObjects AddType = TypesNetworksObjects.Other;
        private NetworkMap Map = new NetworkMap();
        private KeyValuePair<string, string> AddLink = new KeyValuePair<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CreateObject(new Point(178, 226), TypesNetworksObjects.Commutator);
            //CreateObject(new Point(515, 92), TypesNetworksObjects.Commutator);
            //CreateLink(Map[0].HashMap, Map[1].HashMap);
        }

        private void AddObject(object sender, EventArgs e)
        {
            IsAdded = true;
            AddType = (TypesNetworksObjects)Enum.Parse(typeof(TypesNetworksObjects), (sender as ToolStripMenuItem).Tag.ToString());
            добавитьToolStripMenuItem.Image = BaseNetworkObject.GetImageFromType(AddType);
        }

        private void CreateLink(string from, string to)
        {
            SelectLinkParams slk = new SelectLinkParams();
            if(slk.ShowDialog() == DialogResult.OK)
            {
                Map.AddLink(new NetworkMapsLink(from, to, slk.Speed));
                tabPage1.Refresh();
                удалитьСвязьToolStripMenuItem.DropDownItems.Add(Map[from].NetworkName + " - " + Map[to].NetworkName, null, (a, b) => { Map.RemoveLink(from, to); tabPage1.Refresh(); удалитьСвязьToolStripMenuItem.DropDownItems.Remove(a as ToolStripItem); });
            }           
        }

        private void CreateObject(Point location, TypesNetworksObjects type)
        {
            добавитьToolStripMenuItem.Image = null;
            SelectObjectParams sop = new SelectObjectParams(type);
            if (sop.ShowDialog() != DialogResult.OK) return;

            BaseNetworkObject elem = null;
            if (type == TypesNetworksObjects.Commutator)
            {
                elem = new Commutator() { Location = location };
            }
            else if (type == TypesNetworksObjects.Conchetrator)
            {
                elem = new Commutator() { Location = location };
            }
            else if (type == TypesNetworksObjects.Mobile)
            {
                elem = new Commutator() { Location = location };
            }
            else if (type == TypesNetworksObjects.PC)
            {
                elem = new Commutator() { Location = location };
            }
            else if (type == TypesNetworksObjects.Server)
            {
                elem = new Commutator() { Location = location };           
            }
          
            tabPage1.Controls.Add(elem);
            var hash = Map.Add(elem);
            elem.HashMap = hash;
            elem.SetSettings(sop);
            elem.OnDelete += (a, b) => { Map.RemoveLink(hash); Map.Delete(hash); tabPage1.Refresh(); };
            elem.OnAddLink += (a, b) =>
            {
                if (IsAdded) return;

                if (!IsAddedLink) { IsAddedLink = true; AddLink = new KeyValuePair<string, string>(elem.HashMap, ""); Cursor = Cursors.Cross; }
                else 
                { 
                    IsAddedLink = false;
                    Cursor = Cursors.Default;
                    AddLink = new KeyValuePair<string, string>(AddLink.Key, elem.HashMap);
                    CreateLink(AddLink.Key, AddLink.Value);
                }
            };
            elem.OnClick += (a, b) =>
            {
                if (IsAdded) return;

                if (IsAddedLink)           
                {
                    Cursor = Cursors.Default;
                    IsAddedLink = false;
                    AddLink = new KeyValuePair<string, string>(AddLink.Key, elem.HashMap);
                    CreateLink(AddLink.Key, AddLink.Value);
                }
            };
        }

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsAdded)
            {
                if(e.Button == MouseButtons.Right)
                {
                    IsAdded = false;
                    добавитьToolStripMenuItem.Image = null;
                }
                else if(e.Button == MouseButtons.Left)
                {
                    IsAdded = false;
                    добавитьToolStripMenuItem.Image = null;
                    CreateObject(e.Location, AddType);
                }
            }
            if (IsAddedLink)
            {
                if (e.Button == MouseButtons.Left)
                {
                    IsAddedLink = false;
                    Cursor = Cursors.Default;
                }
            }
        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            var MapsGraphics = e.Graphics;
            var Links = Map.ToLinksArray();
            MapsGraphics.Clear(BackColor);

            for (int i = 0; i < Links.Length; i++)
            {
                var StartPoint = Map[Links[i].From].MinimalPoint(Map[Links[i].To]);
                var EndPoint = Map[Links[i].To].MinimalPoint(Map[Links[i].From]);
                //var EndPoint = Map[Links[i].From].Location;
                MapsGraphics.DrawLine(new Pen(NetworkMapsLink.GetNetworkColor(Links[i].Speed), 3f), StartPoint, EndPoint);
            }           
        }
    }
}
