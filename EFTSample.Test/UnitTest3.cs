using Microsoft.VisualStudio.TestTools.UnitTesting;
using static EFTSample.Program;

namespace EFTSample.Test
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TransferMoney_WithCorrectRequestParameterThenTransferOKTest()
        {
            var transferResponse = new TransferResponse
            {
                IsSuccess = true,
                Message = "Transfer operation is successfull."
            };

            var transfer = new Transfer();

            var transferRequest = new TransferRequest
            {
                Amount = 99,
                SenderIBAN = "TR806541651616516499971",
                ReceiverIBAN = "TR13216498468499980"
            };

            var actual = transfer.MoneyTransfer(transferRequest);

            Assert.AreEqual(transferResponse.IsSuccess, actual.IsSuccess);
            Assert.AreEqual(transferResponse.Message, actual.Message);
        }
    }
}