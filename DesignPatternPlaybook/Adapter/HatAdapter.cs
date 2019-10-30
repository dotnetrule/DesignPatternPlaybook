using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Adapter
{

    //Create to compatible thing
    public class HatAdapter : Item
    {
        private Hat _dataHat {get;set;}

        public HatAdapter(Hat dataHat)
        {
            this._dataHat = dataHat;
        }

        // example with property
        public override string Description
        {
            get { return _dataHat.Description; }
        }

        public override string itemName()
        {
            return this._dataHat.getName();
        }

        public override int itemPrice()
        {
            return this._dataHat.getPrice();
        }
    }
}
