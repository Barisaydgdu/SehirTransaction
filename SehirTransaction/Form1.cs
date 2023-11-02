using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SehirTransaction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstIlceler.Items.Add(txtIlceAd.Text);
            txtIlceAd.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SehirlerEntities1 vt = new SehirlerEntities1();
            using (var transaction = vt.Database.BeginTransaction())
            {
                try
                {
                    Il yeniIl = new Il();
                    yeniIl.IlAd = txtIlAd.Text;
                    yeniIl.IlPlaka = txtPlaka.Text;
                    vt.Il.Add(yeniIl);
                    vt.SaveChanges();
                    int kaydedilenIlID = yeniIl.IlID; //insert edilen primarykey i döndürür
                    foreach (var item in lstIlceler.Items)
                    {
                        Ilce yeniIlce = new Ilce();
                        yeniIlce.IlId = kaydedilenIlID;
                        yeniIlce.IlceAd = item.ToString();
                        vt.Ilce.Add(yeniIlce);
                        vt.SaveChanges();
                    }                    
                }
                catch (Exception hata)
                {
                    transaction.Rollback(); //hata oluşursa verileri eski haline getir
                }
                finally
                {
                    transaction.Commit(); //hata yoksa işlemi onayla
                    IlleriDoldur();
                    txtIlAd.Clear();
                    txtPlaka.Clear();
                    lstIlceler.Items.Clear();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IlleriDoldur();
        }



        void IlleriDoldur()
        {
            treeView1.Nodes.Clear();
            //illeri çek
            SehirlerEntities1 vt = new SehirlerEntities1();
            List<Il> ilListesi = vt.Il.ToList();
            List<Ilce> ilceListesi = vt.Ilce.ToList();

            foreach (Il item in ilListesi)
            {
                treeView1.Nodes.Add(item.IlID.ToString(),item.IlAd);
                foreach (var ilce in item.Ilce)
                {
                    treeView1.Nodes[item.IlID.ToString()].Nodes.Add(ilce.IlceAd);
                }
            }
        }
    }
}
