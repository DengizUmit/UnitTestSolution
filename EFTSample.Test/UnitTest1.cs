using Microsoft.VisualStudio.TestTools.UnitTesting;
using static EFTSample.Program;

namespace EFTSample.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TransferMoney_WithZeroAmountThenTransferFailedTest()
        {
            var transferResponse = new TransferResponse
            {
                IsSuccess = false,
                Message = "Amount must be greater Then 1"
            };

            var transfer = new Transfer();

            var transferRequest = new TransferRequest
            {
                Amount = 0,
                ReceiverIBAN = "TR806541651616516499971",
                SenderIBAN = "TR13216498468499980"
            };

            var actual = transfer.MoneyTransfer(transferRequest);

            Assert.AreEqual(transferResponse.IsSuccess, actual.IsSuccess);
            Assert.AreEqual(transferResponse.Message, actual.Message);
        }
    }
}