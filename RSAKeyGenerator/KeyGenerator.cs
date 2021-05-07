using System;
using System.Windows.Forms;

namespace RSAKeyGenerator
{
    public partial class KeyGenerator : Form
    {
        public KeyGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var keys = Cryptographer.GenerateRSAKeysArray(rdo1024.Checked ? 1024 : 2048);
            txtPublicXml.Text = keys[0];
            txtPrivateXml.Text = keys[1];
            txtPublicPem.Text = RsaKeyConverter.XmlToPem(keys[0]);
            txtPrivatePem.Text = RsaKeyConverter.XmlToPem(keys[1]);
        }
    }
}
