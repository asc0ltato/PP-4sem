using System.Security.Cryptography;

namespace Lab5Lib
{
    public class DecRSA : Decorator
    {
        public DecRSA(IWriter writer) : base(writer) { }

        public override string? Save(string message)
        {
            message = message ?? string.Empty;
            int delimiterIndex = message.IndexOf(Constant.Delimiter);
            if (delimiterIndex == -1) throw new Exception("delimiter not found");
            string info = message.Substring(0, delimiterIndex);
            string hash = message.Substring(delimiterIndex + 1);
            byte[] hashBytes = Convert.FromBase64String(hash);

            string publicKeyXml;
            byte[] encyptedData;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                publicKeyXml = rsa.ToXmlString(true);
                encyptedData = rsa.Encrypt(hashBytes, false);
            }

            string result = $"{info}{Lab5Lib.Constant.Delimiter}{Convert.ToBase64String(encyptedData)}{Lab5Lib.Constant.Delimiter}{publicKeyXml}";
            return writer.Save(result);
        }
    }
}