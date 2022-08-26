using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;
using System.Windows.Forms;

namespace PileRa
{
    public class Pile
    {
        private double diameter;
        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
        public double Area
        {
            get
            {
                return Math.Round(Math.PI * diameter * diameter / 4.0, 3);
            }

        }
        public double Circumference
        {
            get
            {
                return Math.Round(Math.PI * diameter, 3);
            }
        }
        public double StartElevation { set; get; }
        public double EndElevation { set; get; }
        public double LayerThickness
        {
            get { return this.EndElevation - this.StartElevation; }
        }
        public string LayerName { set; get; }
        public string Label { set; get; }
        public double Qs { set; get; }
        public double Qp { set; get; }
        public double SCoeffient { set; get; }
        public double ECoeffient { set; get; }
        public double TCoeffient { set; get; }
        public double SideFrictionResistance
        {
            get
            {
                return this.Qs * this.SCoeffient * this.Circumference * this.LayerThickness;
            }
        }
        public double EndFrictionResistance
        {
            get
            {
                return this.Qp * this.ECoeffient * this.Area;
            }
        }
        public double Ra
        {
            get
            {
                return this.SideFrictionResistance + this.EndFrictionResistance;
            }
        }
        public List<Pile> ReadFile(string path)
        {
            List<Pile> pileList = new List<Pile>();
            XmlDocument doc = new XmlDocument();
            doc.Load(@path);
            XmlNode pileNode = doc.SelectSingleNode("pile");

            XmlNode infoNode = pileNode.SelectSingleNode("info");
            XmlNodeList infoList = infoNode.ChildNodes;


            XmlNodeList layerList = pileNode.SelectNodes("layer");
            for (int i = 0; i < layerList.Count; i++)
            {

                Pile pile = new Pile();
                pile.Diameter = Convert.ToDouble(infoList[0].InnerText);
                pile.SCoeffient = Convert.ToDouble(infoList[1].InnerText);
                pile.ECoeffient = Convert.ToDouble(infoList[2].InnerText);

                pile.Label = layerList.Item(i).ChildNodes[0].InnerText;
                pile.LayerName = layerList.Item(i).ChildNodes[1].InnerText;
                pile.StartElevation = Convert.ToDouble(layerList.Item(i).ChildNodes[2].InnerText);
                pile.EndElevation = Convert.ToDouble(layerList.Item(i).ChildNodes[3].InnerText);
                pile.TCoeffient = Convert.ToDouble(layerList.Item(i).ChildNodes[4].InnerText);
                pile.Qs = Convert.ToDouble(layerList.Item(i).ChildNodes[5].InnerText);
                pile.Qp = Convert.ToDouble(layerList.Item(i).ChildNodes[6].InnerText);
                pileList.Add(pile);
            }
            return pileList;
        }
    }
}
