using DB_First_Project_WinForm.Models;

namespace DB_First_Project_WinForm
{
    public partial class Form1 : Form
    {
        NorthwindContext _db;
        public Form1()
        {
            InitializeComponent();
            _db = new NorthwindContext();
            // FORM ACILDIGINDA BUTUN BOLGELERI GRIDVIEWDE GOSTER
            //var bolgeler = _db.Regions.ToList();
            Listele();
        }

        private void Listele()
        {
            dgvBolgeler.DataSource = null;
            dgvBolgeler.DataSource = _db.Regions.OrderBy(b => b.RegionDescription).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // ONCE YENI REGION OLUSTURMAK VE PROPERTYLERINI ATAMAMIZ LAZIM SONRA BU REGIONI DATABASE E 
            // KAYDETMEMIZ LAZIM

            // EGER YAZILAN IDYE AIT BIR BOLGE VARSA HATA VERSIN
            var bolge = _db.Regions.Find(Convert.ToInt32(txtId.Text));
            if (bolge != null)
            {
                MessageBox.Show(txtId.Text + " degerinde ID Bolgede var, baska ID giriniz.");
                return;
            }

            DB_First_Project_WinForm.Models.Region yeniBolge = new DB_First_Project_WinForm.Models.Region();
            yeniBolge.RegionId = Convert.ToInt32(txtId.Text);
            yeniBolge.RegionDescription = txtAd.Text;

            // BOLGELERE EKLER
            _db.Regions.Add(yeniBolge);

            // KAYDET
            _db.SaveChanges();

            // TABLOYU GUNCELLE
            Listele();

            MessageBox.Show(txtAd.Text + " bolgelere " + txtId.Text + " IDsine eklendi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string eskiAd;
                // ID TEXTBOX INA YAZILAN ID LI BOLGEYI YINE TANIM TANIM TEXTBOXINIA YENI DEGERLE GUNCELLENECEK
                // PK DEGISMEYECEK
                // ONCE ID YE AIT OLAN BOLGEYI DB DEN VERITABANINDAN CEKICEZ
                DB_First_Project_WinForm.Models.Region guncelleneckBolge = _db.Regions.FirstOrDefault
                    (r => r.RegionId == Convert.ToInt32(txtId.Text))!;  // firstordefault tek alýncak

                eskiAd = guncelleneckBolge.RegionDescription;

                // CEKTIGIMIZ BOLGENIN TANIMINI GUNCELLE
                guncelleneckBolge.RegionDescription = txtAd.Text;

                //KAYDETME
                _db.SaveChanges();

                //TABLO GUNCELLE
                Listele();

                MessageBox.Show(eskiAd.Trim() + " " + guncelleneckBolge.RegionDescription + " bolgesi olarak guncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message); ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string tanim;

            // ID TEXTBOX INA YAZILAN ID LI BOLGEYI YINE TANIM TANIM TEXTBOXINIA YENI DEGERLE SILECEK

            // ONCE O BOLGEYI GETIRELIM

            DB_First_Project_WinForm.Models.Region silinecekBolge = _db.Regions.FirstOrDefault
                    (r => r.RegionId == Convert.ToInt32(txtId.Text))!;


            if (silinecekBolge == null)
            {
                MessageBox.Show("Bolge Secmediniz, Bolge Silinemedi!");
            }

            tanim = silinecekBolge!.RegionDescription;

            // BOLGELERDEN KALDIRALIM
            _db.Regions.Remove(silinecekBolge!);

            // KAYDET
            _db.SaveChanges();

            // TABLOYU GUNCELLE
            Listele();

            MessageBox.Show(txtId.Text + " ID li " + tanim + " isimli bolge silindi!");
        }
    }
}
