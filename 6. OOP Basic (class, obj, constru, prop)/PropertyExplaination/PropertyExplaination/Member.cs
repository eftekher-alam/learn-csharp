using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExplaination
{
    class Member
    {
        // Both are work in the same way

        // This is one way to make a proparty
        // Private member property
        private string name;
        public string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }

        // This is shortest way to make a proparty
        // Just type prop and double tab
        public int Phone { get; set; }
    }
}
