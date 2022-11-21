using System.Security.Cryptography;

namespace CrypterBib
{
    public class Crypter
    {
        Aes aes;
        ICryptoTransform cryptoTransform;

        public static long n;
        public static long i;

        public static bool working = false;

        int block_size;

        private Thread t;
        private string res_file_name;
        public Crypter(int block_size)
        {
            aes = Aes.Create();
            aes.KeySize = 128;
            aes.BlockSize = 128;
            aes.Key = System.Text.Encoding.ASCII.GetBytes("1234567890123456");
            aes.IV = System.Text.Encoding.ASCII.GetBytes("1234567890123456");
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            this.block_size = block_size;
        }

        public void EncryptFile(string file_name, string key)
        {
            if (working)
                return;

            aes.Key = System.Text.Encoding.ASCII.GetBytes(key);
            cryptoTransform = aes.CreateEncryptor();

            res_file_name = "Encrypted\\Encrypted_" + file_name;

            for (int i = file_name.Length - 1; i >= 0; i--)
                if (file_name[i] == '\\')
                {
                    res_file_name = "Encrypted\\Encrypted_" + file_name.Substring(i + 1, file_name.Length - i - 1);
                    break;
                }

            t = new Thread(() =>
            {
                Crypter.working = true;
                TransformFile(file_name, res_file_name, block_size);
                Crypter.working = false;
            });

            t.Start();
        }

        public void DecryptFile(string file_name, string key)
        {
            if (working)
                return;

            aes.Key = System.Text.Encoding.ASCII.GetBytes(key);
            cryptoTransform = aes.CreateDecryptor();

            res_file_name = "Decrypted\\Decrypted_" + file_name;

            for (int i = file_name.Length - 1; i >= 0; i--)
                if (file_name[i] == '\\')
                {
                    res_file_name = "Decrypted\\Decrypted_" + file_name.Substring(i + 1, file_name.Length - i - 1);
                    break;
                }

            t = new Thread(() =>
            {
                Crypter.working = true;
                TransformFile(file_name, res_file_name, block_size + 16);
                Crypter.working = false;
            });

            t.Start();
        }

        public void TransformFile(string file_name, string res_file_name, int block_size)
        {
            using (FileStream fs = new FileStream(file_name, FileMode.Open, FileAccess.Read))
            {
                using (FileStream out_fs = new FileStream(res_file_name, FileMode.Create, FileAccess.Write))
                {
                    Crypter.n = fs.Length / block_size;
                    Crypter.i = 0;
                    while (true)
                    {
                        if (!Crypter.working)
                        {
                            out_fs.Dispose();
                            File.Delete(res_file_name);
                            break;
                        }

                        Byte[] buffer = new Byte[block_size];

                        int n = fs.Read(buffer, 0, buffer.Length);

                        if (n == 0)
                            break;
                        byte[] output = new byte[buffer.Length];
                        try
                        {
                            output = cryptoTransform.TransformFinalBlock(buffer, 0, buffer.Length);
                        }
                        catch
                        {
                            
                        }

                        out_fs.Write(output, 0, output.Length);
                        Crypter.i++;
                    }
                }
            }
        }

        public void Stop()
        {
            Crypter.working = false;
        }
    }
}