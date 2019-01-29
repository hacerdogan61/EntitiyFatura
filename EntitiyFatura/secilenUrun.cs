using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFatura
{
  public class secilenUrun
    {
        public int UrunId
        {
            get; set;
        }
        public string UrunAdi
        {
            get; set;
        }
        public decimal miktar
        {
            get; set;
        }
        public decimal UrunFiyat
        {
            get; set;
        }
        public decimal ToplamTutar
        {
            get; set;
        }
        public decimal kdv
        {
            get; set;
        }
    }
}
