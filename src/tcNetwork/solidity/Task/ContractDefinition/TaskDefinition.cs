using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Solidity.Contracts.Task.ContractDefinition
{


    public partial class TaskDeployment : TaskDeploymentBase
    {
        public TaskDeployment() : base(BYTECODE) { }
        public TaskDeployment(string byteCode) : base(byteCode) { }
    }

    public class TaskDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801561001057600080fd5b50600080546001600160a01b031916331781556001805460ff60a01b191690556006805460ff1916905561155e90819061004a90396000f3fe608060405234801561001057600080fd5b506004361061009e5760003560e01c8063bf33b65a11610066578063bf33b65a146103c3578063dc582aa714610737578063faf8101d1461075d578063fe6b606c14610779578063ff5fa8e71461079c5761009e565b806383197ef0146100a35780638bb397be146100ad5780638d84aa4c14610359578063b4a99a4e1461037c578063b983b525146103a0575b600080fd5b6100ab6107e9565b005b6100b5610840565b6040518080602001896001600160a01b03166001600160a01b031681526020018860018111156100e157fe5b60ff168152602001806020018060200180602001806020018060200187810387528f818151815260200191508051906020019080838360005b8381101561013257818101518382015260200161011a565b50505050905090810190601f16801561015f5780820380516001836020036101000a031916815260200191505b5087810386528c5181528c516020918201918e019080838360005b8381101561019257818101518382015260200161017a565b50505050905090810190601f1680156101bf5780820380516001836020036101000a031916815260200191505b5087810385528b5181528b516020918201918d019080838360005b838110156101f25781810151838201526020016101da565b50505050905090810190601f16801561021f5780820380516001836020036101000a031916815260200191505b5087810384528a5181528a516020918201918c019080838360005b8381101561025257818101518382015260200161023a565b50505050905090810190601f16801561027f5780820380516001836020036101000a031916815260200191505b5087810383528951815289516020918201918b019080838360005b838110156102b257818101518382015260200161029a565b50505050905090810190601f1680156102df5780820380516001836020036101000a031916815260200191505b5087810382528851815288516020918201918a019080838360005b838110156103125781810151838201526020016102fa565b50505050905090810190601f16801561033f5780820380516001836020036101000a031916815260200191505b509e50505050505050505050505050505060405180910390f35b6100ab6004803603604081101561036f57600080fd5b5080359060200135610c4c565b610384610dc0565b604080516001600160a01b039092168252519081900360200190f35b6100ab600480360360408110156103b657600080fd5b5080359060200135610dd0565b6100ab60048036036101a08110156103da57600080fd5b810190602081018135600160201b8111156103f457600080fd5b82018360208201111561040657600080fd5b803590602001918460018302840111600160201b8311171561042757600080fd5b91908080601f01602080910402602001604051908101604052809392919081815260200183838082843760009201919091525092956001600160a01b038535169560ff60208701351695919450925060608101915060400135600160201b81111561049157600080fd5b8201836020820111156104a357600080fd5b803590602001918460018302840111600160201b831117156104c457600080fd5b91908080601f0160208091040260200160405190810160405280939291908181526020018383808284376000920191909152509295949360208101935035915050600160201b81111561051657600080fd5b82018360208201111561052857600080fd5b803590602001918460018302840111600160201b8311171561054957600080fd5b91908080601f0160208091040260200160405190810160405280939291908181526020018383808284376000920191909152509295949360208101935035915050600160201b81111561059b57600080fd5b8201836020820111156105ad57600080fd5b803590602001918460018302840111600160201b831117156105ce57600080fd5b91908080601f016020809104026020016040519081016040528093929190818152602001838380828437600092019190915250929560ff8535169560208601359560408101359550606081013594506080810135935060c081019060a00135600160201b81111561063e57600080fd5b82018360208201111561065057600080fd5b803590602001918460018302840111600160201b8311171561067157600080fd5b91908080601f0160208091040260200160405190810160405280939291908181526020018383808284376000920191909152509295949360208101935035915050600160201b8111156106c357600080fd5b8201836020820111156106d557600080fd5b803590602001918460018302840111600160201b831117156106f657600080fd5b91908080601f016020809104026020016040519081016040528093929190818152602001838380828437600092019190915250929550610f07945050505050565b6100ab6004803603604081101561074d57600080fd5b5060ff81351690602001356110ce565b610765611248565b604080519115158252519081900360200190f35b6100ab6004803603604081101561078f57600080fd5b5080359060200135611269565b6107a46113cd565b604051808760048111156107b457fe5b60ff1681526020810196909652506040808601949094526060850192909252608084015260a0830152519081900360c0019150f35b6000546001600160a01b031633146108325760405162461bcd60e51b815260040180806020018281038252602e8152602001806114fc602e913960400191505060405180910390fd5b6000546001600160a01b0316ff5b606060008082808080806001808054600160a01b900460ff169081111561086357fe5b146108ad576040805162461bcd60e51b81526020600482015260156024820152745461736b206e6f7420696e697469616c697365642160581b604482015290519081900360640190fd5b6002805460408051602060018416156101000260001901909316849004601f810184900484028201840190925281815292918301828280156109305780601f1061090557610100808354040283529160200191610930565b820191906000526020600020905b81548152906001019060200180831161091357829003601f168201915b50505050509750600160009054906101000a90046001600160a01b03169650600660009054906101000a900460ff16955060038054600181600116156101000203166002900480601f0160208091040260200160405190810160405280929190818152602001828054600181600116156101000203166002900480156109f75780601f106109cc576101008083540402835291602001916109f7565b820191906000526020600020905b8154815290600101906020018083116109da57829003601f168201915b505060048054604080516020601f60026000196101006001881615020190951694909404938401819004810282018101909252828152969b5091945092508401905082828015610a885780601f10610a5d57610100808354040283529160200191610a88565b820191906000526020600020905b815481529060010190602001808311610a6b57829003601f168201915b505060058054604080516020601f60026000196101006001881615020190951694909404938401819004810282018101909252828152969a5091945092508401905082828015610b195780601f10610aee57610100808354040283529160200191610b19565b820191906000526020600020905b815481529060010190602001808311610afc57829003601f168201915b505060078054604080516020601f6002600019610100600188161502019095169490940493840181900481028201810190925282815296995091945092508401905082828015610baa5780601f10610b7f57610100808354040283529160200191610baa565b820191906000526020600020905b815481529060010190602001808311610b8d57829003601f168201915b505060088054604080516020601f6002600019610100600188161502019095169490940493840181900481028201810190925282815296985091945092508401905082828015610c3b5780601f10610c1057610100808354040283529160200191610c3b565b820191906000526020600020905b815481529060010190602001808311610c1e57829003601f168201915b505050505090509091929394959697565b6000546001600160a01b03163314610c955760405162461bcd60e51b815260040180806020018281038252602e8152602001806114fc602e913960400191505060405180910390fd5b6001808054600160a01b900460ff1690811115610cae57fe5b14610cf5576040805162461bcd60e51b815260206004820152601260248201527115185cdac81b9bdd081cd8da19591d5b195960721b604482015290519081900360640190fd5b600d805482019055604080516020810183905290810183905260608082526002805460001961010060018316150201168190049183018290527f8a529ae4ee11eb4cde46982ce654de7d45969118e8db3fd279b6438583e7d9f8929091849186918190608082019086908015610dac5780601f10610d8157610100808354040283529160200191610dac565b820191906000526020600020905b815481529060010190602001808311610d8f57829003601f168201915b505094505050505060405180910390a15050565b6000546001600160a01b03165b90565b6000546001600160a01b03163314610e195760405162461bcd60e51b815260040180806020018281038252602e8152602001806114fc602e913960400191505060405180910390fd5b6001808054600160a01b900460ff1690811115610e3257fe5b14610e79576040805162461bcd60e51b815260206004820152601260248201527115185cdac81b9bdd081cd8da19591d5b195960721b604482015290519081900360640190fd5b6009829055600b819055604080516020810183905290810183905260608082526002805460001961010060018316150201168190049183018290527fa44eccd2c729e4c0f0c88952c7d842d9e4f9617fed846408b59c9c8a0764f941929091849186918190608082019086908015610dac5780601f10610d8157610100808354040283529160200191610dac565b6000546001600160a01b03163314610f505760405162461bcd60e51b815260040180806020018281038252602e8152602001806114fc602e913960400191505060405180910390fd5b600060018054600160a01b900460ff1690811115610f6a57fe5b14610fbc576040805162461bcd60e51b815260206004820152601e60248201527f5461736b2068656164657220697320616c726561647920617369676e65640000604482015290519081900360640190fd5b8c60029080519060200190610fd2929190611463565b50600180546001600160a01b0319166001600160a01b038e16178155600680548d9260ff1990911690838181111561100657fe5b0217905550895161101e9060039060208d0190611463565b5088516110329060049060208c0190611463565b5087516110469060059060208b0190611463565b506001805488919060ff60a81b1916600160a81b83600481111561106657fe5b02179055506009869055600a859055600b849055600c8390556000600d558151611097906007906020850190611463565b5080516110ab906008906020840190611463565b50506001805460ff60a01b1916600160a01b179055505050505050505050505050565b6000546001600160a01b031633146111175760405162461bcd60e51b815260040180806020018281038252602e8152602001806114fc602e913960400191505060405180910390fd5b6001808054600160a01b900460ff169081111561113057fe5b14611182576040805162461bcd60e51b815260206004820152601a60248201527f5461736b20686173206e6f20696e697469616c20737461747573000000000000604482015290519081900360640190fd5b6001805483919060ff60a81b1916600160a81b8360048111156111a157fe5b02179055507f0907b8f24e5dcd14bf00e4236c0a9d82bfc01e7fd94bcc3737fba7071ce8557b6002600160159054906101000a900460ff168360405180806020018460048111156111ee57fe5b60ff1681526020810184905260408382038101835286546002600182161561010002600019019091160490820181905260609091019086908015610dac5780601f10610d8157610100808354040283529160200191610dac565b60006001808054600160a01b900460ff169081111561126357fe5b14905090565b6000546001600160a01b031633146112b25760405162461bcd60e51b815260040180806020018281038252602e8152602001806114fc602e913960400191505060405180910390fd5b6001808054600160a01b900460ff16908111156112cb57fe5b14611314576040805162461bcd60e51b815260206004820152601460248201527315185cdac81b9bdd081a5b9a5d1a585b1a5cd95960621b604482015290519081900360640190fd5b600a829055600c8190556040805160208082526002805460001961010060018316150201168190049183018290527fa3ad20f36157ec2ab45c618cf1181d249a46caf5ce540129ab7afea76effb196939092918291820190849080156113bb5780601f10611390576101008083540402835291602001916113bb565b820191906000526020600020905b81548152906001019060200180831161139e57829003601f168201915b50509250505060405180910390a15050565b600080808080806001808054600160a01b900460ff16908111156113ed57fe5b14611437576040805162461bcd60e51b81526020600482015260156024820152745461736b206e6f7420696e697469616c697365642160581b604482015290519081900360640190fd5b5050600154600954600a54600b54600c54600d54600160a81b90950460ff169993985091965094509250565b828054600181600116156101000203166002900490600052602060002090601f016020900481019282601f106114a457805160ff19168380011785556114d1565b828001600101855582156114d1579182015b828111156114d15782518255916020019190600101906114b6565b506114dd9291506114e1565b5090565b610dcd91905b808211156114dd57600081556001016114e756fe4f6e6c792074686520636f6e7472616374206f776e65722063616e2063616c6c20746869732066756e6374696f6ea265627a7a723158201846e1f54bbe74f9a9f57705d949b67ee212d9ee59d72fa9f471b3a9af2e8e3264736f6c634300050c0032";
        public TaskDeploymentBase() : base(BYTECODE) { }
        public TaskDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class DeliveredFunction : DeliveredFunctionBase { }

    [Function("Delivered")]
    public class DeliveredFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_actionOn", 1)]
        public virtual BigInteger ActionOn { get; set; }
        [Parameter("uint256", "_quantity", 2)]
        public virtual BigInteger Quantity { get; set; }
    }

    public partial class GetHeaderFunction : GetHeaderFunctionBase { }

    [Function("GetHeader", typeof(GetHeaderOutputDTO))]
    public class GetHeaderFunctionBase : FunctionMessage
    {

    }

    public partial class GetScheduleFunction : GetScheduleFunctionBase { }

    [Function("GetSchedule", typeof(GetScheduleOutputDTO))]
    public class GetScheduleFunctionBase : FunctionMessage
    {

    }

    public partial class InitialiseFunction : InitialiseFunctionBase { }

    [Function("Initialise")]
    public class InitialiseFunctionBase : FunctionMessage
    {
        [Parameter("string", "_taskCode", 1)]
        public virtual string TaskCode { get; set; }
        [Parameter("address", "_targetConsortium", 2)]
        public virtual string TargetConsortium { get; set; }
        [Parameter("uint8", "_polarity", 3)]
        public virtual byte Polarity { get; set; }
        [Parameter("string", "_activityCode", 4)]
        public virtual string ActivityCode { get; set; }
        [Parameter("string", "_description", 5)]
        public virtual string Description { get; set; }
        [Parameter("string", "_title", 6)]
        public virtual string Title { get; set; }
        [Parameter("uint8", "_status", 7)]
        public virtual byte Status { get; set; }
        [Parameter("uint256", "_actionOn", 8)]
        public virtual BigInteger ActionOn { get; set; }
        [Parameter("uint256", "_unitCharge", 9)]
        public virtual BigInteger UnitCharge { get; set; }
        [Parameter("uint256", "_quantity", 10)]
        public virtual BigInteger Quantity { get; set; }
        [Parameter("uint256", "_taxRate", 11)]
        public virtual BigInteger TaxRate { get; set; }
        [Parameter("string", "_unitOfMeasure", 12)]
        public virtual string UnitOfMeasure { get; set; }
        [Parameter("string", "_unitOfCharge", 13)]
        public virtual string UnitOfCharge { get; set; }
    }

    public partial class IsInitialisedFunction : IsInitialisedFunctionBase { }

    [Function("IsInitialised", "bool")]
    public class IsInitialisedFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("Owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class PriceChangeFunction : PriceChangeFunctionBase { }

    [Function("PriceChange")]
    public class PriceChangeFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_unitCharge", 1)]
        public virtual BigInteger UnitCharge { get; set; }
        [Parameter("uint256", "_taxRate", 2)]
        public virtual BigInteger TaxRate { get; set; }
    }

    public partial class RescheduleFunction : RescheduleFunctionBase { }

    [Function("Reschedule")]
    public class RescheduleFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_actionOn", 1)]
        public virtual BigInteger ActionOn { get; set; }
        [Parameter("uint256", "_quantity", 2)]
        public virtual BigInteger Quantity { get; set; }
    }

    public partial class SetStatusFunction : SetStatusFunctionBase { }

    [Function("SetStatus")]
    public class SetStatusFunctionBase : FunctionMessage
    {
        [Parameter("uint8", "_status", 1)]
        public virtual byte Status { get; set; }
        [Parameter("uint256", "_actionedOn", 2)]
        public virtual BigInteger ActionedOn { get; set; }
    }

    public partial class DestroyFunction : DestroyFunctionBase { }

    [Function("destroy")]
    public class DestroyFunctionBase : FunctionMessage
    {

    }

    public partial class OnDeliveryEventDTO : OnDeliveryEventDTOBase { }

    [Event("OnDelivery")]
    public class OnDeliveryEventDTOBase : IEventDTO
    {
        [Parameter("string", "taskCode", 1, false )]
        public virtual string TaskCode { get; set; }
        [Parameter("uint256", "quantity", 2, false )]
        public virtual BigInteger Quantity { get; set; }
        [Parameter("uint256", "actionedOn", 3, false )]
        public virtual BigInteger ActionedOn { get; set; }
    }

    public partial class OnPriceChangeEventDTO : OnPriceChangeEventDTOBase { }

    [Event("OnPriceChange")]
    public class OnPriceChangeEventDTOBase : IEventDTO
    {
        [Parameter("string", "taskCode", 1, false )]
        public virtual string TaskCode { get; set; }
    }

    public partial class OnRescheduledEventDTO : OnRescheduledEventDTOBase { }

    [Event("OnRescheduled")]
    public class OnRescheduledEventDTOBase : IEventDTO
    {
        [Parameter("string", "taskCode", 1, false )]
        public virtual string TaskCode { get; set; }
        [Parameter("uint256", "quantity", 2, false )]
        public virtual BigInteger Quantity { get; set; }
        [Parameter("uint256", "actionOn", 3, false )]
        public virtual BigInteger ActionOn { get; set; }
    }

    public partial class OnStatusChangeEventDTO : OnStatusChangeEventDTOBase { }

    [Event("OnStatusChange")]
    public class OnStatusChangeEventDTOBase : IEventDTO
    {
        [Parameter("string", "taskCode", 1, false )]
        public virtual string TaskCode { get; set; }
        [Parameter("uint8", "status", 2, false )]
        public virtual byte Status { get; set; }
        [Parameter("uint256", "actionedOn", 3, false )]
        public virtual BigInteger ActionedOn { get; set; }
    }



    public partial class GetHeaderOutputDTO : GetHeaderOutputDTOBase { }

    [FunctionOutput]
    public class GetHeaderOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "_taskCode", 1)]
        public virtual string TaskCode { get; set; }
        [Parameter("address", "_targetConsortium", 2)]
        public virtual string TargetConsortium { get; set; }
        [Parameter("uint8", "_polarity", 3)]
        public virtual byte Polarity { get; set; }
        [Parameter("string", "_activityCode", 4)]
        public virtual string ActivityCode { get; set; }
        [Parameter("string", "_description", 5)]
        public virtual string Description { get; set; }
        [Parameter("string", "_title", 6)]
        public virtual string Title { get; set; }
        [Parameter("string", "_unitOfMeasure", 7)]
        public virtual string UnitOfMeasure { get; set; }
        [Parameter("string", "_unitOfCharge", 8)]
        public virtual string UnitOfCharge { get; set; }
    }

    public partial class GetScheduleOutputDTO : GetScheduleOutputDTOBase { }

    [FunctionOutput]
    public class GetScheduleOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "_status", 1)]
        public virtual byte Status { get; set; }
        [Parameter("uint256", "_actionOn", 2)]
        public virtual BigInteger ActionOn { get; set; }
        [Parameter("uint256", "_unitCharge", 3)]
        public virtual BigInteger UnitCharge { get; set; }
        [Parameter("uint256", "_quantityOrdered", 4)]
        public virtual BigInteger QuantityOrdered { get; set; }
        [Parameter("uint256", "_taxRate", 5)]
        public virtual BigInteger TaxRate { get; set; }
        [Parameter("uint256", "_quantityDelivered", 6)]
        public virtual BigInteger QuantityDelivered { get; set; }
    }



    public partial class IsInitialisedOutputDTO : IsInitialisedOutputDTOBase { }

    [FunctionOutput]
    public class IsInitialisedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "isInitialised", 1)]
        public virtual bool IsInitialised { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "eoa", 1)]
        public virtual string Eoa { get; set; }
    }








}