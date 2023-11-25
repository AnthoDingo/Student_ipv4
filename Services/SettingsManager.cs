using IPv4.Class;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace IPv4.Services
{
    internal class SettingsManager
    {

        public void WriteSettings(string filePath, Setting data, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                byte[] serializedData;

                // Serialize the data
                using (MemoryStream ms = new MemoryStream())
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(ms, data);
                    serializedData = ms.ToArray();
                }

                // Encrypt the serialized data
                byte[] encrypted = EncryptStringToBytes_Aes(serializedData, aes.Key, aes.IV);

                // Write the encrypted data to the binary file
                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                {
                    writer.Write(encrypted);
                }
            }
        }

        public Setting ReadSettings(string filePath, byte[] key, byte[] iv)
        {
            byte[] encrypted;
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                encrypted = reader.ReadBytes((int)reader.BaseStream.Length);
            }

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                byte[] decrypted = DecryptStringFromBytes_Aes(encrypted, aes.Key, aes.IV);

                Setting setting;
                using (MemoryStream ms = new MemoryStream(decrypted))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    setting = (Setting)formatter.Deserialize(ms);
                }

                return setting;
            }
        }

        static byte[] EncryptStringToBytes_Aes(byte[] plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(plainText, 0, plainText.Length);
                        csEncrypt.FlushFinalBlock();
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
        }

        static byte[] DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            byte[] plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            csDecrypt.CopyTo(ms);
                            plaintext = ms.ToArray();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}
