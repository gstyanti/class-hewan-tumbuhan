using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_OOP
{
    class Tumbuhan
    {
        public string namaTumbuhan;
        public string jenisAkar;

        // method yang tidak mengembalikan nilai
        public string TampilkanNamaTumbuhan()
        {
            string NamaTumbuhan = this.namaTumbuhan;
            return
                NamaTumbuhan; 
        
        }
    }
}
