using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.Serialization.Formatters.Binary;

namespace Database
{
    class serializeHandler
    {
        private byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
        private byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
        private Stream myFileStream;
        private RijndaelManaged RMCrypto = new RijndaelManaged();
        private BinaryFormatter ser = new BinaryFormatter();
        private CryptoStream CryptStream;


        public serializeHandler()
        {
            RMCrypto.Padding = PaddingMode.Zeros;
        }
        public void serialize(string filename, object toSave)
        {
            File.Delete(filename);
            myFileStream = File.Open(filename, FileMode.CreateNew);
            CryptStream = new CryptoStream(myFileStream, RMCrypto.CreateEncryptor(Key, IV), CryptoStreamMode.Write);
            ser.Serialize(CryptStream, (Object)toSave);
            CryptStream.FlushFinalBlock();
            myFileStream.Flush();
            CryptStream.Close();
            myFileStream.Close();
        }
        public Object deserialize(string filename)
        {
            if (File.Exists(filename))
            {
                myFileStream = File.Open(filename, FileMode.Open);
                myFileStream.Position = 0;
                CryptStream = new CryptoStream(myFileStream, RMCrypto.CreateDecryptor(Key, IV), CryptoStreamMode.Read);
                Object toReturn = (Object)(ser.Deserialize(CryptStream));
                myFileStream.Close();
                return toReturn;
            }
            return null;
        }
    }
}
