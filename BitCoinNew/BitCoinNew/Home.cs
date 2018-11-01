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

            Transaction transaction = new Transaction();
            var input = new TxIn();
            input.PrevOut = new OutPoint(new uint256("c5eb6cc0481e4ae17c812a5ce444ed746991b1532990bdb6e063215b35092bc2"), 1);
            input.ScriptSig = secret.GetAddress().ScriptPubKey;
            transaction.AddInput(input);

            TxOut output = new TxOut();
            var destination = BitcoinAddress.Create("mhYPDTTnNWFAc15EsqcAPgEddD1ytNcH7x");
            Money fee = Money.Satoshis(40000);
            output.Value = Money.Coins(0.01m)-fee;
            output.ScriptPubKey = destination.ScriptPubKey;
            transaction.AddOutput(output);

            transaction.Sign(secret, false);




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
