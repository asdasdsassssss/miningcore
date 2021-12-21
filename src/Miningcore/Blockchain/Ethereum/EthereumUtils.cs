using System;
using System.Linq;
using System.Numerics;
using Nethereum.Hex.HexConvertors.Extensions;

namespace Miningcore.Blockchain.Ethereum
{
    public class EthereumUtils
    {
        public static void DetectNetworkAndChain(string netVersionResponse, string gethChainResponse,
            out EthereumNetworkType networkType, out GethChainType chainType)
        {
            // convert network
            if(int.TryParse(netVersionResponse, out var netWorkTypeInt))
            {
                networkType = (EthereumNetworkType) netWorkTypeInt;

                if(!Enum.IsDefined(typeof(EthereumNetworkType), networkType))
                    networkType = EthereumNetworkType.Unknown;
            }

            else
                networkType = EthereumNetworkType.Unknown;

            // convert chain
            if(!Enum.TryParse(gethChainResponse, true, out chainType))
            {
                chainType = GethChainType.Unknown;
            }

            if(chainType == GethChainType.Ethereum)
                chainType = GethChainType.Ethereum;

            if(chainType == GethChainType.Callisto)
                chainType = GethChainType.Callisto;

            if(chainType == GethChainType.Expanse)
                chainType = GethChainType.Expanse;

            if(chainType == GethChainType.Classic)
                chainType = GethChainType.Classic;
            

        }

        public static string GetTargetHex(double difficulty)
        {
            var diff = new BigInteger(difficulty * EthereumConstants.Pow2x32);
            var target = BigInteger.Divide(EthereumConstants.BigMaxValue, diff);
            var hex = target.ToByteArray(true, true).ToHex();
            return $"0x{string.Concat(Enumerable.Repeat("0", 64 - hex.Length))}{hex}";
        }

    }
}
