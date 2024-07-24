using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    internal class EntityBasvuruFormu
    {
        private int basvuruId;
        private int basDersID;
        private int basogrID;

        public int BasvuruId { get => BasvuruId1; set => BasvuruId1 = value; }
        public int BasvuruId1 { get => basvuruId; set => basvuruId = value; }
        public int BasogrID { get => basogrID; set => basogrID = value; }
    }
}
