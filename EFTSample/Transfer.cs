using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EFTSample.Program;

namespace EFTSample
{
    public class Transfer
    {
        public TransferResponse MoneyTransfer(TransferRequest request)
        {
            var response = new TransferResponse();

            if (request.Amount < 1)
            {
                response.IsSuccess = false;
                response.Message = "Amount must be greater Then 1";
                return response;
            }

            if (string.IsNullOrEmpty(request.SenderIBAN))
            {
                response.IsSuccess = false;
                response.Message = "Sender Account IBAN must not be null or empty.";
                return response;
            }

            if (string.IsNullOrEmpty(request.ReceiverIBAN))
            {
                response.IsSuccess = false;
                response.Message = "Receiver Account IBAN must not be null or empty.";
                return response;
            }

            response.IsSuccess = true;
            response.Message = "Transfer operation is successfull ;)";
            return response;
        }
    }

}
