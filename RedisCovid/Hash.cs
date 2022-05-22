using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace RedisCovid
{
    internal class Hash
    {
        private string HashName { get; set; } = null!;
        private List<HashEntry> HashFields { get; set; } = null!;

        public Hash()
        {
            HashName = "";
            HashFields = new List<HashEntry>();
        }
        public void SetHashName(string hashName) { HashName = hashName; }
        public string GetHashName() { return HashName; }
        public List<HashEntry> GetFields() { return HashFields; }
        public void AddEntry(string fieldName, string content) { HashFields.Add(new HashEntry(fieldName, content)); }
        public void RemoveEntry(HashEntry hashEntry) { HashFields.Remove(hashEntry); }
    }
}
