using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoCrud.View.MasterDatail
{
    public class MasterDetailPage1MasterMenuItem
    {
        public MasterDetailPage1MasterMenuItem()
        {
            TargetType = typeof(MasterDetailPage1MasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }
    }
}