using LeadSquared_PS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Card Object Class
namespace LeadSquared_PS.Objects
{
    class Cards
    {
        public CardNumbers CardNumber { get; set; }
        public CardShapes CardShape { get; set; }

        public Cards(CardShapes sh, CardNumbers num) {
            CardNumber = num;
            CardShape = sh;
        }
    }
}
