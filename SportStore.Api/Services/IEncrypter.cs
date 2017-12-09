using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Api.Services
{
    public interface IEncrypter
    {
        string GetSalt(string value);
        string GetHash(string calue, string salt);
    }
}
