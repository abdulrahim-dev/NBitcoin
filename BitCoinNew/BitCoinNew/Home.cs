using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NBitcoin;

namespace BitCoinNew
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var secret = new BitcoinSecret("cTZgKdjeErpXTa8jUYQutudDftDLcZy9BcRsAX69JShQha8gfbNu");
            var privateKey = secret.PrivateKey;
            var publicKey = privateKey.PubKey.GetAddress(Network.TestNet);
            txtPublicKey.Text = publicKey.ToString();

            /*
             * We can use this code to generate a new address
             * 
             * 
             * var key = new Key();
            txtPrivateKey.Text = key.ToString(Network.TestNet);
            txtPublicKey.Text = key.PubKey.GetAddress(Network.TestNet).ToString();
            lblAddress.Text = new BitcoinSecret(key.ToString(Network.TestNet)).ToString();*/

            /*
                Private Key
                cTZgKdjeErpXTa8jUYQutudDftDLcZy9BcRsAX69JShQha8gfbNu

                public Key
                n1xrTPJqWn2EENikHpaAEWB2Ao4Wg4kHAr
             */
        }
    }
}
