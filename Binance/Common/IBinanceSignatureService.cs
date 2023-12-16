using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_V3.Binance.Common
{
    //
    // Summary:
    //     Interface for signing payloads.
    public interface IBinanceSignatureService
    {
        string Sign(string payload);
    }
}