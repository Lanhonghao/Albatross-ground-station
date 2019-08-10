using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Albatross_ground_station
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GMapControl1_Load(object sender, EventArgs e)
        {
            this.gMapControl1.MapProvider = OpenStreet4UMapProvider.Instance; // 设置地图源
            GMaps.Instance.Mode = AccessMode.ServerAndCache; // GMap工作模式
            this.gMapControl1.SetPositionByKeywords("北京"); // 地图中心位置

            //使用经纬度设置地图中心
            //this.gMapControl1.Position = new GMap.NET.PointLatLng(39.923518, 116.539009);
        }
    }
}
