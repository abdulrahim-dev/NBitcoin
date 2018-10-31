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
            var publicKey = privateKey.PubKey;
            var publicKeyHash = publicKey.Hash;


            txtPublicKey.Text = publicKey.GetAddress(Network.TestNet).ToString();
            
            var testNetAddress = publicKeyHash.GetAddress(Network.TestNet);
            var mainNetAddress = publicKeyHash.GetAddress(Network.Main);

            listBox1.Items.Add("testNetAddress( "+testNetAddress+" ) ScriptPubKey= " + testNetAddress.ScriptPubKey);
            /*
             * We can use this code to generate a new address
             * 
             * 
            var key = new Key();                                                // Step 1 - Generate a random private key
            var privateKey = key.ToString(Network.TestNet);                          // privateKey
            var publicKey=key.PubKey;                                                      // Step 2 - Public key 
            var bitCoinAddress = key.PubKey.GetAddress(Network.TestNet).ToString();             //Step 3 - Bitcoin Address
            
             */



            /*
                Private Key
                cTZgKdjeErpXTa8jUYQutudDftDLcZy9BcRsAX69JShQha8gfbNu

                public Key
                n1xrTPJqWn2EENikHpaAEWB2Ao4Wg4kHAr
             */
        }
    }
}
