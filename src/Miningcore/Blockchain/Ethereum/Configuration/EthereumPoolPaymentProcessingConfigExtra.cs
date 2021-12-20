namespace Miningcore.Blockchain.Ethereum.Configuration;
{
public class EthereumPoolPaymentProcessingConfigExtra
{
    /// <summary>
    /// True to exempt transaction fees from miner rewards
    /// </summary>
    public bool KeepTransactionFees { get; set; }

    /// <summary>
    /// True to exempt uncle rewards from miner rewards
    /// </summary>
    public bool KeepUncles { get; set; }
	
    /// <summary>
    /// True let geth to determine gas and gasPrice
    /// </summary>
    public bool? AutoGas { get; set; }
	
    /// <summary>
    /// Gas amount for payout tx (advanced users only)
    /// </summary>
    public ulong Gas { get; set; }

    /// <summary>
    /// Gas price for payout tx (advanced users only)
    /// </summary>
    public ulong GasPrice { get; set; }

    /// <summary>
    /// if true commission is charged from the miner payout amount is relevant for Ethereum EIP-1559 
    /// </summary>
    public bool? MinerTxFee { get; set; }

    /// <summary>
    /// maximum amount you’re willing to pay
    /// </summary>
    public ulong MaxFeePerGas { get; set; }
}
}
